namespace Interface
{
    partial class FrmChooseClass
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
        }//51aspx.com下载

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChooseClass));
            this.lblChooseClassName = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.cboClassNameList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblChooseClassName
            // 
            this.lblChooseClassName.Location = new System.Drawing.Point(16, 15);
            this.lblChooseClassName.Name = "lblChooseClassName";
            this.lblChooseClassName.Size = new System.Drawing.Size(80, 23);
            this.lblChooseClassName.TabIndex = 5;
            this.lblChooseClassName.Text = "请选择班级：";
            this.lblChooseClassName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(176, 55);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cboClassNameList
            // 
            this.cboClassNameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClassNameList.Location = new System.Drawing.Point(96, 15);
            this.cboClassNameList.Name = "cboClassNameList";
            this.cboClassNameList.Size = new System.Drawing.Size(160, 20);
            this.cboClassNameList.TabIndex = 0;
            // 
            // FrmChooseClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 97);
            this.Controls.Add(this.lblChooseClassName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cboClassNameList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChooseClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请选择班级";
            this.Load += new System.EventHandler(this.FrmChooseClass_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblChooseClassName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cboClassNameList;
    }
}