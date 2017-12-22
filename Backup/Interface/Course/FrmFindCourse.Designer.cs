namespace Interface
{
    partial class FrmFindCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFindCourse));
            this.cboSubjectName = new System.Windows.Forms.ComboBox();
            this.chxUseMatchBySubject = new System.Windows.Forms.CheckBox();
            this.dtpFinishDate1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate1 = new System.Windows.Forms.DateTimePicker();
            this.cboTeacherName = new System.Windows.Forms.ComboBox();
            this.tabFindCourse = new System.Windows.Forms.TabControl();
            this.tabBySubject = new System.Windows.Forms.TabPage();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.tabTeacher = new System.Windows.Forms.TabPage();
            this.chxUserMatchByTeacher = new System.Windows.Forms.CheckBox();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.tabStartDate = new System.Windows.Forms.TabPage();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.tabFinishDate = new System.Windows.Forms.TabPage();
            this.lblFinishDate = new System.Windows.Forms.Label();
            this.dtpFinishDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.tabFindCourse.SuspendLayout();
            this.tabBySubject.SuspendLayout();
            this.tabTeacher.SuspendLayout();
            this.tabStartDate.SuspendLayout();
            this.tabFinishDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSubjectName
            // 
            this.cboSubjectName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cboSubjectName.Location = new System.Drawing.Point(79, 15);
            this.cboSubjectName.Name = "cboSubjectName";
            this.cboSubjectName.Size = new System.Drawing.Size(178, 20);
            this.cboSubjectName.TabIndex = 1;
            // 
            // chxUseMatchBySubject
            // 
            this.chxUseMatchBySubject.Location = new System.Drawing.Point(263, 13);
            this.chxUseMatchBySubject.Name = "chxUseMatchBySubject";
            this.chxUseMatchBySubject.Size = new System.Drawing.Size(76, 24);
            this.chxUseMatchBySubject.TabIndex = 2;
            this.chxUseMatchBySubject.Text = "智能匹配";
            // 
            // dtpFinishDate1
            // 
            this.dtpFinishDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinishDate1.Location = new System.Drawing.Point(217, 15);
            this.dtpFinishDate1.Name = "dtpFinishDate1";
            this.dtpFinishDate1.Size = new System.Drawing.Size(121, 21);
            this.dtpFinishDate1.TabIndex = 5;
            this.dtpFinishDate1.Value = new System.DateTime(2007, 2, 10, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(191, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "至";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpStartDate1
            // 
            this.dtpStartDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate1.Location = new System.Drawing.Point(56, 15);
            this.dtpStartDate1.Name = "dtpStartDate1";
            this.dtpStartDate1.Size = new System.Drawing.Size(125, 21);
            this.dtpStartDate1.TabIndex = 4;
            this.dtpStartDate1.Value = new System.DateTime(2007, 2, 10, 0, 0, 0, 0);
            // 
            // cboTeacherName
            // 
            this.cboTeacherName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cboTeacherName.Location = new System.Drawing.Point(79, 17);
            this.cboTeacherName.Name = "cboTeacherName";
            this.cboTeacherName.Size = new System.Drawing.Size(169, 20);
            this.cboTeacherName.TabIndex = 10;
            // 
            // tabFindCourse
            // 
            this.tabFindCourse.Controls.Add(this.tabBySubject);
            this.tabFindCourse.Controls.Add(this.tabTeacher);
            this.tabFindCourse.Controls.Add(this.tabStartDate);
            this.tabFindCourse.Controls.Add(this.tabFinishDate);
            this.tabFindCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabFindCourse.Location = new System.Drawing.Point(0, 0);
            this.tabFindCourse.Multiline = true;
            this.tabFindCourse.Name = "tabFindCourse";
            this.tabFindCourse.SelectedIndex = 0;
            this.tabFindCourse.Size = new System.Drawing.Size(354, 71);
            this.tabFindCourse.TabIndex = 12;
            this.tabFindCourse.SelectedIndexChanged += new System.EventHandler(this.tabFindCourse_SelectedIndexChanged);
            // 
            // tabBySubject
            // 
            this.tabBySubject.Controls.Add(this.lblSubjectName);
            this.tabBySubject.Controls.Add(this.chxUseMatchBySubject);
            this.tabBySubject.Controls.Add(this.cboSubjectName);
            this.tabBySubject.Location = new System.Drawing.Point(4, 21);
            this.tabBySubject.Name = "tabBySubject";
            this.tabBySubject.Padding = new System.Windows.Forms.Padding(3);
            this.tabBySubject.Size = new System.Drawing.Size(346, 46);
            this.tabBySubject.TabIndex = 0;
            this.tabBySubject.Text = "按科目";
            this.tabBySubject.UseVisualStyleBackColor = true;
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Location = new System.Drawing.Point(8, 19);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(65, 12);
            this.lblSubjectName.TabIndex = 3;
            this.lblSubjectName.Text = "科目名称：";
            // 
            // tabTeacher
            // 
            this.tabTeacher.Controls.Add(this.chxUserMatchByTeacher);
            this.tabTeacher.Controls.Add(this.lblTeacherName);
            this.tabTeacher.Controls.Add(this.cboTeacherName);
            this.tabTeacher.Location = new System.Drawing.Point(4, 21);
            this.tabTeacher.Name = "tabTeacher";
            this.tabTeacher.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeacher.Size = new System.Drawing.Size(346, 46);
            this.tabTeacher.TabIndex = 1;
            this.tabTeacher.Text = "按老师";
            this.tabTeacher.UseVisualStyleBackColor = true;
            // 
            // chxUserMatchByTeacher
            // 
            this.chxUserMatchByTeacher.Location = new System.Drawing.Point(262, 13);
            this.chxUserMatchByTeacher.Name = "chxUserMatchByTeacher";
            this.chxUserMatchByTeacher.Size = new System.Drawing.Size(76, 24);
            this.chxUserMatchByTeacher.TabIndex = 12;
            this.chxUserMatchByTeacher.Text = "智能匹配";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Location = new System.Drawing.Point(10, 21);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(65, 12);
            this.lblTeacherName.TabIndex = 11;
            this.lblTeacherName.Text = "老师名称：";
            // 
            // tabStartDate
            // 
            this.tabStartDate.Controls.Add(this.lblStartDate);
            this.tabStartDate.Controls.Add(this.dtpFinishDate1);
            this.tabStartDate.Controls.Add(this.dtpStartDate1);
            this.tabStartDate.Controls.Add(this.label1);
            this.tabStartDate.Location = new System.Drawing.Point(4, 21);
            this.tabStartDate.Name = "tabStartDate";
            this.tabStartDate.Padding = new System.Windows.Forms.Padding(3);
            this.tabStartDate.Size = new System.Drawing.Size(346, 46);
            this.tabStartDate.TabIndex = 2;
            this.tabStartDate.Text = "按开课日期";
            this.tabStartDate.UseVisualStyleBackColor = true;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(13, 19);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(41, 12);
            this.lblStartDate.TabIndex = 12;
            this.lblStartDate.Text = "日期：";
            // 
            // tabFinishDate
            // 
            this.tabFinishDate.Controls.Add(this.lblFinishDate);
            this.tabFinishDate.Controls.Add(this.dtpFinishDate2);
            this.tabFinishDate.Controls.Add(this.dtpStartDate2);
            this.tabFinishDate.Controls.Add(this.label5);
            this.tabFinishDate.Location = new System.Drawing.Point(4, 21);
            this.tabFinishDate.Name = "tabFinishDate";
            this.tabFinishDate.Padding = new System.Windows.Forms.Padding(3);
            this.tabFinishDate.Size = new System.Drawing.Size(346, 46);
            this.tabFinishDate.TabIndex = 3;
            this.tabFinishDate.Text = "按结课日期";
            this.tabFinishDate.UseVisualStyleBackColor = true;
            // 
            // lblFinishDate
            // 
            this.lblFinishDate.AutoSize = true;
            this.lblFinishDate.Location = new System.Drawing.Point(14, 17);
            this.lblFinishDate.Name = "lblFinishDate";
            this.lblFinishDate.Size = new System.Drawing.Size(41, 12);
            this.lblFinishDate.TabIndex = 16;
            this.lblFinishDate.Text = "日期：";
            // 
            // dtpFinishDate2
            // 
            this.dtpFinishDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinishDate2.Location = new System.Drawing.Point(212, 14);
            this.dtpFinishDate2.Name = "dtpFinishDate2";
            this.dtpFinishDate2.Size = new System.Drawing.Size(126, 21);
            this.dtpFinishDate2.TabIndex = 14;
            this.dtpFinishDate2.Value = new System.DateTime(2007, 2, 10, 0, 0, 0, 0);
            // 
            // dtpStartDate2
            // 
            this.dtpStartDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate2.Location = new System.Drawing.Point(61, 13);
            this.dtpStartDate2.Name = "dtpStartDate2";
            this.dtpStartDate2.Size = new System.Drawing.Size(127, 21);
            this.dtpStartDate2.TabIndex = 13;
            this.dtpStartDate2.Value = new System.DateTime(2007, 2, 10, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(192, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "至";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFind
            // 
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(255, 80);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(95, 23);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "查找下一个(&N)";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // FrmFindCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 113);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tabFindCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFindCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找课程";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmFindCourse_Load);
            this.tabFindCourse.ResumeLayout(false);
            this.tabBySubject.ResumeLayout(false);
            this.tabBySubject.PerformLayout();
            this.tabTeacher.ResumeLayout(false);
            this.tabTeacher.PerformLayout();
            this.tabStartDate.ResumeLayout(false);
            this.tabStartDate.PerformLayout();
            this.tabFinishDate.ResumeLayout(false);
            this.tabFinishDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSubjectName;
        private System.Windows.Forms.CheckBox chxUseMatchBySubject;
        private System.Windows.Forms.DateTimePicker dtpFinishDate1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate1;
        private System.Windows.Forms.ComboBox cboTeacherName;
        private System.Windows.Forms.TabControl tabFindCourse;
        private System.Windows.Forms.TabPage tabBySubject;
        private System.Windows.Forms.TabPage tabTeacher;
        private System.Windows.Forms.TabPage tabStartDate;
        private System.Windows.Forms.TabPage tabFinishDate;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblFinishDate;
        private System.Windows.Forms.DateTimePicker dtpFinishDate2;
        private System.Windows.Forms.DateTimePicker dtpStartDate2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.CheckBox chxUserMatchByTeacher;
    }
}