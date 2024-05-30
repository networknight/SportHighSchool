using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SportHighSchool
{
    public partial class FrmPresences : Form
    {
        SqlDataAdapter Ad;
        DataSet DS;
        SqlConnection con;
        SqlCommand com;

        public FrmPresences()
        {
            InitializeComponent();
        }

        private void FrmPresences_Load(object sender, EventArgs e)
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

            Ad = new SqlDataAdapter("SELECT P.PresenceID AS N'شناسه',S.FirstName+' '+S.LastName AS N'نام و نام خانوادگی',P.GroupName AS N'گروه',P.PhysicalCondition AS N'وضعیت جسمانی',P.InterestOrSportsField AS N'علاقه یا رشته ورزشی',P.InputEvaluation AS N'ارزشیابی ورودی',P.Feedback AS N'بازخورد' FROM Presences P INNER JOIN Students S ON P.StudentID=S.StudentID Where Convert(nvarchar(50),P.PresenceID)+' '+S.FirstName+' '+S.LastName+' '+P.GroupName+' '+P.PhysicalCondition+' '+P.InterestOrSportsField+' '+P.InputEvaluation+' '+P.Feedback LIKE N'%'+@Search+'%' ORDER BY P.PresenceID DESC", con);
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
                txtPresenceID.Text = DgvList.CurrentRow.Cells["شناسه"].Value.ToString();

                if (txtPresenceID.Text != "0")
                {
                    txtPresenceID.Text = DgvList.CurrentRow.Cells["شناسه"].Value.ToString();
                    ComStudentID.Text = DgvList.CurrentRow.Cells["نام و نام خانوادگی"].Value.ToString();
                    txtGroupName.Text = DgvList.CurrentRow.Cells["گروه"].Value.ToString();
                    txtPhysicalCondition.Text = DgvList.CurrentRow.Cells["وضعیت جسمانی"].Value.ToString();
                    txtInterestOrSportsField.Text = DgvList.CurrentRow.Cells["علاقه یا رشته ورزشی"].Value.ToString();
                    txtInputEvaluation.Text = DgvList.CurrentRow.Cells["ارزشیابی ورودی"].Value.ToString();
                    txtFeedback.Text = DgvList.CurrentRow.Cells["بازخورد"].Value.ToString();

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

            Ad = new SqlDataAdapter("SELECT  StudentID, FirstName+' '+LastName AS Name FROM Students", con);
            Ad.SelectCommand.CommandTimeout = 3600;
            DS = new DataSet();
            Ad.Fill(DS, "DT");
            con.Close(); con.Dispose();
            ComStudentID.DataSource = DS.Tables["DT"];

            txtPresenceID.Text = "0";
            try { ComStudentID.SelectedIndex = 0; } catch { }            
            txtGroupName.Text = "";
            txtPhysicalCondition.Text = "";
            txtInterestOrSportsField.Text = "";
            txtInputEvaluation.Text = "";
            txtFeedback.Text = "";

            BtnDelete.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtPresenceID.Text == "0")
            {
                if (MessageBox.Show("آیا از ثبت رکورد جدید مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                    com = new SqlCommand("INSERT INTO Presences (StudentID,GroupName,PhysicalCondition,InterestOrSportsField,InputEvaluation,Feedback) VALUES  (@StudentID,@GroupName,@PhysicalCondition,@InterestOrSportsField,@InputEvaluation,@Feedback)", con);
                    com.Parameters.AddWithValue("@StudentID", ComStudentID.SelectedValue);
                    com.Parameters.AddWithValue("@GroupName", txtGroupName.Text);
                    com.Parameters.AddWithValue("@PhysicalCondition", txtPhysicalCondition.Text);
                    com.Parameters.AddWithValue("@InterestOrSportsField", txtInterestOrSportsField.Text);
                    com.Parameters.AddWithValue("@InputEvaluation", txtInputEvaluation.Text);
                    com.Parameters.AddWithValue("@Feedback", txtFeedback.Text);
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
                    com = new SqlCommand("UPDATE Presences SET StudentID=@StudentID,GroupName=@GroupName,PhysicalCondition=@PhysicalCondition,InterestOrSportsField=@InterestOrSportsField,InputEvaluation=@InputEvaluation,Feedback=@Feedback Where PresenceID=PresenceID", con);
                    com.Parameters.AddWithValue("@PresenceID", txtPresenceID.Text);
                    com.Parameters.AddWithValue("@StudentID", ComStudentID.SelectedValue);
                    com.Parameters.AddWithValue("@GroupName", txtGroupName.Text);
                    com.Parameters.AddWithValue("@PhysicalCondition", txtPhysicalCondition.Text);
                    com.Parameters.AddWithValue("@InterestOrSportsField", txtInterestOrSportsField.Text);
                    com.Parameters.AddWithValue("@InputEvaluation", txtInputEvaluation.Text);
                    com.Parameters.AddWithValue("@Feedback", txtFeedback.Text);
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
            if (txtPresenceID.Text != "0")
            {
                if (MessageBox.Show("آیا از حذف رکورد مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                        com = new SqlCommand("DELETE FROM Presences Where PresenceID=@PresenceID", con);
                        com.Parameters.AddWithValue("@PresenceID", txtPresenceID.Text);
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
