namespace Interface
{
    partial class FrmFindUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFindUser));
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.chxUseMatch = new System.Windows.Forms.CheckBox();
            this.grpFindUser = new System.Windows.Forms.GroupBox();
            this.grpFindUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Location = new System.Drawing.Point(74, 21);
            this.txtUserName.MaxLength = 20;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(157, 21);
            this.txtUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "用户名：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFind
            // 
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(239, 77);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(95, 25);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "查找下一个(&N)";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // chxUseMatch
            // 
            this.chxUseMatch.AutoSize = true;
            this.chxUseMatch.Location = new System.Drawing.Point(241, 26);
            this.chxUseMatch.Name = "chxUseMatch";
            this.chxUseMatch.Size = new System.Drawing.Size(72, 16);
            this.chxUseMatch.TabIndex = 1;
            this.chxUseMatch.Text = "智能匹配\r\n";
            this.chxUseMatch.UseVisualStyleBackColor = true;
            // 
            // grpFindUser
            // 
            this.grpFindUser.Controls.Add(this.label1);
            this.grpFindUser.Controls.Add(this.chxUseMatch);
            this.grpFindUser.Controls.Add(this.txtUserName);
            this.grpFindUser.Location = new System.Drawing.Point(10, 6);
            this.grpFindUser.Name = "grpFindUser";
            this.grpFindUser.Size = new System.Drawing.Size(324, 61);
            this.grpFindUser.TabIndex = 14;
            this.grpFindUser.TabStop = false;
            this.grpFindUser.Text = "查找资料";
            // 
            // FrmFindUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 110);
            this.Controls.Add(this.grpFindUser);
            this.Controls.Add(this.btnFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFindUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找用户";
            this.TopMost = true;
            this.grpFindUser.ResumeLayout(false);
            this.grpFindUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.CheckBox chxUseMatch;
        private System.Windows.Forms.GroupBox grpFindUser;
    }
}