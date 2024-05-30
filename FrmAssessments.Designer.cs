namespace SportHighSchool
{
    partial class FrmAssessments
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
            this.LbAssessmentID = new System.Windows.Forms.Label();
            this.txtAssessmentID = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GroupItem = new System.Windows.Forms.GroupBox();
            this.LbConceptsSkillPhysicalFitness = new System.Windows.Forms.Label();
            this.txtConceptsSkillPhysicalFitness = new System.Windows.Forms.TextBox();
            this.LbLifeTopics = new System.Windows.Forms.Label();
            this.txtLifeTopics = new System.Windows.Forms.TextBox();
            this.LbAttitudinalField = new System.Windows.Forms.Label();
            this.txtAttitudinalField = new System.Windows.Forms.TextBox();
            this.LbGroupEvaluationScore = new System.Windows.Forms.Label();
            this.txtGroupEvaluationScore = new System.Windows.Forms.TextBox();
            this.LbHealthStatus = new System.Windows.Forms.Label();
            this.txtHealthStatus = new System.Windows.Forms.TextBox();
            this.ComStudentID = new System.Windows.Forms.ComboBox();
            this.LbStudentID = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.GroupItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // LbAssessmentID
            // 
            this.LbAssessmentID.AutoSize = true;
            this.LbAssessmentID.Location = new System.Drawing.Point(804, 54);
            this.LbAssessmentID.Name = "LbAssessmentID";
            this.LbAssessmentID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbAssessmentID.Size = new System.Drawing.Size(49, 13);
            this.LbAssessmentID.TabIndex = 10;
            this.LbAssessmentID.Text = "شناسه :";
            // 
            // txtAssessmentID
            // 
            this.txtAssessmentID.Enabled = false;
            this.txtAssessmentID.Location = new System.Drawing.Point(655, 74);
            this.txtAssessmentID.MaxLength = 50;
            this.txtAssessmentID.Name = "txtAssessmentID";
            this.txtAssessmentID.Size = new System.Drawing.Size(200, 21);
            this.txtAssessmentID.TabIndex = 11;
            this.txtAssessmentID.Text = "0";
            this.txtAssessmentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BtnExit.TabIndex = 9;
            this.BtnExit.Text = "بستن";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GroupItem
            // 
            this.GroupItem.Controls.Add(this.LbConceptsSkillPhysicalFitness);
            this.GroupItem.Controls.Add(this.txtConceptsSkillPhysicalFitness);
            this.GroupItem.Controls.Add(this.LbLifeTopics);
            this.GroupItem.Controls.Add(this.txtLifeTopics);
            this.GroupItem.Controls.Add(this.LbAttitudinalField);
            this.GroupItem.Controls.Add(this.txtAttitudinalField);
            this.GroupItem.Controls.Add(this.LbGroupEvaluationScore);
            this.GroupItem.Controls.Add(this.txtGroupEvaluationScore);
            this.GroupItem.Controls.Add(this.LbHealthStatus);
            this.GroupItem.Controls.Add(this.txtHealthStatus);
            this.GroupItem.Controls.Add(this.ComStudentID);
            this.GroupItem.Controls.Add(this.LbStudentID);
            this.GroupItem.Controls.Add(this.LbAssessmentID);
            this.GroupItem.Controls.Add(this.txtAssessmentID);
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
            // LbConceptsSkillPhysicalFitness
            // 
            this.LbConceptsSkillPhysicalFitness.AutoSize = true;
            this.LbConceptsSkillPhysicalFitness.Location = new System.Drawing.Point(460, 157);
            this.LbConceptsSkillPhysicalFitness.Name = "LbConceptsSkillPhysicalFitness";
            this.LbConceptsSkillPhysicalFitness.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbConceptsSkillPhysicalFitness.Size = new System.Drawing.Size(175, 13);
            this.LbConceptsSkillPhysicalFitness.TabIndex = 17;
            this.LbConceptsSkillPhysicalFitness.Text = "مفاهیم مهارتی و آمادگی جسمانی :";
            // 
            // txtConceptsSkillPhysicalFitness
            // 
            this.txtConceptsSkillPhysicalFitness.Location = new System.Drawing.Point(437, 175);
            this.txtConceptsSkillPhysicalFitness.MaxLength = 50;
            this.txtConceptsSkillPhysicalFitness.Name = "txtConceptsSkillPhysicalFitness";
            this.txtConceptsSkillPhysicalFitness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtConceptsSkillPhysicalFitness.Size = new System.Drawing.Size(200, 21);
            this.txtConceptsSkillPhysicalFitness.TabIndex = 5;
            this.txtConceptsSkillPhysicalFitness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LbLifeTopics
            // 
            this.LbLifeTopics.AutoSize = true;
            this.LbLifeTopics.Location = new System.Drawing.Point(762, 157);
            this.LbLifeTopics.Name = "LbLifeTopics";
            this.LbLifeTopics.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbLifeTopics.Size = new System.Drawing.Size(90, 13);
            this.LbLifeTopics.TabIndex = 16;
            this.LbLifeTopics.Text = "موضوعات زندگی :";
            // 
            // txtLifeTopics
            // 
            this.txtLifeTopics.Location = new System.Drawing.Point(655, 175);
            this.txtLifeTopics.MaxLength = 50;
            this.txtLifeTopics.Name = "txtLifeTopics";
            this.txtLifeTopics.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLifeTopics.Size = new System.Drawing.Size(200, 21);
            this.txtLifeTopics.TabIndex = 4;
            this.txtLifeTopics.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LbAttitudinalField
            // 
            this.LbAttitudinalField.AutoSize = true;
            this.LbAttitudinalField.Location = new System.Drawing.Point(133, 105);
            this.LbAttitudinalField.Name = "LbAttitudinalField";
            this.LbAttitudinalField.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbAttitudinalField.Size = new System.Drawing.Size(78, 13);
            this.LbAttitudinalField.TabIndex = 15;
            this.LbAttitudinalField.Text = "حیطه نگرشی :";
            // 
            // txtAttitudinalField
            // 
            this.txtAttitudinalField.Location = new System.Drawing.Point(11, 125);
            this.txtAttitudinalField.MaxLength = 50;
            this.txtAttitudinalField.Name = "txtAttitudinalField";
            this.txtAttitudinalField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAttitudinalField.Size = new System.Drawing.Size(200, 21);
            this.txtAttitudinalField.TabIndex = 3;
            this.txtAttitudinalField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LbGroupEvaluationScore
            // 
            this.LbGroupEvaluationScore.AutoSize = true;
            this.LbGroupEvaluationScore.Location = new System.Drawing.Point(303, 105);
            this.LbGroupEvaluationScore.Name = "LbGroupEvaluationScore";
            this.LbGroupEvaluationScore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbGroupEvaluationScore.Size = new System.Drawing.Size(117, 13);
            this.LbGroupEvaluationScore.TabIndex = 14;
            this.LbGroupEvaluationScore.Text = "نمره ارزشیابی گروهی :";
            // 
            // txtGroupEvaluationScore
            // 
            this.txtGroupEvaluationScore.Location = new System.Drawing.Point(222, 125);
            this.txtGroupEvaluationScore.MaxLength = 50;
            this.txtGroupEvaluationScore.Name = "txtGroupEvaluationScore";
            this.txtGroupEvaluationScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGroupEvaluationScore.Size = new System.Drawing.Size(200, 21);
            this.txtGroupEvaluationScore.TabIndex = 2;
            this.txtGroupEvaluationScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LbHealthStatus
            // 
            this.LbHealthStatus.AutoSize = true;
            this.LbHealthStatus.Location = new System.Drawing.Point(548, 105);
            this.LbHealthStatus.Name = "LbHealthStatus";
            this.LbHealthStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbHealthStatus.Size = new System.Drawing.Size(86, 13);
            this.LbHealthStatus.TabIndex = 13;
            this.LbHealthStatus.Text = "وضعیت سلامت :";
            // 
            // txtHealthStatus
            // 
            this.txtHealthStatus.Location = new System.Drawing.Point(437, 125);
            this.txtHealthStatus.MaxLength = 50;
            this.txtHealthStatus.Name = "txtHealthStatus";
            this.txtHealthStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHealthStatus.Size = new System.Drawing.Size(200, 21);
            this.txtHealthStatus.TabIndex = 1;
            this.txtHealthStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txtSearch.TabIndex = 0;
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
            this.DgvList.TabIndex = 2;
            this.DgvList.DoubleClick += new System.EventHandler(this.DgvList_DoubleClick);
            // 
            // FrmAssessments
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
            this.Name = "FrmAssessments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ارزیابی ها";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAssessments_Load);
            this.GroupItem.ResumeLayout(false);
            this.GroupItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbAssessmentID;
        private System.Windows.Forms.TextBox txtAssessmentID;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox GroupItem;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.Label LbLifeTopics;
        private System.Windows.Forms.TextBox txtLifeTopics;
        private System.Windows.Forms.Label LbAttitudinalField;
        private System.Windows.Forms.TextBox txtAttitudinalField;
        private System.Windows.Forms.Label LbGroupEvaluationScore;
        private System.Windows.Forms.TextBox txtGroupEvaluationScore;
        private System.Windows.Forms.Label LbHealthStatus;
        private System.Windows.Forms.TextBox txtHealthStatus;
        private System.Windows.Forms.ComboBox ComStudentID;
        private System.Windows.Forms.Label LbStudentID;
        private System.Windows.Forms.Label LbConceptsSkillPhysicalFitness;
        private System.Windows.Forms.TextBox txtConceptsSkillPhysicalFitness;
    }
}