using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SportHighSchool
{
    public partial class FrmSportEvents : Form
    {
        SqlDataAdapter Ad;
        DataSet DS;
        SqlConnection con;
        SqlCommand com;
        public FrmSportEvents()
        {
            InitializeComponent();
        }

        private void FrmSportEvents_Load(object sender, EventArgs e)
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

            Ad = new SqlDataAdapter("SELECT SportEventID AS N'شناسه',NameSurnameInjured AS N'نام و نام خانوادگی مصدوم',NameFatherOrLegalGuardian AS N'نام پدر یا قیم قانونی',NameSchool AS N'نام آموزشگاه',TypeAccident AS N'نوع وقوع حادثه',TypeInjuryAndSymptoms AS N'نوع آسیب دیدگی و علائم' FROM  SportEvents Where Convert(nvarchar(50),SportEventID)+' '+NameSurnameInjured+' '+NameFatherOrLegalGuardian+' '+NameSchool+' '+TypeAccident+' '+TypeInjuryAndSymptoms LIKE N'%'+@Search+'%' ORDER BY SportEventID DESC", con);
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
                txtSportEventID.Text = DgvList.CurrentRow.Cells["شناسه"].Value.ToString();

                if (txtSportEventID.Text != "0")
                {
                    txtSportEventID.Text = DgvList.CurrentRow.Cells["شناسه"].Value.ToString();
                    txtNameSurnameInjured.Text = DgvList.CurrentRow.Cells["نام و نام خانوادگی مصدوم"].Value.ToString();
                    txtNameFatherOrLegalGuardian.Text = DgvList.CurrentRow.Cells["نام پدر یا قیم قانونی"].Value.ToString();
                    txtNameSchool.Text = DgvList.CurrentRow.Cells["نام آموزشگاه"].Value.ToString();
                    txtTypeAccident.Text = DgvList.CurrentRow.Cells["نوع وقوع حادثه"].Value.ToString();
                    txtTypeInjuryAndSymptoms.Text = DgvList.CurrentRow.Cells["نوع آسیب دیدگی و علائم"].Value.ToString();

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
            txtSportEventID.Text = "0";
            txtNameSurnameInjured.Text = "";
            txtNameFatherOrLegalGuardian.Text = "";
            txtNameSchool.Text = "";
            txtTypeAccident.Text = "";
            txtTypeInjuryAndSymptoms.Text = "";

            BtnDelete.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtSportEventID.Text == "0")
            {
                if (MessageBox.Show("آیا از ثبت رکورد جدید مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                    com = new SqlCommand("INSERT INTO SportEvents (NameSurnameInjured,NameFatherOrLegalGuardian,NameSchool,TypeAccident,TypeInjuryAndSymptoms) VALUES (@NameSurnameInjured,@NameFatherOrLegalGuardian,@NameSchool,@TypeAccident,@TypeInjuryAndSymptoms)", con);
                    com.Parameters.AddWithValue("@NameSurnameInjured", txtNameSurnameInjured.Text);
                    com.Parameters.AddWithValue("@NameFatherOrLegalGuardian", txtNameFatherOrLegalGuardian.Text);
                    com.Parameters.AddWithValue("@NameSchool", txtNameSchool.Text);
                    com.Parameters.AddWithValue("@txtTypeAccident", txtTypeAccident.Text);
                    com.Parameters.AddWithValue("@TypeInjuryAndSymptoms", txtTypeInjuryAndSymptoms.Text);
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
                    com = new SqlCommand("UPDATE SportEvents SET  NameSurnameInjured=@NameSurnameInjured,NameFatherOrLegalGuardian=@NameFatherOrLegalGuardian,NameSchool=@NameSchool,TypeAccident=@TypeAccident,TypeInjuryAndSymptoms=@TypeInjuryAndSymptoms Where SportEventID=@SportEventID", con);
                    com.Parameters.AddWithValue("@SportEventID", txtSportEventID.Text);
                    com.Parameters.AddWithValue("@NameSurnameInjured", txtNameSurnameInjured.Text);
                    com.Parameters.AddWithValue("@NameFatherOrLegalGuardian", txtNameFatherOrLegalGuardian.Text);
                    com.Parameters.AddWithValue("@NameSchool", txtNameSchool.Text);
                    com.Parameters.AddWithValue("@txtTypeAccident", txtTypeAccident.Text);
                    com.Parameters.AddWithValue("@TypeInjuryAndSymptoms", txtTypeInjuryAndSymptoms.Text);
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
            if (txtSportEventID.Text != "0")
            {
                if (MessageBox.Show("آیا از حذف رکورد مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                        com = new SqlCommand("DELETE FROM SportEvents Where SportEventID=@SportEventID", con);
                        com.Parameters.AddWithValue("@SportEventID", txtSportEventID.Text);
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
