namespace Interface
{
    partial class FrmFindClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFindClass));
            this.grpFindCourse = new System.Windows.Forms.GroupBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.chxUseMatchByDirector = new System.Windows.Forms.CheckBox();
            this.rdoByDirector = new System.Windows.Forms.RadioButton();
            this.cboClassName = new System.Windows.Forms.ComboBox();
            this.dtpFinishDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.rdoCreateDate = new System.Windows.Forms.RadioButton();
            this.rdoByClassName = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpFindCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFindCourse
            // 
            this.grpFindCourse.Controls.Add(this.txtDirector);
            this.grpFindCourse.Controls.Add(this.chxUseMatchByDirector);
            this.grpFindCourse.Controls.Add(this.rdoByDirector);
            this.grpFindCourse.Controls.Add(this.cboClassName);
            this.grpFindCourse.Controls.Add(this.dtpFinishDate);
            this.grpFindCourse.Controls.Add(this.label1);
            this.grpFindCourse.Controls.Add(this.dtpStartDate);
            this.grpFindCourse.Controls.Add(this.rdoCreateDate);
            this.grpFindCourse.Controls.Add(this.rdoByClassName);
            this.grpFindCourse.Location = new System.Drawing.Point(6, 4);
            this.grpFindCourse.Name = "grpFindCourse";
            this.grpFindCourse.Size = new System.Drawing.Size(325, 165);
            this.grpFindCourse.TabIndex = 11;
            this.grpFindCourse.TabStop = false;
            this.grpFindCourse.Text = "选项";
            // 
            // txtDirector
            // 
            this.txtDirector.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtDirector.Location = new System.Drawing.Point(64, 83);
            this.txtDirector.MaxLength = 20;
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(169, 21);
            this.txtDirector.TabIndex = 9;
            // 
            // chxUseMatchByDirector
            // 
            this.chxUseMatchByDirector.Location = new System.Drawing.Point(239, 81);
            this.chxUseMatchByDirector.Name = "chxUseMatchByDirector";
            this.chxUseMatchByDirector.Size = new System.Drawing.Size(74, 24);
            this.chxUseMatchByDirector.TabIndex = 5;
            this.chxUseMatchByDirector.Text = "智能匹配";
            // 
            // rdoByDirector
            // 
            this.rdoByDirector.Location = new System.Drawing.Point(24, 59);
            this.rdoByDirector.Name = "rdoByDirector";
            this.rdoByDirector.Size = new System.Drawing.Size(104, 24);
            this.rdoByDirector.TabIndex = 3;
            this.rdoByDirector.Text = "按班主任：";
            this.rdoByDirector.CheckedChanged += new System.EventHandler(this.rdoByDirector_CheckedChanged);
            // 
            // cboClassName
            // 
            this.cboClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClassName.Location = new System.Drawing.Point(64, 39);
            this.cboClassName.Name = "cboClassName";
            this.cboClassName.Size = new System.Drawing.Size(249, 20);
            this.cboClassName.TabIndex = 1;
            // 
            // dtpFinishDate
            // 
            this.dtpFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinishDate.Location = new System.Drawing.Point(203, 129);
            this.dtpFinishDate.Name = "dtpFinishDate";
            this.dtpFinishDate.Size = new System.Drawing.Size(110, 21);
            this.dtpFinishDate.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(184, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "至";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(64, 129);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(114, 21);
            this.dtpStartDate.TabIndex = 7;
            // 
            // rdoCreateDate
            // 
            this.rdoCreateDate.Location = new System.Drawing.Point(24, 105);
            this.rdoCreateDate.Name = "rdoCreateDate";
            this.rdoCreateDate.Size = new System.Drawing.Size(104, 24);
            this.rdoCreateDate.TabIndex = 6;
            this.rdoCreateDate.Text = "按建班日期：";
            this.rdoCreateDate.CheckedChanged += new System.EventHandler(this.rdoCreateDate_CheckedChanged);
            // 
            // rdoByClassName
            // 
            this.rdoByClassName.Checked = true;
            this.rdoByClassName.Location = new System.Drawing.Point(24, 15);
            this.rdoByClassName.Name = "rdoByClassName";
            this.rdoByClassName.Size = new System.Drawing.Size(104, 24);
            this.rdoByClassName.TabIndex = 0;
            this.rdoByClassName.TabStop = true;
            this.rdoByClassName.Text = "按班级名：";
            this.rdoByClassName.CheckedChanged += new System.EventHandler(this.rdoBySubjectName_CheckedChanged);
            // 
            // btnFind
            // 
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(347, 58);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(94, 25);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "查找下一个(&F)";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(347, 109);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 25);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "取消(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmFindClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(454, 179);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpFindCourse);
            this.Controls.Add(this.btnFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFindClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找班级";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmFindClass_Load);
            this.grpFindCourse.ResumeLayout(false);
            this.grpFindCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFindCourse;
        private System.Windows.Forms.ComboBox cboClassName;
        private System.Windows.Forms.DateTimePicker dtpFinishDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.RadioButton rdoCreateDate;
        private System.Windows.Forms.RadioButton rdoByClassName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.CheckBox chxUseMatchByDirector;
        private System.Windows.Forms.RadioButton rdoByDirector;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Button btnClose;
    }
}