namespace SportHighSchool
{
    partial class FrmWeeklyPhysicalEducationPrograms
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
            this.LbWeeklyPhysicalEducationProgramID = new System.Windows.Forms.Label();
            this.txtWeeklyPhysicalEducationProgramID = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GroupItem = new System.Windows.Forms.GroupBox();
            this.ComSchoolID = new System.Windows.Forms.ComboBox();
            this.LbSchoolID = new System.Windows.Forms.Label();
            this.LbClassHour4 = new System.Windows.Forms.Label();
            this.txtClassHour4 = new System.Windows.Forms.TextBox();
            this.LbClassHour3 = new System.Windows.Forms.Label();
            this.txtClassHour3 = new System.Windows.Forms.TextBox();
            this.LbClassHour2 = new System.Windows.Forms.Label();
            this.txtClassHour2 = new System.Windows.Forms.TextBox();
            this.LbClassHour1 = new System.Windows.Forms.Label();
            this.txtClassHour1 = new System.Windows.Forms.TextBox();
            this.LbWeekName = new System.Windows.Forms.Label();
            this.txtWeekName = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.GroupItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // LbWeeklyPhysicalEducationProgramID
            // 
            this.LbWeeklyPhysicalEducationProgramID.AutoSize = true;
            this.LbWeeklyPhysicalEducationProgramID.Location = new System.Drawing.Point(804, 54);
            this.LbWeeklyPhysicalEducationProgramID.Name = "LbWeeklyPhysicalEducationProgramID";
            this.LbWeeklyPhysicalEducationProgramID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbWeeklyPhysicalEducationProgramID.Size = new System.Drawing.Size(62, 17);
            this.LbWeeklyPhysicalEducationProgramID.TabIndex = 10;
            this.LbWeeklyPhysicalEducationProgramID.Text = "شناسه :";
            // 
            // txtWeeklyPhysicalEducationProgramID
            // 
            this.txtWeeklyPhysicalEducationProgramID.Enabled = false;
            this.txtWeeklyPhysicalEducationProgramID.Location = new System.Drawing.Point(655, 74);
            this.txtWeeklyPhysicalEducationProgramID.MaxLength = 50;
            this.txtWeeklyPhysicalEducationProgramID.Name = "txtWeeklyPhysicalEducationProgramID";
            this.txtWeeklyPhysicalEducationProgramID.Size = new System.Drawing.Size(200, 24);
            this.txtWeeklyPhysicalEducationProgramID.TabIndex = 11;
            this.txtWeeklyPhysicalEducationProgramID.Text = "0";
            this.txtWeeklyPhysicalEducationProgramID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.GroupItem.Controls.Add(this.ComSchoolID);
            this.GroupItem.Controls.Add(this.LbSchoolID);
            this.GroupItem.Controls.Add(this.LbClassHour4);
            this.GroupItem.Controls.Add(this.txtClassHour4);
            this.GroupItem.Controls.Add(this.LbClassHour3);
            this.GroupItem.Controls.Add(this.txtClassHour3);
            this.GroupItem.Controls.Add(this.LbClassHour2);
            this.GroupItem.Controls.Add(this.txtClassHour2);
            this.GroupItem.Controls.Add(this.LbClassHour1);
            this.GroupItem.Controls.Add(this.txtClassHour1);
            this.GroupItem.Controls.Add(this.LbWeekName);
            this.GroupItem.Controls.Add(this.txtWeekName);
            this.GroupItem.Controls.Add(this.LbWeeklyPhysicalEducationProgramID);
            this.GroupItem.Controls.Add(this.txtWeeklyPhysicalEducationProgramID);
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
            this.GroupItem.Enter += new System.EventHandler(this.GroupItem_Enter);
            // 
            // ComSchoolID
            // 
            this.ComSchoolID.DisplayMember = "SchoolName";
            this.ComSchoolID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComSchoolID.FormattingEnabled = true;
            this.ComSchoolID.Location = new System.Drawing.Point(655, 125);
            this.ComSchoolID.Name = "ComSchoolID";
            this.ComSchoolID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComSchoolID.Size = new System.Drawing.Size(200, 25);
            this.ComSchoolID.TabIndex = 0;
            this.ComSchoolID.ValueMember = "SchoolID";
            // 
            // LbSchoolID
            // 
            this.LbSchoolID.AutoSize = true;
            this.LbSchoolID.Location = new System.Drawing.Point(796, 107);
            this.LbSchoolID.Name = "LbSchoolID";
            this.LbSchoolID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbSchoolID.Size = new System.Drawing.Size(70, 17);
            this.LbSchoolID.TabIndex = 12;
            this.LbSchoolID.Text = "آموزشگاه :";
            // 
            // LbClassHour4
            // 
            this.LbClassHour4.AutoSize = true;
            this.LbClassHour4.Location = new System.Drawing.Point(559, 157);
            this.LbClassHour4.Name = "LbClassHour4";
            this.LbClassHour4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbClassHour4.Size = new System.Drawing.Size(94, 17);
            this.LbClassHour4.TabIndex = 17;
            this.LbClassHour4.Text = "ساعت چهارم :";
            // 
            // txtClassHour4
            // 
            this.txtClassHour4.Location = new System.Drawing.Point(437, 175);
            this.txtClassHour4.MaxLength = 50;
            this.txtClassHour4.Name = "txtClassHour4";
            this.txtClassHour4.Size = new System.Drawing.Size(200, 24);
            this.txtClassHour4.TabIndex = 5;
            this.txtClassHour4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LbClassHour3
            // 
            this.LbClassHour3.AutoSize = true;
            this.LbClassHour3.Location = new System.Drawing.Point(781, 157);
            this.LbClassHour3.Name = "LbClassHour3";
            this.LbClassHour3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbClassHour3.Size = new System.Drawing.Size(88, 17);
            this.LbClassHour3.TabIndex = 16;
            this.LbClassHour3.Text = "ساعت سوم :";
            // 
            // txtClassHour3
            // 
            this.txtClassHour3.Location = new System.Drawing.Point(655, 175);
            this.txtClassHour3.MaxLength = 50;
            this.txtClassHour3.Name = "txtClassHour3";
            this.txtClassHour3.Size = new System.Drawing.Size(200, 24);
            this.txtClassHour3.TabIndex = 4;
            this.txtClassHour3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LbClassHour2
            // 
            this.LbClassHour2.AutoSize = true;
            this.LbClassHour2.Location = new System.Drawing.Point(143, 105);
            this.LbClassHour2.Name = "LbClassHour2";
            this.LbClassHour2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbClassHour2.Size = new System.Drawing.Size(81, 17);
            this.LbClassHour2.TabIndex = 15;
            this.LbClassHour2.Text = "ساعت دوم :";
            // 
            // txtClassHour2
            // 
            this.txtClassHour2.Location = new System.Drawing.Point(11, 125);
            this.txtClassHour2.MaxLength = 50;
            this.txtClassHour2.Name = "txtClassHour2";
            this.txtClassHour2.Size = new System.Drawing.Size(200, 24);
            this.txtClassHour2.TabIndex = 3;
            this.txtClassHour2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LbClassHour1
            // 
            this.LbClassHour1.AutoSize = true;
            this.LbClassHour1.Location = new System.Drawing.Point(356, 105);
            this.LbClassHour1.Name = "LbClassHour1";
            this.LbClassHour1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbClassHour1.Size = new System.Drawing.Size(78, 17);
            this.LbClassHour1.TabIndex = 14;
            this.LbClassHour1.Text = "ساعت اول :";
            // 
            // txtClassHour1
            // 
            this.txtClassHour1.Location = new System.Drawing.Point(222, 125);
            this.txtClassHour1.MaxLength = 50;
            this.txtClassHour1.Name = "txtClassHour1";
            this.txtClassHour1.Size = new System.Drawing.Size(200, 24);
            this.txtClassHour1.TabIndex = 2;
            this.txtClassHour1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LbWeekName
            // 
            this.LbWeekName.AutoSize = true;
            this.LbWeekName.Location = new System.Drawing.Point(577, 105);
            this.LbWeekName.Name = "LbWeekName";
            this.LbWeekName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbWeekName.Size = new System.Drawing.Size(69, 17);
            this.LbWeekName.TabIndex = 13;
            this.LbWeekName.Text = "ایام هفته :";
            // 
            // txtWeekName
            // 
            this.txtWeekName.Location = new System.Drawing.Point(437, 125);
            this.txtWeekName.MaxLength = 50;
            this.txtWeekName.Name = "txtWeekName";
            this.txtWeekName.Size = new System.Drawing.Size(200, 24);
            this.txtWeekName.TabIndex = 1;
            this.txtWeekName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnNew
            // 
            this.BtnNew.Image = global::SportHighSchool.Properties.Resources.New;
            this.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNew.Location = new System.Drawing.Point(320, 20);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(100, 50);
            this.BtnNew.TabIndex = 9;
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
            this.BtnSave.TabIndex = 6;
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
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(570, 246);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 2;
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
            this.txtSearch.Size = new System.Drawing.Size(200, 24);
            this.txtSearch.TabIndex = 1;
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
            this.DgvList.Location = new System.Drawing.Point(0, 287);
            this.DgvList.MultiSelect = false;
            this.DgvList.Name = "DgvList";
            this.DgvList.ReadOnly = true;
            this.DgvList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvList.RowHeadersVisible = false;
            this.DgvList.RowHeadersWidth = 50;
            this.DgvList.Size = new System.Drawing.Size(872, 366);
            this.DgvList.TabIndex = 3;
            this.DgvList.DoubleClick += new System.EventHandler(this.DgvList_DoubleClick);
            // 
            // FrmWeeklyPhysicalEducationPrograms
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(872, 653);
            this.ControlBox = false;
            this.Controls.Add(this.GroupItem);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.DgvList);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.MaximumSize = new System.Drawing.Size(890, 700);
            this.MinimumSize = new System.Drawing.Size(890, 700);
            this.Name = "FrmWeeklyPhysicalEducationPrograms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامه های هفتگی تربیت بدنی";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmWeeklyPhysicalEducationPrograms_Load);
            this.GroupItem.ResumeLayout(false);
            this.GroupItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbWeeklyPhysicalEducationProgramID;
        private System.Windows.Forms.TextBox txtWeeklyPhysicalEducationProgramID;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox GroupItem;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.Label LbClassHour4;
        private System.Windows.Forms.TextBox txtClassHour4;
        private System.Windows.Forms.Label LbClassHour3;
        private System.Windows.Forms.TextBox txtClassHour3;
        private System.Windows.Forms.Label LbClassHour2;
        private System.Windows.Forms.TextBox txtClassHour2;
        private System.Windows.Forms.Label LbClassHour1;
        private System.Windows.Forms.TextBox txtClassHour1;
        private System.Windows.Forms.Label LbWeekName;
        private System.Windows.Forms.TextBox txtWeekName;
        private System.Windows.Forms.ComboBox ComSchoolID;
        private System.Windows.Forms.Label LbSchoolID;
    }
}