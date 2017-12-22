namespace Interface
{
    partial class FrmModifySubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifySubject));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtPeriod = new System.Windows.Forms.MaskedTextBox();
            this.cboSubjectName = new System.Windows.Forms.ComboBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(414, 193);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭(&X)";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(414, 81);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 25);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "清除(&C)";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnModify
            // 
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Location = new System.Drawing.Point(414, 41);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 25);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "修改(&M)";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.txtPeriod);
            this.grpDetails.Controls.Add(this.cboSubjectName);
            this.grpDetails.Controls.Add(this.lblPeriod);
            this.grpDetails.Controls.Add(this.lblRemark);
            this.grpDetails.Controls.Add(this.lblSubjectName);
            this.grpDetails.Controls.Add(this.txtRemark);
            this.grpDetails.Location = new System.Drawing.Point(12, 12);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(389, 210);
            this.grpDetails.TabIndex = 20;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "修改信息：";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(86, 58);
            this.txtPeriod.Mask = "999";
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(85, 21);
            this.txtPeriod.TabIndex = 1;
            // 
            // cboSubjectName
            // 
            this.cboSubjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubjectName.FormattingEnabled = true;
            this.cboSubjectName.Location = new System.Drawing.Point(88, 26);
            this.cboSubjectName.Name = "cboSubjectName";
            this.cboSubjectName.Size = new System.Drawing.Size(287, 20);
            this.cboSubjectName.TabIndex = 0;
            this.cboSubjectName.SelectedIndexChanged += new System.EventHandler(this.cboSubjectName_SelectedIndexChanged);
            // 
            // lblPeriod
            // 
            this.lblPeriod.Location = new System.Drawing.Point(16, 56);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(64, 23);
            this.lblPeriod.TabIndex = 6;
            this.lblPeriod.Text = "学时数：";
            this.lblPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRemark
            // 
            this.lblRemark.Location = new System.Drawing.Point(16, 88);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(65, 23);
            this.lblRemark.TabIndex = 4;
            this.lblRemark.Text = "科目说明：";
            this.lblRemark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.Location = new System.Drawing.Point(16, 24);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(72, 23);
            this.lblSubjectName.TabIndex = 0;
            this.lblSubjectName.Text = "科目名称：";
            this.lblSubjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtRemark.Location = new System.Drawing.Point(87, 94);
            this.txtRemark.MaxLength = 256;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(288, 106);
            this.txtRemark.TabIndex = 2;
            // 
            // FrmModifySubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 237);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.grpDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModifySubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更新科目资料";
            this.Load += new System.EventHandler(this.FrmModifySubject_Load);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.ComboBox cboSubjectName;
        private System.Windows.Forms.MaskedTextBox txtPeriod;
    }
}