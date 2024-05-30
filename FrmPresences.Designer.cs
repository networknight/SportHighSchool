namespace SportHighSchool
{
    partial class FrmPresences
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
            this.LbPresenceID = new System.Windows.Forms.Label();
            this.txtPresenceID = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GroupItem = new System.Windows.Forms.GroupBox();
            this.LbFeedback = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.LbInputEvaluation = new System.Windows.Forms.Label();
            this.txtInputEvaluation = new System.Windows.Forms.TextBox();
            this.LbInterestOrSportsField = new System.Windows.Forms.Label();
            this.txtInterestOrSportsField = new System.Windows.Forms.TextBox();
            this.LbPhysicalCondition = new System.Windows.Forms.Label();
            this.txtPhysicalCondition = new System.Windows.Forms.TextBox();
            this.LbGroupName = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.ComStudentID = new System.Windows.Forms.ComboBox();
            this.LbStudentID = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.GroupItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // LbPresenceID
            // 
            this.LbPresenceID.AutoSize = true;
            this.LbPresenceID.Location = new System.Drawing.Point(804, 54);
            this.LbPresenceID.Name = "LbPresenceID";
            this.LbPresenceID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbPresenceID.Size = new System.Drawing.Size(49, 13);
            this.LbPresenceID.TabIndex = 11;
            this.LbPresenceID.Text = "شناسه :";
            // 
            // txtPresenceID
            // 
            this.txtPresenceID.Enabled = false;
            this.txtPresenceID.Location = new System.Drawing.Point(655, 74);
            this.txtPresenceID.MaxLength = 50;
            this.txtPresenceID.Name = "txtPresenceID";
            this.txtPresenceID.Size = new System.Drawing.Size(200, 21);
            this.txtPresenceID.TabIndex = 10;
            this.txtPresenceID.Text = "0";
            this.txtPresenceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.GroupItem.Controls.Add(this.LbFeedback);
            this.GroupItem.Controls.Add(this.txtFeedback);
            this.GroupItem.Controls.Add(this.LbInputEvaluation);
            this.GroupItem.Controls.Add(this.txtInputEvaluation);
            this.GroupItem.Controls.Add(this.LbInterestOrSportsField);
            this.GroupItem.Controls.Add(this.txtInterestOrSportsField);
            this.GroupItem.Controls.Add(this.LbPhysicalCondition);
            this.GroupItem.Controls.Add(this.txtPhysicalCondition);
            this.GroupItem.Controls.Add(this.LbGroupName);
            this.GroupItem.Controls.Add(this.txtGroupName);
            this.GroupItem.Controls.Add(this.ComStudentID);
            this.GroupItem.Controls.Add(this.LbStudentID);
            this.GroupItem.Controls.Add(this.LbPresenceID);
            this.GroupItem.Controls.Add(this.txtPresenceID);
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
            // LbFeedback
            // 
            this.LbFeedback.AutoSize = true;
            this.LbFeedback.Location = new System.Drawing.Point(590, 155);
            this.LbFeedback.Name = "LbFeedback";
            this.LbFeedback.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbFeedback.Size = new System.Drawing.Size(45, 13);
            this.LbFeedback.TabIndex = 17;
            this.LbFeedback.Text = "بازخورد :";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(437, 175);
            this.txtFeedback.MaxLength = 50;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(200, 21);
            this.txtFeedback.TabIndex = 5;
            this.txtFeedback.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LbInputEvaluation
            // 
            this.LbInputEvaluation.AutoSize = true;
            this.LbInputEvaluation.Location = new System.Drawing.Point(763, 157);
            this.LbInputEvaluation.Name = "LbInputEvaluation";
            this.LbInputEvaluation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbInputEvaluation.Size = new System.Drawing.Size(89, 13);
            this.LbInputEvaluation.TabIndex = 16;
            this.LbInputEvaluation.Text = "ارزشیابی ورودی :";
            // 
            // txtInputEvaluation
            // 
            this.txtInputEvaluation.Location = new System.Drawing.Point(655, 175);
            this.txtInputEvaluation.MaxLength = 50;
            this.txtInputEvaluation.Name = "txtInputEvaluation";
            this.txtInputEvaluation.Size = new System.Drawing.Size(200, 21);
            this.txtInputEvaluation.TabIndex = 4;
            this.txtInputEvaluation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LbInterestOrSportsField
            // 
            this.LbInterestOrSportsField.AutoSize = true;
            this.LbInterestOrSportsField.Location = new System.Drawing.Point(94, 105);
            this.LbInterestOrSportsField.Name = "LbInterestOrSportsField";
            this.LbInterestOrSportsField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbInterestOrSportsField.Size = new System.Drawing.Size(115, 13);
            this.LbInterestOrSportsField.TabIndex = 15;
            this.LbInterestOrSportsField.Text = "علاقه یا رشته ورزشی :";
            // 
            // txtInterestOrSportsField
            // 
            this.txtInterestOrSportsField.Location = new System.Drawing.Point(11, 125);
            this.txtInterestOrSportsField.MaxLength = 50;
            this.txtInterestOrSportsField.Name = "txtInterestOrSportsField";
            this.txtInterestOrSportsField.Size = new System.Drawing.Size(200, 21);
            this.txtInterestOrSportsField.TabIndex = 3;
            this.txtInterestOrSportsField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LbPhysicalCondition
            // 
            this.LbPhysicalCondition.AutoSize = true;
            this.LbPhysicalCondition.Location = new System.Drawing.Point(325, 105);
            this.LbPhysicalCondition.Name = "LbPhysicalCondition";
            this.LbPhysicalCondition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbPhysicalCondition.Size = new System.Drawing.Size(94, 13);
            this.LbPhysicalCondition.TabIndex = 14;
            this.LbPhysicalCondition.Text = "وضعیت جسمانی :";
            // 
            // txtPhysicalCondition
            // 
            this.txtPhysicalCondition.Location = new System.Drawing.Point(222, 125);
            this.txtPhysicalCondition.MaxLength = 50;
            this.txtPhysicalCondition.Name = "txtPhysicalCondition";
            this.txtPhysicalCondition.Size = new System.Drawing.Size(200, 21);
            this.txtPhysicalCondition.TabIndex = 2;
            this.txtPhysicalCondition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LbGroupName
            // 
            this.LbGroupName.AutoSize = true;
            this.LbGroupName.Location = new System.Drawing.Point(601, 105);
            this.LbGroupName.Name = "LbGroupName";
            this.LbGroupName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbGroupName.Size = new System.Drawing.Size(34, 13);
            this.LbGroupName.TabIndex = 13;
            this.LbGroupName.Text = "گروه :";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(437, 125);
            this.txtGroupName.MaxLength = 50;
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(200, 21);
            this.txtGroupName.TabIndex = 1;
            this.txtGroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ComStudentID
            // 
            this.ComStudentID.DisplayMember = "Name";
            this.ComStudentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComStudentID.FormattingEnabled = true;
            this.ComStudentID.Location = new System.Drawing.Point(655, 125);
            this.ComStudentID.Name = "ComStudentID";
            this.ComStudentID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComStudentID.Size = new System.Drawing.Size(200, 21);
            this.ComStudentID.TabIndex = 0;
            this.ComStudentID.ValueMember = "StudentID";
            // 
            // LbStudentID
            // 
            this.LbStudentID.AutoSize = true;
            this.LbStudentID.Location = new System.Drawing.Point(793, 105);
            this.LbStudentID.Name = "LbStudentID";
            this.LbStudentID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbStudentID.Size = new System.Drawing.Size(60, 13);
            this.LbStudentID.TabIndex = 12;
            this.LbStudentID.Text = "دانش آموز :";
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
            // FrmPresences
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
            this.Name = "FrmPresences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حضور و غیاب";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmPresences_Load);
            this.GroupItem.ResumeLayout(false);
            this.GroupItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbPresenceID;
        private System.Windows.Forms.TextBox txtPresenceID;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox GroupItem;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.ComboBox ComStudentID;
        private System.Windows.Forms.Label LbStudentID;
        private System.Windows.Forms.Label LbInputEvaluation;
        private System.Windows.Forms.TextBox txtInputEvaluation;
        private System.Windows.Forms.Label LbInterestOrSportsField;
        private System.Windows.Forms.TextBox txtInterestOrSportsField;
        private System.Windows.Forms.Label LbPhysicalCondition;
        private System.Windows.Forms.TextBox txtPhysicalCondition;
        private System.Windows.Forms.Label LbGroupName;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label LbFeedback;
        private System.Windows.Forms.TextBox txtFeedback;
    }
}