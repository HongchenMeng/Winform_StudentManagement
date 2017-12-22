namespace Interface
{
    partial class FrmFindSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFindSubject));
            this.btnFind = new System.Windows.Forms.Button();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.cboSubjectName = new System.Windows.Forms.ComboBox();
            this.chxUseMatch = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(198, 64);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(91, 23);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "查找下一个(&N)";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Location = new System.Drawing.Point(11, 17);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(65, 12);
            this.lblSubjectName.TabIndex = 2;
            this.lblSubjectName.Text = "科目名称：";
            // 
            // cboSubjectName
            // 
            this.cboSubjectName.FormattingEnabled = true;
            this.cboSubjectName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cboSubjectName.Location = new System.Drawing.Point(82, 17);
            this.cboSubjectName.Name = "cboSubjectName";
            this.cboSubjectName.Size = new System.Drawing.Size(207, 20);
            this.cboSubjectName.TabIndex = 3;
            // 
            // chxUseMatch
            // 
            this.chxUseMatch.AutoSize = true;
            this.chxUseMatch.Location = new System.Drawing.Point(82, 45);
            this.chxUseMatch.Name = "chxUseMatch";
            this.chxUseMatch.Size = new System.Drawing.Size(72, 16);
            this.chxUseMatch.TabIndex = 4;
            this.chxUseMatch.Text = "智能匹配";
            this.chxUseMatch.UseVisualStyleBackColor = true;
            // 
            // FrmFindSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 99);
            this.Controls.Add(this.chxUseMatch);
            this.Controls.Add(this.cboSubjectName);
            this.Controls.Add(this.lblSubjectName);
            this.Controls.Add(this.btnFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFindSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmFindSubject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.ComboBox cboSubjectName;
        private System.Windows.Forms.CheckBox chxUseMatch;
    }
}