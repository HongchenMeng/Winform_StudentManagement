namespace Interface
{
    partial class FrmFindTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFindTeacher));
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.txtIdCard = new System.Windows.Forms.MaskedTextBox();
            this.chxUseMatchByIdCard = new System.Windows.Forms.CheckBox();
            this.rdoByCardID = new System.Windows.Forms.RadioButton();
            this.cbxLikeTeacherName = new System.Windows.Forms.CheckBox();
            this.cboTeacherName = new System.Windows.Forms.ComboBox();
            this.rdoTeacherName = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.txtIdCard);
            this.grpOptions.Controls.Add(this.chxUseMatchByIdCard);
            this.grpOptions.Controls.Add(this.rdoByCardID);
            this.grpOptions.Controls.Add(this.cbxLikeTeacherName);
            this.grpOptions.Controls.Add(this.cboTeacherName);
            this.grpOptions.Controls.Add(this.rdoTeacherName);
            this.grpOptions.Location = new System.Drawing.Point(8, 4);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(301, 117);
            this.grpOptions.TabIndex = 12;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "选项：";
            // 
            // txtIdCard
            // 
            this.txtIdCard.Location = new System.Drawing.Point(31, 82);
            this.txtIdCard.Mask = "000000-00000000-000A";
            this.txtIdCard.Name = "txtIdCard";
            this.txtIdCard.Size = new System.Drawing.Size(182, 21);
            this.txtIdCard.TabIndex = 9;
            // 
            // chxUseMatchByIdCard
            // 
            this.chxUseMatchByIdCard.Location = new System.Drawing.Point(219, 82);
            this.chxUseMatchByIdCard.Name = "chxUseMatchByIdCard";
            this.chxUseMatchByIdCard.Size = new System.Drawing.Size(76, 24);
            this.chxUseMatchByIdCard.TabIndex = 8;
            this.chxUseMatchByIdCard.Text = "模糊查找";
            // 
            // rdoByCardID
            // 
            this.rdoByCardID.Location = new System.Drawing.Point(13, 59);
            this.rdoByCardID.Name = "rdoByCardID";
            this.rdoByCardID.Size = new System.Drawing.Size(98, 24);
            this.rdoByCardID.TabIndex = 6;
            this.rdoByCardID.Text = "按身份证号：";
            this.rdoByCardID.CheckedChanged += new System.EventHandler(this.rdoByCardID_CheckedChanged);
            // 
            // cbxLikeTeacherName
            // 
            this.cbxLikeTeacherName.Location = new System.Drawing.Point(219, 38);
            this.cbxLikeTeacherName.Name = "cbxLikeTeacherName";
            this.cbxLikeTeacherName.Size = new System.Drawing.Size(76, 24);
            this.cbxLikeTeacherName.TabIndex = 5;
            this.cbxLikeTeacherName.Text = "模糊查找";
            // 
            // cboTeacherName
            // 
            this.cboTeacherName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cboTeacherName.Location = new System.Drawing.Point(31, 38);
            this.cboTeacherName.Name = "cboTeacherName";
            this.cboTeacherName.Size = new System.Drawing.Size(182, 20);
            this.cboTeacherName.TabIndex = 4;
            // 
            // rdoTeacherName
            // 
            this.rdoTeacherName.Checked = true;
            this.rdoTeacherName.Location = new System.Drawing.Point(13, 13);
            this.rdoTeacherName.Name = "rdoTeacherName";
            this.rdoTeacherName.Size = new System.Drawing.Size(98, 24);
            this.rdoTeacherName.TabIndex = 3;
            this.rdoTeacherName.TabStop = true;
            this.rdoTeacherName.Text = "按教师姓名：";
            this.rdoTeacherName.CheckedChanged += new System.EventHandler(this.rdoTeacherName_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(315, 93);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 25);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭(&E)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFind
            // 
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(315, 34);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(97, 25);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "查找下一个(&N)";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // FrmFindTeacher
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 129);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFindTeacher";
            this.Text = "查找教师";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmFindTeacher_Load);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.ComboBox cboTeacherName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox cbxLikeTeacherName;
        private System.Windows.Forms.RadioButton rdoTeacherName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.CheckBox chxUseMatchByIdCard;
        private System.Windows.Forms.RadioButton rdoByCardID;
        private System.Windows.Forms.MaskedTextBox txtIdCard;
    }
}