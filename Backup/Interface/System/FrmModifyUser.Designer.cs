namespace Interface
{
    partial class FrmModifyUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifyUser));
            this.btnClose = new System.Windows.Forms.Button();
            this.grpContent = new System.Windows.Forms.GroupBox();
            this.lblNameContent = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.rdoDisable = new System.Windows.Forms.RadioButton();
            this.rdoEnable = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(298, 93);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭(&E)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpContent
            // 
            this.grpContent.Controls.Add(this.lblNameContent);
            this.grpContent.Controls.Add(this.lblUserName);
            this.grpContent.Controls.Add(this.rdoDisable);
            this.grpContent.Controls.Add(this.rdoEnable);
            this.grpContent.Controls.Add(this.label1);
            this.grpContent.Controls.Add(this.cboType);
            this.grpContent.Controls.Add(this.lblType);
            this.grpContent.Location = new System.Drawing.Point(10, 7);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(264, 122);
            this.grpContent.TabIndex = 10;
            this.grpContent.TabStop = false;
            this.grpContent.Text = "变更内容";
            // 
            // lblNameContent
            // 
            this.lblNameContent.ForeColor = System.Drawing.Color.Red;
            this.lblNameContent.Location = new System.Drawing.Point(96, 24);
            this.lblNameContent.Name = "lblNameContent";
            this.lblNameContent.Size = new System.Drawing.Size(152, 23);
            this.lblNameContent.TabIndex = 11;
            this.lblNameContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(16, 24);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(64, 23);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "用户名：";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoDisable
            // 
            this.rdoDisable.Location = new System.Drawing.Point(192, 88);
            this.rdoDisable.Name = "rdoDisable";
            this.rdoDisable.Size = new System.Drawing.Size(56, 24);
            this.rdoDisable.TabIndex = 2;
            this.rdoDisable.Text = "暂封";
            // 
            // rdoEnable
            // 
            this.rdoEnable.Location = new System.Drawing.Point(96, 88);
            this.rdoEnable.Name = "rdoEnable";
            this.rdoEnable.Size = new System.Drawing.Size(56, 24);
            this.rdoEnable.TabIndex = 1;
            this.rdoEnable.Text = "启用";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "状态设定：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Items.AddRange(new object[] {
            "管理员",
            "用户"});
            this.cboType.Location = new System.Drawing.Point(96, 56);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(152, 20);
            this.cboType.TabIndex = 0;
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(16, 56);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(72, 23);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "用户类型：";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(298, 31);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 145);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpContent);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModifyUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改用户资料";
            this.Load += new System.EventHandler(this.FrmModifyUser_Load);
            this.grpContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpContent;
        private System.Windows.Forms.Label lblNameContent;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.RadioButton rdoDisable;
        private System.Windows.Forms.RadioButton rdoEnable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnOK;
    }
}