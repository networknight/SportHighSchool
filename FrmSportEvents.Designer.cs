namespace SportHighSchool
{
    partial class FrmSportEvents
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
            this.LbSportEventID = new System.Windows.Forms.Label();
            this.txtSportEventID = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GroupItem = new System.Windows.Forms.GroupBox();
            this.txtNameFatherOrLegalGuardian = new System.Windows.Forms.TextBox();
            this.LbTypeInjuryAndSymptoms = new System.Windows.Forms.Label();
            this.LbTypeAccident = new System.Windows.Forms.Label();
            this.LbNameSchool = new System.Windows.Forms.Label();
            this.LbNameFatherOrLegalGuardian = new System.Windows.Forms.Label();
            this.LbNameSurnameInjured = new System.Windows.Forms.Label();
            this.txtTypeInjuryAndSymptoms = new System.Windows.Forms.TextBox();
            this.txtTypeAccident = new System.Windows.Forms.TextBox();
            this.txtNameSchool = new System.Windows.Forms.TextBox();
            this.txtNameSurnameInjured = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.GroupItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // LbSportEventID
            // 
            this.LbSportEventID.AutoSize = true;
            this.LbSportEventID.Location = new System.Drawing.Point(804, 54);
            this.LbSportEventID.Name = "LbSportEventID";
            this.LbSportEventID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbSportEventID.Size = new System.Drawing.Size(49, 13);
            this.LbSportEventID.TabIndex = 10;
            this.LbSportEventID.Text = "شناسه :";
            // 
            // txtSportEventID
            // 
            this.txtSportEventID.Enabled = false;
            this.txtSportEventID.Location = new System.Drawing.Point(655, 74);
            this.txtSportEventID.MaxLength = 50;
            this.txtSportEventID.Name = "txtSportEventID";
            this.txtSportEventID.Size = new System.Drawing.Size(200, 21);
            this.txtSportEventID.TabIndex = 9;
            this.txtSportEventID.Text = "0";
            this.txtSportEventID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnNew
            // 
            this.BtnNew.Image = global::SportHighSchool.Properties.Resources.New;
            this.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNew.Location = new System.Drawing.Point(320, 20);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(100, 50);
            this.BtnNew.TabIndex = 8;
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
            this.BtnDelete.TabIndex = 6;
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
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "بستن";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GroupItem
            // 
            this.GroupItem.Controls.Add(this.txtNameFatherOrLegalGuardian);
            this.GroupItem.Controls.Add(this.LbTypeInjuryAndSymptoms);
            this.GroupItem.Controls.Add(this.LbTypeAccident);
            this.GroupItem.Controls.Add(this.LbNameSchool);
            this.GroupItem.Controls.Add(this.LbNameFatherOrLegalGuardian);
            this.GroupItem.Controls.Add(this.LbNameSurnameInjured);
            this.GroupItem.Controls.Add(this.txtTypeInjuryAndSymptoms);
            this.GroupItem.Controls.Add(this.txtTypeAccident);
            this.GroupItem.Controls.Add(this.txtNameSchool);
            this.GroupItem.Controls.Add(this.txtNameSurnameInjured);
            this.GroupItem.Controls.Add(this.LbSportEventID);
            this.GroupItem.Controls.Add(this.txtSportEventID);
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
            // txtNameFatherOrLegalGuardian
            // 
            this.txtNameFatherOrLegalGuardian.Location = new System.Drawing.Point(440, 125);
            this.txtNameFatherOrLegalGuardian.MaxLength = 50;
            this.txtNameFatherOrLegalGuardian.Name = "txtNameFatherOrLegalGuardian";
            this.txtNameFatherOrLegalGuardian.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNameFatherOrLegalGuardian.Size = new System.Drawing.Size(200, 21);
            this.txtNameFatherOrLegalGuardian.TabIndex = 1;
            this.txtNameFatherOrLegalGuardian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LbTypeInjuryAndSymptoms
            // 
            this.LbTypeInjuryAndSymptoms.AutoSize = true;
            this.LbTypeInjuryAndSymptoms.Location = new System.Drawing.Point(721, 165);
            this.LbTypeInjuryAndSymptoms.Name = "LbTypeInjuryAndSymptoms";
            this.LbTypeInjuryAndSymptoms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbTypeInjuryAndSymptoms.Size = new System.Drawing.Size(130, 13);
            this.LbTypeInjuryAndSymptoms.TabIndex = 15;
            this.LbTypeInjuryAndSymptoms.Text = "نوع آسیب دیدگی و علائم :";
            // 
            // LbTypeAccident
            // 
            this.LbTypeAccident.AutoSize = true;
            this.LbTypeAccident.Location = new System.Drawing.Point(125, 106);
            this.LbTypeAccident.Name = "LbTypeAccident";
            this.LbTypeAccident.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbTypeAccident.Size = new System.Drawing.Size(81, 13);
            this.LbTypeAccident.TabIndex = 14;
            this.LbTypeAccident.Text = "نوع وقوع حادثه :";
            // 
            // LbNameSchool
            // 
            this.LbNameSchool.AutoSize = true;
            this.LbNameSchool.Location = new System.Drawing.Point(348, 105);
            this.LbNameSchool.Name = "LbNameSchool";
            this.LbNameSchool.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbNameSchool.Size = new System.Drawing.Size(73, 13);
            this.LbNameSchool.TabIndex = 13;
            this.LbNameSchool.Text = "نام آموزشگاه :";
            // 
            // LbNameFatherOrLegalGuardian
            // 
            this.LbNameFatherOrLegalGuardian.AutoSize = true;
            this.LbNameFatherOrLegalGuardian.Location = new System.Drawing.Point(532, 105);
            this.LbNameFatherOrLegalGuardian.Name = "LbNameFatherOrLegalGuardian";
            this.LbNameFatherOrLegalGuardian.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbNameFatherOrLegalGuardian.Size = new System.Drawing.Size(105, 13);
            this.LbNameFatherOrLegalGuardian.TabIndex = 12;
            this.LbNameFatherOrLegalGuardian.Text = "نام پدر یا قیم قانونی :";
            // 
            // LbNameSurnameInjured
            // 
            this.LbNameSurnameInjured.AutoSize = true;
            this.LbNameSurnameInjured.Location = new System.Drawing.Point(720, 105);
            this.LbNameSurnameInjured.Name = "LbNameSurnameInjured";
            this.LbNameSurnameInjured.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbNameSurnameInjured.Size = new System.Drawing.Size(132, 13);
            this.LbNameSurnameInjured.TabIndex = 11;
            this.LbNameSurnameInjured.Text = "نام و نام خانوادگی مصدوم :";
            // 
            // txtTypeInjuryAndSymptoms
            // 
            this.txtTypeInjuryAndSymptoms.Location = new System.Drawing.Point(655, 185);
            this.txtTypeInjuryAndSymptoms.MaxLength = 50;
            this.txtTypeInjuryAndSymptoms.Name = "txtTypeInjuryAndSymptoms";
            this.txtTypeInjuryAndSymptoms.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTypeInjuryAndSymptoms.Size = new System.Drawing.Size(200, 21);
            this.txtTypeInjuryAndSymptoms.TabIndex = 4;
            this.txtTypeInjuryAndSymptoms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTypeAccident
            // 
            this.txtTypeAccident.Location = new System.Drawing.Point(10, 125);
            this.txtTypeAccident.MaxLength = 50;
            this.txtTypeAccident.Name = "txtTypeAccident";
            this.txtTypeAccident.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTypeAccident.Size = new System.Drawing.Size(200, 21);
            this.txtTypeAccident.TabIndex = 3;
            this.txtTypeAccident.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNameSchool
            // 
            this.txtNameSchool.Location = new System.Drawing.Point(225, 125);
            this.txtNameSchool.MaxLength = 50;
            this.txtNameSchool.Name = "txtNameSchool";
            this.txtNameSchool.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNameSchool.Size = new System.Drawing.Size(200, 21);
            this.txtNameSchool.TabIndex = 2;
            this.txtNameSchool.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNameSurnameInjured
            // 
            this.txtNameSurnameInjured.Location = new System.Drawing.Point(655, 125);
            this.txtNameSurnameInjured.MaxLength = 50;
            this.txtNameSurnameInjured.Name = "txtNameSurnameInjured";
            this.txtNameSurnameInjured.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNameSurnameInjured.Size = new System.Drawing.Size(200, 21);
            this.txtNameSurnameInjured.TabIndex = 0;
            this.txtNameSurnameInjured.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txtSearch.Size = new System.Drawing.Size(200, 21);
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
            // FrmSportEvents
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
            this.Name = "FrmSportEvents";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حوادث ورزشی";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmSportEvents_Load);
            this.GroupItem.ResumeLayout(false);
            this.GroupItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbSportEventID;
        private System.Windows.Forms.TextBox txtSportEventID;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox GroupItem;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.Label LbTypeInjuryAndSymptoms;
        private System.Windows.Forms.Label LbTypeAccident;
        private System.Windows.Forms.Label LbNameSchool;
        private System.Windows.Forms.Label LbNameFatherOrLegalGuardian;
        private System.Windows.Forms.Label LbNameSurnameInjured;
        private System.Windows.Forms.TextBox txtTypeInjuryAndSymptoms;
        private System.Windows.Forms.TextBox txtTypeAccident;
        private System.Windows.Forms.TextBox txtNameSchool;
        private System.Windows.Forms.TextBox txtNameSurnameInjured;
        private System.Windows.Forms.TextBox txtNameFatherOrLegalGuardian;
    }
}