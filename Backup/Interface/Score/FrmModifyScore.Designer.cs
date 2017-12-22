namespace Interface
{
    partial class FrmModifyScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifyScore));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.cboCourseName = new System.Windows.Forms.ComboBox();
            this.cboStudentName = new System.Windows.Forms.ComboBox();
            this.nudScore = new System.Windows.Forms.NumericUpDown();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(381, 121);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭(&X)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnModify
            // 
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Location = new System.Drawing.Point(381, 52);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(78, 25);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "修改(&M)";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.cboCourseName);
            this.grpDetails.Controls.Add(this.cboStudentName);
            this.grpDetails.Controls.Add(this.nudScore);
            this.grpDetails.Controls.Add(this.lblScore);
            this.grpDetails.Controls.Add(this.lblCourseName);
            this.grpDetails.Controls.Add(this.lblStudentName);
            this.grpDetails.Location = new System.Drawing.Point(12, 12);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(352, 134);
            this.grpDetails.TabIndex = 21;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "修改信息：";
            // 
            // cboCourseName
            // 
            this.cboCourseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourseName.FormattingEnabled = true;
            this.cboCourseName.Location = new System.Drawing.Point(92, 61);
            this.cboCourseName.Name = "cboCourseName";
            this.cboCourseName.Size = new System.Drawing.Size(243, 20);
            this.cboCourseName.TabIndex = 1;
            this.cboCourseName.SelectedIndexChanged += new System.EventHandler(this.cboCourseName_SelectedIndexChanged);
            // 
            // cboStudentName
            // 
            this.cboStudentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudentName.FormattingEnabled = true;
            this.cboStudentName.Location = new System.Drawing.Point(92, 28);
            this.cboStudentName.Name = "cboStudentName";
            this.cboStudentName.Size = new System.Drawing.Size(243, 20);
            this.cboStudentName.TabIndex = 0;
            // 
            // nudScore
            // 
            this.nudScore.Location = new System.Drawing.Point(94, 96);
            this.nudScore.Name = "nudScore";
            this.nudScore.Size = new System.Drawing.Size(106, 21);
            this.nudScore.TabIndex = 2;
            this.nudScore.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(15, 96);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(59, 23);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "分数：";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourseName
            // 
            this.lblCourseName.Location = new System.Drawing.Point(15, 58);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(71, 23);
            this.lblCourseName.TabIndex = 7;
            this.lblCourseName.Text = "课程名称：";
            this.lblCourseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStudentName
            // 
            this.lblStudentName.Location = new System.Drawing.Point(16, 24);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(70, 23);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "学生姓名：";
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmModifyScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 171);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.grpDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModifyScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更新学生成绩";
            this.Load += new System.EventHandler(this.FrmModifyScore_Load);
            this.grpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.NumericUpDown nudScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.ComboBox cboStudentName;
        private System.Windows.Forms.ComboBox cboCourseName;
    }
}