using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SportHighSchool
{
    public partial class FrmStudents : Form
    {
        SqlDataAdapter Ad;
        DataSet DS;
        SqlConnection con;
        SqlCommand com;

        public FrmStudents()
        {
            InitializeComponent();
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            BtnSearch_Click(null, null);
            BtnNew_Click(null, null);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            const int WM_KEYDOWN = 0x100;

            if (msg.Msg == WM_KEYDOWN && keyData == (Keys.Escape))
            {
                this.Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(FrmMain.ConnectionString); con.Open();

            Ad = new SqlDataAdapter("SELECT StudentID AS N'شناسه',FirstName AS N'نام',LastName AS N'نام خانوادگی',FatherName AS N'نام پدر',NationalCode AS N'کد ملی',Mobile AS N'شماره همراه' FROM Students Where Convert(nvarchar(50),StudentID)+' '+FirstName+' '+LastName+' '+FatherName+' '+NationalCode+' '+Mobile LIKE N'%'+@Search+'%' ORDER BY StudentID DESC", con);
            Ad.SelectCommand.CommandTimeout = 3600;
            Ad.SelectCommand.Parameters.AddWithValue("@Search", txtSearch.Text);
            DS = new DataSet();
            Ad.Fill(DS, "DT");
            con.Close(); con.Dispose();
            DgvList.DataSource = DS.Tables["DT"];
            DgvList.Refresh();
        }

        private void DgvList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtStudentID.Text = DgvList.CurrentRow.Cells["شناسه"].Value.ToString();

                if (txtStudentID.Text != "0")
                {
                    txtStudentID.Text = DgvList.CurrentRow.Cells["شناسه"].Value.ToString();
                    txtFirstName.Text = DgvList.CurrentRow.Cells["نام"].Value.ToString();
                    txtLastName.Text = DgvList.CurrentRow.Cells["نام خانوادگی"].Value.ToString();
                    txtFatherName.Text = DgvList.CurrentRow.Cells["نام پدر"].Value.ToString();
                    txtNationalCode.Text = DgvList.CurrentRow.Cells["کد ملی"].Value.ToString();
                    txtMobile.Text = DgvList.CurrentRow.Cells["شماره همراه"].Value.ToString();

                    BtnDelete.Enabled = true;
                }
                else
                {
                    BtnNew_Click(null, null);
                }
            }
            catch
            {

            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = "0";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtFatherName.Text = "";
            txtNationalCode.Text = "";
            txtMobile.Text = "";

            BtnDelete.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text == "0")
            {
                if (MessageBox.Show("آیا از ثبت رکورد جدید مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                    com = new SqlCommand("INSERT INTO Students (FirstName,LastName,FatherName,NationalCode,Mobile) VALUES (@FirstName,@LastName,@FatherName,@NationalCode,@Mobile)", con);
                    com.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    com.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    com.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                    com.Parameters.AddWithValue("@NationalCode", txtNationalCode.Text);
                    com.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                    com.ExecuteNonQuery();
                    con.Close(); con.Dispose();

                    MessageBox.Show("اطلاعات با موفقیت ثبت گردید", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnSearch_Click(null, null);
                    BtnNew_Click(null, null);
                }
            }
            else
            {
                if (MessageBox.Show("آیا از ویرایش اطلاعات مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                    com = new SqlCommand("UPDATE Students SET FirstName=@FirstName,LastName=@LastName,FatherName=@FatherName,NationalCode=@NationalCode,Mobile=@Mobile Where StudentID=@StudentID", con);
                    com.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
                    com.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    com.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    com.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                    com.Parameters.AddWithValue("@NationalCode", txtNationalCode.Text);
                    com.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                    com.ExecuteNonQuery();
                    con.Close(); con.Dispose();

                    MessageBox.Show("اطلاعات با موفقیت ویرایش گردید", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnSearch_Click(null, null);
                    BtnNew_Click(null, null);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text != "0")
            {
                if (MessageBox.Show("آیا از حذف رکورد مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                        com = new SqlCommand("DELETE FROM Students Where StudentID=@StudentID", con);
                        com.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
                        com.ExecuteNonQuery();
                        con.Close(); con.Dispose();

                        MessageBox.Show("اطلاعات با موفقیت حذف گردید", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnSearch_Click(null, null);
                        BtnNew_Click(null, null);
                    }
                    catch
                    {
                        MessageBox.Show("حذف رکورد امکان پذیر نمی باشد", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
