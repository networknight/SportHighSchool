using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SportHighSchool
{
    public partial class FrmSafetyReports : Form
    {
        SqlDataAdapter Ad;
        DataSet DS;
        SqlConnection con;
        SqlCommand com;

        public FrmSafetyReports()
        {
            InitializeComponent();
        }

        private void FrmSafetyReports_Load(object sender, EventArgs e)
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

            Ad = new SqlDataAdapter("SELECT SR.SafetyReportID AS N'شناسه',S.SchoolName AS N'آموزشگاه',SR.SafetyReport AS N'عنوان',SR.Description AS N'توضیحات' FROM SafetyReports SR INNER JOIN Schools S ON SR.SchoolID=S.SchoolID Where Convert(nvarchar(50),SR.SafetyReportID)+' '+S.SchoolName+' '+SR.SafetyReport+' '+SR.Description LIKE N'%'+@Search+'%' ORDER BY SR.SafetyReportID DESC", con);
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
                txtSafetyReportID.Text = DgvList.CurrentRow.Cells["شناسه"].Value.ToString();

                if (txtSafetyReportID.Text != "0")
                {
                    txtSafetyReportID.Text = DgvList.CurrentRow.Cells["شناسه"].Value.ToString();
                    ComSchoolName.Text = DgvList.CurrentRow.Cells["آموزشگاه"].Value.ToString();
                    txtSafetyReport.Text = DgvList.CurrentRow.Cells["عنوان"].Value.ToString();
                    txtDescription.Text = DgvList.CurrentRow.Cells["توضیحات"].Value.ToString();

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
            con = new SqlConnection(FrmMain.ConnectionString); con.Open();

            Ad = new SqlDataAdapter("SELECT SchoolID,SchoolName FROM Schools", con);
            Ad.SelectCommand.CommandTimeout = 3600;
            DS = new DataSet();
            Ad.Fill(DS, "DT");
            con.Close(); con.Dispose();
            ComSchoolName.DataSource = DS.Tables["DT"];

            txtSafetyReportID.Text = "0";
            try { ComSchoolName.SelectedIndex = 0; } catch { }
            txtSafetyReport.Text = "";
            txtDescription.Text = "";

            BtnDelete.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtSafetyReportID.Text == "0")
            {
                if (MessageBox.Show("آیا از ثبت رکورد جدید مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                    com = new SqlCommand("INSERT INTO SafetyReports (SchoolID,SafetyReport,Description) VALUES (@SchoolID,@SafetyReport,@Description)", con);
                    com.Parameters.AddWithValue("@SchoolID", ComSchoolName.SelectedValue);
                    com.Parameters.AddWithValue("@SafetyReport", txtSafetyReport.Text);
                    com.Parameters.AddWithValue("@Description", txtDescription.Text);
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
                    com = new SqlCommand("UPDATE SafetyReports SET SchoolID=@SchoolID,SafetyReport=@SafetyReport,Description=@Description Where SafetyReportID=@SafetyReportID", con);
                    com.Parameters.AddWithValue("@SafetyReportID", txtSafetyReportID.Text);
                    com.Parameters.AddWithValue("@SchoolID", ComSchoolName.SelectedValue);
                    com.Parameters.AddWithValue("@SafetyReport", txtSafetyReport.Text);
                    com.Parameters.AddWithValue("@Description", txtDescription.Text);
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
            if (txtSafetyReportID.Text != "0")
            {
                if (MessageBox.Show("آیا از حذف رکورد مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                        com = new SqlCommand("DELETE FROM SafetyReports Where SafetyReportID=@SafetyReportID", con);
                        com.Parameters.AddWithValue("@SafetyReportID", txtSafetyReportID.Text);
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
