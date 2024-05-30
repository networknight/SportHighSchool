namespace SportHighSchool
{
    partial class FrmSportEquipments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbSportEquipmentID = new System.Windows.Forms.Label();
            this.txtSportEquipmentID = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GroupItem = new System.Windows.Forms.GroupBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.LbDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.LbCountEquipment = new System.Windows.Forms.Label();
            this.LbEssentialsNeeded = new System.Windows.Forms.Label();
            this.txtEssentialsNeeded = new System.Windows.Forms.TextBox();
            this.ComSportEquipmentGroupID = new System.Windows.Forms.ComboBox();
            this.LbCityID = new System.Windows.Forms.Label();
            this.ComSchoolID = new System.Windows.Forms.ComboBox();
            this.LbProvinceID = new System.Windows.Forms.Label();
            this.ComCountEquipment = new System.Windows.Forms.ComboBox();
            this.GroupItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // LbSportEquipmentID
            // 
            this.LbSportEquipmentID.AutoSize = true;
            this.LbSportEquipmentID.Location = new System.Drawing.Point(804, 54);
            this.LbSportEquipmentID.Name = "LbSportEquipmentID";
            this.LbSportEquipmentID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbSportEquipmentID.Size = new System.Drawing.Size(49, 13);
            this.LbSportEquipmentID.TabIndex = 9;
            this.LbSportEquipmentID.Text = "شناسه :";
            // 
            // txtSportEquipmentID
            // 
            this.txtSportEquipmentID.Enabled = false;
            this.txtSportEquipmentID.Location = new System.Drawing.Point(655, 74);
            this.txtSportEquipmentID.MaxLength = 50;
            this.txtSportEquipmentID.Name = "txtSportEquipmentID";
            this.txtSportEquipmentID.Size = new System.Drawing.Size(200, 21);
            this.txtSportEquipmentID.TabIndex = 10;
            this.txtSportEquipmentID.Text = "0";
            this.txtSportEquipmentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnNew
            // 
            this.BtnNew.Image = global::SportHighSchool.Properties.Resources.New;
            this.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNew.Location = new System.Drawing.Point(320, 20);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(100, 50);
            this.BtnNew.TabIndex = 6;
            this.BtnNew.Text = "ایجاد";
            this.BtnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::SportHighSchool.Properties.Resources.Save;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(215, 20);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 50);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "ثبت";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::SportHighSchool.Properties.Resources.Delete;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Location = new System.Drawing.Point(110, 20);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 50);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Image = global::SportHighSchool.Properties.Resources.Exit;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(5, 20);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(100, 50);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "بستن";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GroupItem
            // 
            this.GroupItem.Controls.Add(this.ComCountEquipment);
            this.GroupItem.Controls.Add(this.LbDescription);
            this.GroupItem.Controls.Add(this.txtDescription);
            this.GroupItem.Controls.Add(this.LbCountEquipment);
            this.GroupItem.Controls.Add(this.LbEssentialsNeeded);
            this.GroupItem.Controls.Add(this.txtEssentialsNeeded);
            this.GroupItem.Controls.Add(this.ComSportEquipmentGroupID);
            this.GroupItem.Controls.Add(this.LbCityID);
            this.GroupItem.Controls.Add(this.ComSchoolID);
            this.GroupItem.Controls.Add(this.LbProvinceID);
            this.GroupItem.Controls.Add(this.LbSportEquipmentID);
            this.GroupItem.Controls.Add(this.txtSportEquipmentID);
            this.GroupItem.Controls.Add(this.BtnNew);
            this.GroupItem.Controls.Add(this.BtnSave);
            this.GroupItem.Controls.Add(this.BtnDelete);
            this.GroupItem.Controls.Add(this.BtnExit);
            this.GroupItem.Location = new System.Drawing.Point(5, 0);
            this.GroupItem.Margin = new System.Windows.Forms.Padding(10);
            this.GroupItem.Name = "GroupItem";
            this.GroupItem.Size = new System.Drawing.Size(865, 225);
            this.GroupItem.TabIndex = 0;
            this.GroupItem.TabStop = false;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(570, 246);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "جستجو";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(660, 246);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(200, 21);
            this.txtSearch.TabIndex = 2;
            // 
            // DgvList
            // 
            this.DgvList.AllowUserToAddRows = false;
            this.DgvList.AllowUserToDeleteRows = false;
            this.DgvList.AllowUserToResizeColumns = false;
            this.DgvList.AllowUserToResizeRows = false;
            this.DgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvList.Location = new System.Drawing.Point(0, 295);
            this.DgvList.MultiSelect = false;
            this.DgvList.Name = "DgvList";
            this.DgvList.ReadOnly = true;
            this.DgvList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvList.RowHeadersVisible = false;
            this.DgvList.RowHeadersWidth = 50;
            this.DgvList.Size = new System.Drawing.Size(874, 366);
            this.DgvList.TabIndex = 3;
            this.DgvList.DoubleClick += new System.EventHandler(this.DgvList_DoubleClick);
            // 
            // LbDescription
            // 
            this.LbDescription.AutoSize = true;
            this.LbDescription.Location = new System.Drawing.Point(798, 160);
            this.LbDescription.Name = "LbDescription";
            this.LbDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbDescription.Size = new System.Drawing.Size(54, 13);
            this.LbDescription.TabIndex = 15;
            this.LbDescription.Text = "توضیحات :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(9, 180);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(846, 21);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LbCountEquipment
            // 
            this.LbCountEquipment.AutoSize = true;
            this.LbCountEquipment.Location = new System.Drawing.Point(169, 105);
            this.LbCountEquipment.Name = "LbCountEquipment";
            this.LbCountEquipment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbCountEquipment.Size = new System.Drawing.Size(37, 13);
            this.LbCountEquipment.TabIndex = 14;
            this.LbCountEquipment.Text = "تعداد :";
            // 
            // LbEssentialsNeeded
            // 
            this.LbEssentialsNeeded.AutoSize = true;
            this.LbEssentialsNeeded.Location = new System.Drawing.Point(326, 105);
            this.LbEssentialsNeeded.Name = "LbEssentialsNeeded";
            this.LbEssentialsNeeded.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbEssentialsNeeded.Size = new System.Drawing.Size(92, 13);
            this.LbEssentialsNeeded.TabIndex = 13;
            this.LbEssentialsNeeded.Text = "ملزومات مورد نیاز :";
            // 
            // txtEssentialsNeeded
            // 
            this.txtEssentialsNeeded.Location = new System.Drawing.Point(220, 125);
            this.txtEssentialsNeeded.MaxLength = 50;
            this.txtEssentialsNeeded.Name = "txtEssentialsNeeded";
            this.txtEssentialsNeeded.Size = new System.Drawing.Size(200, 21);
            this.txtEssentialsNeeded.TabIndex = 2;
            this.txtEssentialsNeeded.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ComSportEquipmentGroupID
            // 
            this.ComSportEquipmentGroupID.DisplayMember = "SportEquipmentGroup";
            this.ComSportEquipmentGroupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComSportEquipmentGroupID.FormattingEnabled = true;
            this.ComSportEquipmentGroupID.Location = new System.Drawing.Point(435, 125);
            this.ComSportEquipmentGroupID.Name = "ComSportEquipmentGroupID";
            this.ComSportEquipmentGroupID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComSportEquipmentGroupID.Size = new System.Drawing.Size(200, 21);
            this.ComSportEquipmentGroupID.TabIndex = 1;
            this.ComSportEquipmentGroupID.ValueMember = "SportEquipmentGroupID";
            // 
            // LbCityID
            // 
            this.LbCityID.AutoSize = true;
            this.LbCityID.Location = new System.Drawing.Point(557, 107);
            this.LbCityID.Name = "LbCityID";
            this.LbCityID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbCityID.Size = new System.Drawing.Size(75, 13);
            this.LbCityID.TabIndex = 12;
            this.LbCityID.Text = "گروه ملزومات :";
            // 
            // ComSchoolID
            // 
            this.ComSchoolID.DisplayMember = "SchoolName";
            this.ComSchoolID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComSchoolID.FormattingEnabled = true;
            this.ComSchoolID.Location = new System.Drawing.Point(655, 125);
            this.ComSchoolID.Name = "ComSchoolID";
            this.ComSchoolID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComSchoolID.Size = new System.Drawing.Size(200, 21);
            this.ComSchoolID.TabIndex = 0;
            this.ComSchoolID.ValueMember = "SchoolID";
            // 
            // LbProvinceID
            // 
            this.LbProvinceID.AutoSize = true;
            this.LbProvinceID.Location = new System.Drawing.Point(780, 107);
            this.LbProvinceID.Name = "LbProvinceID";
            this.LbProvinceID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbProvinceID.Size = new System.Drawing.Size(73, 13);
            this.LbProvinceID.TabIndex = 11;
            this.LbProvinceID.Text = "نام آموزشگاه :";
            // 
            // ComCountEquipment
            // 
            this.ComCountEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComCountEquipment.FormattingEnabled = true;
            this.ComCountEquipment.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.ComCountEquipment.Location = new System.Drawing.Point(9, 125);
            this.ComCountEquipment.Name = "ComCountEquipment";
            this.ComCountEquipment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComCountEquipment.Size = new System.Drawing.Size(200, 21);
            this.ComCountEquipment.TabIndex = 3;
            // 
            // FrmSportEquipments
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(874, 661);
            this.ControlBox = false;
            this.Controls.Add(this.GroupItem);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.DgvList);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.MaximumSize = new System.Drawing.Size(890, 700);
            this.MinimumSize = new System.Drawing.Size(890, 700);
            this.Name = "FrmSportEquipments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تجهیزات ورزشی";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmSportEquipments_Load);
            this.GroupItem.ResumeLayout(false);
            this.GroupItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbSportEquipmentID;
        private System.Windows.Forms.TextBox txtSportEquipmentID;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox GroupItem;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.Label LbDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label LbCountEquipment;
        private System.Windows.Forms.Label LbEssentialsNeeded;
        private System.Windows.Forms.TextBox txtEssentialsNeeded;
        private System.Windows.Forms.ComboBox ComSportEquipmentGroupID;
        private System.Windows.Forms.Label LbCityID;
        private System.Windows.Forms.ComboBox ComSchoolID;
        private System.Windows.Forms.Label LbProvinceID;
        private System.Windows.Forms.ComboBox ComCountEquipment;
    }
}