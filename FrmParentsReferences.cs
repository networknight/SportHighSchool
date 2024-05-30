using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SportHighSchool
{
    public partial class FrmParentsReferences : Form
    {
        SqlDataAdapter Ad;
        DataSet DS;
        SqlConnection con;
        SqlCommand com;

        public FrmParentsReferences()
        {
            InitializeComponent();
        }

        private void FrmParentsReferences_Load(object sender, EventArgs e)
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

            Ad = new SqlDataAdapter("SELECT ParentsReferenceID AS N'شناسه',Name AS N'نام و نام خانوادگی',Class AS N'کلاس',Reason AS N'علت مراجعه',ReferenceDate AS N'تاریخ',Consideration AS N'ملاحظات' FROM  ParentsReferences Where Convert(nvarchar(50),ParentsReferenceID)+' '+Name+' '+Class+' '+Reason+' '+ReferenceDate+' '+Consideration LIKE N'%'+@Search+'%' ORDER BY ParentsReferenceID DESC", con);
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
                txtParentsReferenceID.Text = DgvList.CurrentRow.Cells["شناسه"].Value.ToString();

                if (txtParentsReferenceID.Text != "0")
                {
                    txtParentsReferenceID.Text = DgvList.CurrentRow.Cells["شناسه"].Value.ToString();
                    txtName.Text = DgvList.CurrentRow.Cells["نام و نام خانوادگی"].Value.ToString();
                    txtClass.Text = DgvList.CurrentRow.Cells["کلاس"].Value.ToString();
                    txtReason.Text = DgvList.CurrentRow.Cells["علت مراجعه"].Value.ToString();
                    txtReferenceDate.Text = DgvList.CurrentRow.Cells["تاریخ"].Value.ToString();
                    txtConsideration.Text = DgvList.CurrentRow.Cells["ملاحظات"].Value.ToString();

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
            txtParentsReferenceID.Text = "0";
            txtName.Text = "";
            txtClass.Text = "";
            txtReason.Text = "";
            txtReferenceDate.Text = "";
            txtConsideration.Text = "";

            BtnDelete.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtParentsReferenceID.Text == "0")
            {
                if (MessageBox.Show("آیا از ثبت رکورد جدید مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                    com = new SqlCommand("INSERT INTO ParentsReferences (Name,Class,Reason,ReferenceDate,Consideration) VALUES (@Name,@Class,@Reason,@ReferenceDate,@Consideration)", con);
                    com.Parameters.AddWithValue("@Name", txtName.Text);
                    com.Parameters.AddWithValue("@Class", txtClass.Text);
                    com.Parameters.AddWithValue("@Reason", txtReason.Text);
                    com.Parameters.AddWithValue("@ReferenceDate", txtReferenceDate.Text);
                    com.Parameters.AddWithValue("@Consideration", txtConsideration.Text);
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
                    com = new SqlCommand("UPDATE ParentsReferences SET Name=@Name,Class=@Class,Reason=@Reason,ReferenceDate=@ReferenceDate,Consideration=@Consideration Where ParentsReferenceID=@ParentsReferenceID", con);
                    com.Parameters.AddWithValue("@ParentsReferenceID", txtParentsReferenceID.Text);
                    com.Parameters.AddWithValue("@Name", txtName.Text);
                    com.Parameters.AddWithValue("@Class", txtClass.Text);
                    com.Parameters.AddWithValue("@Reason", txtReason.Text);
                    com.Parameters.AddWithValue("@ReferenceDate", txtReferenceDate.Text);
                    com.Parameters.AddWithValue("@Consideration", txtConsideration.Text);
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
            if (txtParentsReferenceID.Text != "0")
            {
                if (MessageBox.Show("آیا از حذف رکورد مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                        com = new SqlCommand("DELETE FROM ParentsReferences Where ParentsReferenceID=@ParentsReferenceID", con);
                        com.Parameters.AddWithValue("@ParentsReferenceID", txtParentsReferenceID.Text);
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
