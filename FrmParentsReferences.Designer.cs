namespace SportHighSchool
{
    partial class FrmParentsReferences
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
            this.LbParentsReferenceID = new System.Windows.Forms.Label();
            this.txtParentsReferenceID = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GroupItem = new System.Windows.Forms.GroupBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.LbConsideration = new System.Windows.Forms.Label();
            this.LbClass = new System.Windows.Forms.Label();
            this.LbReferenceDate = new System.Windows.Forms.Label();
            this.LbReason = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.txtConsideration = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtReferenceDate = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.GroupItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // LbParentsReferenceID
            // 
            this.LbParentsReferenceID.AutoSize = true;
            this.LbParentsReferenceID.Location = new System.Drawing.Point(804, 54);
            this.LbParentsReferenceID.Name = "LbParentsReferenceID";
            this.LbParentsReferenceID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbParentsReferenceID.Size = new System.Drawing.Size(49, 13);
            this.LbParentsReferenceID.TabIndex = 10;
            this.LbParentsReferenceID.Text = "شناسه :";
            // 
            // txtParentsReferenceID
            // 
            this.txtParentsReferenceID.Enabled = false;
            this.txtParentsReferenceID.Location = new System.Drawing.Point(655, 74);
            this.txtParentsReferenceID.MaxLength = 50;
            this.txtParentsReferenceID.Name = "txtParentsReferenceID";
            this.txtParentsReferenceID.Size = new System.Drawing.Size(200, 21);
            this.txtParentsReferenceID.TabIndex = 9;
            this.txtParentsReferenceID.Text = "0";
            this.txtParentsReferenceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.GroupItem.Controls.Add(this.txtReason);
            this.GroupItem.Controls.Add(this.LbConsideration);
            this.GroupItem.Controls.Add(this.LbClass);
            this.GroupItem.Controls.Add(this.LbReferenceDate);
            this.GroupItem.Controls.Add(this.LbReason);
            this.GroupItem.Controls.Add(this.LbName);
            this.GroupItem.Controls.Add(this.txtConsideration);
            this.GroupItem.Controls.Add(this.txtClass);
            this.GroupItem.Controls.Add(this.txtReferenceDate);
            this.GroupItem.Controls.Add(this.txtName);
            this.GroupItem.Controls.Add(this.LbParentsReferenceID);
            this.GroupItem.Controls.Add(this.txtParentsReferenceID);
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
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(440, 127);
            this.txtReason.MaxLength = 50;
            this.txtReason.Name = "txtReason";
            this.txtReason.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReason.Size = new System.Drawing.Size(200, 21);
            this.txtReason.TabIndex = 1;
            this.txtReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LbConsideration
            // 
            this.LbConsideration.AutoSize = true;
            this.LbConsideration.Location = new System.Drawing.Point(797, 167);
            this.LbConsideration.Name = "LbConsideration";
            this.LbConsideration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbConsideration.Size = new System.Drawing.Size(55, 13);
            this.LbConsideration.TabIndex = 15;
            this.LbConsideration.Text = "ملاحظات :";
            // 
            // LbClass
            // 
            this.LbClass.AutoSize = true;
            this.LbClass.Location = new System.Drawing.Point(152, 108);
            this.LbClass.Name = "LbClass";
            this.LbClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbClass.Size = new System.Drawing.Size(40, 13);
            this.LbClass.TabIndex = 14;
            this.LbClass.Text = "کلاس :";
            // 
            // LbReferenceDate
            // 
            this.LbReferenceDate.AutoSize = true;
            this.LbReferenceDate.Location = new System.Drawing.Point(387, 107);
            this.LbReferenceDate.Name = "LbReferenceDate";
            this.LbReferenceDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbReferenceDate.Size = new System.Drawing.Size(35, 13);
            this.LbReferenceDate.TabIndex = 13;
            this.LbReferenceDate.Text = "تاریخ :";
            // 
            // LbReason
            // 
            this.LbReason.AutoSize = true;
            this.LbReason.Location = new System.Drawing.Point(565, 107);
            this.LbReason.Name = "LbReason";
            this.LbReason.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbReason.Size = new System.Drawing.Size(71, 13);
            this.LbReason.TabIndex = 12;
            this.LbReason.Text = "علت مراجعه :";
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Location = new System.Drawing.Point(755, 107);
            this.LbName.Name = "LbName";
            this.LbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbName.Size = new System.Drawing.Size(96, 13);
            this.LbName.TabIndex = 11;
            this.LbName.Text = "نام و نام خانوادگی :";
            // 
            // txtConsideration
            // 
            this.txtConsideration.Location = new System.Drawing.Point(440, 187);
            this.txtConsideration.MaxLength = 50;
            this.txtConsideration.Name = "txtConsideration";
            this.txtConsideration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtConsideration.Size = new System.Drawing.Size(415, 21);
            this.txtConsideration.TabIndex = 4;
            this.txtConsideration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(10, 127);
            this.txtClass.MaxLength = 50;
            this.txtClass.Name = "txtClass";
            this.txtClass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClass.Size = new System.Drawing.Size(200, 21);
            this.txtClass.TabIndex = 3;
            this.txtClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtReferenceDate
            // 
            this.txtReferenceDate.Location = new System.Drawing.Point(225, 127);
            this.txtReferenceDate.MaxLength = 50;
            this.txtReferenceDate.Name = "txtReferenceDate";
            this.txtReferenceDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReferenceDate.Size = new System.Drawing.Size(200, 21);
            this.txtReferenceDate.TabIndex = 2;
            this.txtReferenceDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(655, 127);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.Size = new System.Drawing.Size(200, 21);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // FrmParentsReferences
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
            this.Name = "FrmParentsReferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مراجعه والدین";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmParentsReferences_Load);
            this.GroupItem.ResumeLayout(false);
            this.GroupItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbParentsReferenceID;
        private System.Windows.Forms.TextBox txtParentsReferenceID;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox GroupItem;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label LbConsideration;
        private System.Windows.Forms.Label LbClass;
        private System.Windows.Forms.Label LbReferenceDate;
        private System.Windows.Forms.Label LbReason;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.TextBox txtConsideration;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtReferenceDate;
        private System.Windows.Forms.TextBox txtName;
    }
}