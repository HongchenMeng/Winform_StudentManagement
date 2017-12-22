namespace Interface
{
    partial class FrmFindStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFindStudent));
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chxMatchByStudentNo = new System.Windows.Forms.CheckBox();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.chxMatchByStudentName = new System.Windows.Forms.CheckBox();
            this.rdoStudentNo = new System.Windows.Forms.RadioButton();
            this.rdoStudentName = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chxMatchByStudentNo);
            this.grpOptions.Controls.Add(this.txtStudentNo);
            this.grpOptions.Controls.Add(this.txtStudentName);
            this.grpOptions.Controls.Add(this.chxMatchByStudentName);
            this.grpOptions.Controls.Add(this.rdoStudentNo);
            this.grpOptions.Controls.Add(this.rdoStudentName);
            this.grpOptions.Location = new System.Drawing.Point(8, 3);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(307, 100);
            this.grpOptions.TabIndex = 12;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "查找条件：";
            // 
            // chxMatchByStudentNo
            // 
            this.chxMatchByStudentNo.Location = new System.Drawing.Point(226, 23);
            this.chxMatchByStudentNo.Name = "chxMatchByStudentNo";
            this.chxMatchByStudentNo.Size = new System.Drawing.Size(75, 24);
            this.chxMatchByStudentNo.TabIndex = 5;
            this.chxMatchByStudentNo.Text = "智能匹配";
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(89, 23);
            this.txtStudentNo.MaxLength = 6;
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(127, 21);
            this.txtStudentNo.TabIndex = 1;
            this.txtStudentNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentNo_KeyPress);
            // 
            // txtStudentName
            // 
            this.txtStudentName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtStudentName.Location = new System.Drawing.Point(89, 63);
            this.txtStudentName.MaxLength = 20;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(127, 21);
            this.txtStudentName.TabIndex = 3;
            // 
            // chxMatchByStudentName
            // 
            this.chxMatchByStudentName.Location = new System.Drawing.Point(225, 61);
            this.chxMatchByStudentName.Name = "chxMatchByStudentName";
            this.chxMatchByStudentName.Size = new System.Drawing.Size(75, 24);
            this.chxMatchByStudentName.TabIndex = 4;
            this.chxMatchByStudentName.Text = "智能匹配";
            // 
            // rdoStudentNo
            // 
            this.rdoStudentNo.Checked = true;
            this.rdoStudentNo.Location = new System.Drawing.Point(16, 20);
            this.rdoStudentNo.Name = "rdoStudentNo";
            this.rdoStudentNo.Size = new System.Drawing.Size(77, 24);
            this.rdoStudentNo.TabIndex = 0;
            this.rdoStudentNo.TabStop = true;
            this.rdoStudentNo.Text = "按学号：";
            this.rdoStudentNo.CheckedChanged += new System.EventHandler(this.rdoStudentNo_CheckedChanged);
            // 
            // rdoStudentName
            // 
            this.rdoStudentName.Location = new System.Drawing.Point(16, 60);
            this.rdoStudentName.Name = "rdoStudentName";
            this.rdoStudentName.Size = new System.Drawing.Size(77, 24);
            this.rdoStudentName.TabIndex = 2;
            this.rdoStudentName.Text = "按姓名：";
            this.rdoStudentName.CheckedChanged += new System.EventHandler(this.rdoStudentName_CheckedChanged);
            // 
            // btnFind
            // 
            this.btnFind.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(323, 23);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(97, 25);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "查找下一个(&N)";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(323, 66);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 25);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmFindStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(429, 110);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.btnFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFindStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmFindStudent_Load);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.CheckBox chxMatchByStudentName;
        private System.Windows.Forms.RadioButton rdoStudentNo;
        private System.Windows.Forms.RadioButton rdoStudentName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chxMatchByStudentNo;
    }
}