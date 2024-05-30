using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SportHighSchool
{
    public partial class FrmAssessments : Form
    {
        SqlDataAdapter Ad;
        DataSet DS;
        SqlConnection con;
        SqlCommand com;

        public FrmAssessments()
        {
            InitializeComponent();
        }

        private void FrmAssessments_Load(object sender, EventArgs e)
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

            Ad = new SqlDataAdapter("SELECT A.AssessmentID AS N'شناسه',S.FirstName+' '+S.LastName AS N'نام و نام خانوادگی',A.HealthStatus AS N'وضعیت سلامت',A.GroupEvaluationScore AS N'نمره ارزشیابی گروهی',A.AttitudinalField AS N'حیطه نگرشی',A.LifeTopics AS N'موضوعات زندگی',A.ConceptsSkillPhysicalFitness AS N'مفاهیم مهارتی و آمادگی جسمانی' FROM Assessments A INNER JOIN Students S ON A.StudentID = S.StudentID Where Convert(nvarchar(50),A.AssessmentID)+' '+S.FirstName+' '+S.LastName+' '+A.HealthStatus+' '+A.GroupEvaluationScore+' '+A.AttitudinalField+' '+A.LifeTopics+' '+A.ConceptsSkillPhysicalFitness  LIKE N'%'+@Search+'%' ORDER BY A.AssessmentID DESC", con);
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
                txtAssessmentID.Text = DgvList.CurrentRow.Cells["شناسه"].Value.ToString();

                if (txtAssessmentID.Text != "0")
                {
                    txtAssessmentID.Text = DgvList.CurrentRow.Cells["شناسه"].Value.ToString();
                    ComStudentID.Text = DgvList.CurrentRow.Cells["نام و نام خانوادگی"].Value.ToString();
                    txtHealthStatus.Text = DgvList.CurrentRow.Cells["وضعیت سلامت"].Value.ToString();
                    txtGroupEvaluationScore.Text = DgvList.CurrentRow.Cells["نمره ارزشیابی گروهی"].Value.ToString();
                    txtAttitudinalField.Text = DgvList.CurrentRow.Cells["حیطه نگرشی"].Value.ToString();
                    txtLifeTopics.Text = DgvList.CurrentRow.Cells["موضوعات زندگی"].Value.ToString();
                    txtConceptsSkillPhysicalFitness.Text = DgvList.CurrentRow.Cells["مفاهیم مهارتی و آمادگی جسمانی"].Value.ToString();

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

            txtAssessmentID.Text = "0";
            try { ComStudentID.SelectedIndex = 0; } catch { }
            txtHealthStatus.Text = "";
            txtGroupEvaluationScore.Text = "";
            txtAttitudinalField.Text = "";
            txtLifeTopics.Text = "";
            txtConceptsSkillPhysicalFitness.Text = "";

            BtnDelete.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtAssessmentID.Text == "0")
            {
                if (MessageBox.Show("آیا از ثبت رکورد جدید مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                    com = new SqlCommand("INSERT INTO Assessments (StudentID,HealthStatus,GroupEvaluationScore,AttitudinalField,LifeTopics,ConceptsSkillPhysicalFitness) VALUES (@StudentID,@HealthStatus,@GroupEvaluationScore,@AttitudinalField,@LifeTopics,@ConceptsSkillPhysicalFitness)", con);
                    com.Parameters.AddWithValue("@StudentID", ComStudentID.SelectedValue);
                    com.Parameters.AddWithValue("@HealthStatus", txtHealthStatus.Text);
                    com.Parameters.AddWithValue("@GroupEvaluationScore", txtGroupEvaluationScore.Text);
                    com.Parameters.AddWithValue("@AttitudinalField", txtAttitudinalField.Text);
                    com.Parameters.AddWithValue("@LifeTopics", txtLifeTopics.Text);
                    com.Parameters.AddWithValue("@ConceptsSkillPhysicalFitness", txtConceptsSkillPhysicalFitness.Text);
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
                    com = new SqlCommand("UPDATE Assessments SET StudentID=@StudentID,HealthStatus=@HealthStatus,GroupEvaluationScore=@GroupEvaluationScore,AttitudinalField=@AttitudinalField,LifeTopics=@LifeTopics,ConceptsSkillPhysicalFitness=@ConceptsSkillPhysicalFitness Where AssessmentID=@AssessmentID", con);
                    com.Parameters.AddWithValue("@AssessmentID", txtAssessmentID.Text);
                    com.Parameters.AddWithValue("@StudentID", ComStudentID.SelectedValue);
                    com.Parameters.AddWithValue("@HealthStatus", txtHealthStatus.Text);
                    com.Parameters.AddWithValue("@GroupEvaluationScore", txtGroupEvaluationScore.Text);
                    com.Parameters.AddWithValue("@AttitudinalField", txtAttitudinalField.Text);
                    com.Parameters.AddWithValue("@LifeTopics", txtLifeTopics.Text);
                    com.Parameters.AddWithValue("@ConceptsSkillPhysicalFitness", txtConceptsSkillPhysicalFitness.Text);
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
            if (txtAssessmentID.Text != "0")
            {
                if (MessageBox.Show("آیا از حذف رکورد مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                        com = new SqlCommand("DELETE FROM Assessments Where AssessmentID=@AssessmentID", con);
                        com.Parameters.AddWithValue("@AssessmentID", txtAssessmentID.Text);
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
