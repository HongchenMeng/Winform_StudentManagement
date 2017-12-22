namespace Interface
{
    partial class FrmModifyCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifyCourse));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.grpCourse = new System.Windows.Forms.GroupBox();
            this.cboSubjectName = new System.Windows.Forms.ComboBox();
            this.cboTeacher = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblSujectName = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFinishDate = new System.Windows.Forms.DateTimePicker();
            this.lblFinishDate = new System.Windows.Forms.Label();
            this.grpCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(326, 291);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭(&X)";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(182, 291);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 25);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "清除(&C)";
            // 
            // btnApply
            // 
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Location = new System.Drawing.Point(94, 291);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(89, 25);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "更新(&M)";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // grpCourse
            // 
            this.grpCourse.Controls.Add(this.cboSubjectName);
            this.grpCourse.Controls.Add(this.cboTeacher);
            this.grpCourse.Controls.Add(this.label1);
            this.grpCourse.Controls.Add(this.txtRemark);
            this.grpCourse.Controls.Add(this.lblRemark);
            this.grpCourse.Controls.Add(this.lblSujectName);
            this.grpCourse.Controls.Add(this.lblStartDate);
            this.grpCourse.Controls.Add(this.dtpStartDate);
            this.grpCourse.Controls.Add(this.dtpFinishDate);
            this.grpCourse.Controls.Add(this.lblFinishDate);
            this.grpCourse.Location = new System.Drawing.Point(10, 12);
            this.grpCourse.Name = "grpCourse";
            this.grpCourse.Size = new System.Drawing.Size(423, 267);
            this.grpCourse.TabIndex = 34;
            this.grpCourse.TabStop = false;
            this.grpCourse.Text = "修改信息：";
            // 
            // cboSubjectName
            // 
            this.cboSubjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubjectName.Location = new System.Drawing.Point(96, 23);
            this.cboSubjectName.MaxLength = 50;
            this.cboSubjectName.Name = "cboSubjectName";
            this.cboSubjectName.Size = new System.Drawing.Size(176, 20);
            this.cboSubjectName.TabIndex = 0;
            this.cboSubjectName.SelectedIndexChanged += new System.EventHandler(this.cboSubjectName_SelectedIndexChanged);
            // 
            // cboTeacher
            // 
            this.cboTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeacher.Location = new System.Drawing.Point(96, 56);
            this.cboTeacher.MaxLength = 50;
            this.cboTeacher.Name = "cboTeacher";
            this.cboTeacher.Size = new System.Drawing.Size(176, 20);
            this.cboTeacher.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "授课老师：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtRemark.Location = new System.Drawing.Point(96, 152);
            this.txtRemark.MaxLength = 256;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(312, 97);
            this.txtRemark.TabIndex = 4;
            // 
            // lblRemark
            // 
            this.lblRemark.Location = new System.Drawing.Point(24, 152);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(64, 23);
            this.lblRemark.TabIndex = 4;
            this.lblRemark.Text = "备注：";
            this.lblRemark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSujectName
            // 
            this.lblSujectName.Location = new System.Drawing.Point(24, 22);
            this.lblSujectName.Name = "lblSujectName";
            this.lblSujectName.Size = new System.Drawing.Size(72, 23);
            this.lblSujectName.TabIndex = 7;
            this.lblSujectName.Text = "科目：";
            this.lblSujectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(24, 88);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(72, 23);
            this.lblStartDate.TabIndex = 9;
            this.lblStartDate.Text = "开课日期：";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(96, 88);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(144, 21);
            this.dtpStartDate.TabIndex = 2;
            this.dtpStartDate.Value = new System.DateTime(2007, 2, 9, 0, 0, 0, 0);
            // 
            // dtpFinishDate
            // 
            this.dtpFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinishDate.Location = new System.Drawing.Point(96, 120);
            this.dtpFinishDate.Name = "dtpFinishDate";
            this.dtpFinishDate.Size = new System.Drawing.Size(144, 21);
            this.dtpFinishDate.TabIndex = 3;
            this.dtpFinishDate.Value = new System.DateTime(2007, 2, 9, 0, 0, 0, 0);
            // 
            // lblFinishDate
            // 
            this.lblFinishDate.Location = new System.Drawing.Point(24, 120);
            this.lblFinishDate.Name = "lblFinishDate";
            this.lblFinishDate.Size = new System.Drawing.Size(72, 23);
            this.lblFinishDate.TabIndex = 11;
            this.lblFinishDate.Text = "完课日期：";
            this.lblFinishDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmModifyCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 328);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.grpCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModifyCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更新课程";
            this.Load += new System.EventHandler(this.FrmModifyCourse_Load);
            this.grpCourse.ResumeLayout(false);
            this.grpCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox grpCourse;
        private System.Windows.Forms.ComboBox cboTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblSujectName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpFinishDate;
        private System.Windows.Forms.Label lblFinishDate;
        private System.Windows.Forms.ComboBox cboSubjectName;
    }
}