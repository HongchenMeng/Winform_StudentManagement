namespace Interface
{
    partial class FrmAddScore
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddScore));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.nudScore = new System.Windows.Forms.NumericUpDown();
            this.lblScore = new System.Windows.Forms.Label();
            this.cboCourseNames = new System.Windows.Forms.ComboBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.cboStudentName = new System.Windows.Forms.ComboBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(366, 116);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭(&X)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(366, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "增加(&A)";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.nudScore);
            this.grpDetails.Controls.Add(this.lblScore);
            this.grpDetails.Controls.Add(this.cboCourseNames);
            this.grpDetails.Controls.Add(this.lblCourseName);
            this.grpDetails.Controls.Add(this.cboStudentName);
            this.grpDetails.Controls.Add(this.lblStudentName);
            this.grpDetails.Location = new System.Drawing.Point(12, 12);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(341, 134);
            this.grpDetails.TabIndex = 21;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "详细信息：";
            // 
            // nudScore
            // 
            this.nudScore.Location = new System.Drawing.Point(94, 95);
            this.nudScore.Name = "nudScore";
            this.nudScore.Size = new System.Drawing.Size(98, 21);
            this.nudScore.TabIndex = 2;
            this.nudScore.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(15, 95);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(72, 23);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "分数：";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboCourseNames
            // 
            this.cboCourseNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourseNames.Location = new System.Drawing.Point(95, 61);
            this.cboCourseNames.Name = "cboCourseNames";
            this.cboCourseNames.Size = new System.Drawing.Size(232, 20);
            this.cboCourseNames.TabIndex = 1;
            // 
            // lblCourseName
            // 
            this.lblCourseName.Location = new System.Drawing.Point(15, 59);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(72, 23);
            this.lblCourseName.TabIndex = 7;
            this.lblCourseName.Text = "课程名称：";
            this.lblCourseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboStudentName
            // 
            this.cboStudentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudentName.Location = new System.Drawing.Point(96, 26);
            this.cboStudentName.Name = "cboStudentName";
            this.cboStudentName.Size = new System.Drawing.Size(232, 20);
            this.cboStudentName.TabIndex = 0;
            // 
            // lblStudentName
            // 
            this.lblStudentName.Location = new System.Drawing.Point(16, 24);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(72, 23);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "学生姓名：";
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmAddScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 164);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增学生成绩";
            this.Load += new System.EventHandler(this.FrmAddScore_Load);
            this.grpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.NumericUpDown nudScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ComboBox cboCourseNames;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.ComboBox cboStudentName;
        private System.Windows.Forms.Label lblStudentName;
    }
}