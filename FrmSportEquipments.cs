using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SportHighSchool
{
    public partial class FrmSportEquipments : Form
    {
        SqlDataAdapter Ad;
        DataSet DS;
        SqlConnection con;
        SqlCommand com;
        public FrmSportEquipments()
        {
            InitializeComponent();
        }

        private void FrmSportEquipments_Load(object sender, EventArgs e)
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

            Ad = new SqlDataAdapter("SELECT SE.SportEquipmentID AS N'شناسه',G.SportEquipmentGroup AS N'گروه ملزومات',S.SchoolName AS N'نام آموزشگاه',SE.EssentialsNeeded AS N'ملزومات مورد نیاز',SE.CountEquipment AS N'تعداد',SE.Description AS N'توضیحات' FROM SportEquipments SE INNER JOIN SportEquipmentGroups G ON SE.SportEquipmentGroupID = G.SportEquipmentGroupID INNER JOIN Schools S ON SE.SchoolID=S.SchoolID Where Convert(nvarchar(50),SE.SportEquipmentID)+' '+G.SportEquipmentGroup+' '+S.SchoolName+' '+SE.EssentialsNeeded+' '+SE.Description LIKE N'%'+@Search+'%' ORDER BY SE.SportEquipmentID DESC", con);
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
                txtSportEquipmentID.Text = DgvList.CurrentRow.Cells["شناسه"].Value.ToString();

                if (txtSportEquipmentID.Text != "0")
                {
                    txtSportEquipmentID.Text = DgvList.CurrentRow.Cells["شناسه"].Value.ToString();
                    ComSportEquipmentGroupID.Text = DgvList.CurrentRow.Cells["گروه ملزومات"].Value.ToString();
                    ComSchoolID.Text = DgvList.CurrentRow.Cells["نام آموزشگاه"].Value.ToString();
                    txtEssentialsNeeded.Text = DgvList.CurrentRow.Cells["ملزومات مورد نیاز"].Value.ToString();
                    ComCountEquipment.Text = DgvList.CurrentRow.Cells["تعداد"].Value.ToString();
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
            ComSchoolID.DataSource = DS.Tables["DT"];


            con = new SqlConnection(FrmMain.ConnectionString); con.Open();

            Ad = new SqlDataAdapter("SELECT SportEquipmentGroupID,SportEquipmentGroup FROM SportEquipmentGroups", con);
            Ad.SelectCommand.CommandTimeout = 3600;
            DS = new DataSet();
            Ad.Fill(DS, "DT");
            con.Close(); con.Dispose();
            ComSportEquipmentGroupID.DataSource = DS.Tables["DT"];

            txtSportEquipmentID.Text = "0";
            ComCountEquipment.SelectedIndex = 0;
            txtEssentialsNeeded.Text = "";
            txtDescription.Text = "";

            BtnDelete.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtSportEquipmentID.Text == "0")
            {
                if (MessageBox.Show("آیا از ثبت رکورد جدید مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                    com = new SqlCommand("INSERT INTO SportEquipments (SportEquipmentGroupID,SchoolID,EssentialsNeeded,CountEquipment,Description) VALUES (@SportEquipmentGroupID,@SchoolID,@EssentialsNeeded,@CountEquipment,@Description)", con);
                    com.Parameters.AddWithValue("@SportEquipmentGroupID", ComSportEquipmentGroupID.SelectedValue);
                    com.Parameters.AddWithValue("@SchoolID", ComSchoolID.SelectedValue);
                    com.Parameters.AddWithValue("@EssentialsNeeded", txtEssentialsNeeded.Text);
                    com.Parameters.AddWithValue("@CountEquipment", ComCountEquipment.Text);
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
                    com = new SqlCommand("UPDATE SportEquipments SET SportEquipmentGroupID=@SportEquipmentGroupID,SchoolID=@SchoolID,EssentialsNeeded=@EssentialsNeeded,CountEquipment=@CountEquipment,Description=@Description Where SportEquipmentID=@SportEquipmentID", con);
                    com.Parameters.AddWithValue("@SportEquipmentID", txtSportEquipmentID.Text);
                    com.Parameters.AddWithValue("@SportEquipmentGroupID", ComSportEquipmentGroupID.SelectedValue);
                    com.Parameters.AddWithValue("@SchoolID", ComSchoolID.SelectedValue);
                    com.Parameters.AddWithValue("@EssentialsNeeded", txtEssentialsNeeded.Text);
                    com.Parameters.AddWithValue("@CountEquipment", ComCountEquipment.SelectedValue);
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
            if (txtSportEquipmentID.Text != "0")
            {
                if (MessageBox.Show("آیا از حذف رکورد مطمئن هستید؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con = new SqlConnection(FrmMain.ConnectionString); con.Open();
                        com = new SqlCommand("DELETE FROM SportEquipments Where SportEquipmentID=@SportEquipmentID", con);
                        com.Parameters.AddWithValue("@SportEquipmentID", txtSportEquipmentID.Text);
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
