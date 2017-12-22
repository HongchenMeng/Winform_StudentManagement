namespace Interface
{
    partial class FrmExportReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExportReport));
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoTxtType = new System.Windows.Forms.RadioButton();
            this.rdoExcelType = new System.Windows.Forms.RadioButton();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(287, 142);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "下一步(&N)";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 1;
            // 
            // rdoTxtType
            // 
            this.rdoTxtType.AutoSize = true;
            this.rdoTxtType.Checked = true;
            this.rdoTxtType.Location = new System.Drawing.Point(34, 24);
            this.rdoTxtType.Name = "rdoTxtType";
            this.rdoTxtType.Size = new System.Drawing.Size(137, 16);
            this.rdoTxtType.TabIndex = 2;
            this.rdoTxtType.TabStop = true;
            this.rdoTxtType.Text = "文本文件格式(*.txt)";
            this.rdoTxtType.UseVisualStyleBackColor = true;
            // 
            // rdoExcelType
            // 
            this.rdoExcelType.AutoSize = true;
            this.rdoExcelType.Location = new System.Drawing.Point(34, 53);
            this.rdoExcelType.Name = "rdoExcelType";
            this.rdoExcelType.Size = new System.Drawing.Size(203, 16);
            this.rdoExcelType.TabIndex = 3;
            this.rdoExcelType.Text = "Microsoft Excel表格格式(*.xls)";
            this.rdoExcelType.UseVisualStyleBackColor = true;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.label2);
            this.grpOptions.Controls.Add(this.rdoTxtType);
            this.grpOptions.Controls.Add(this.rdoExcelType);
            this.grpOptions.Location = new System.Drawing.Point(11, 14);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(370, 107);
            this.grpOptions.TabIndex = 4;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "你希望导出为何种类型？";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "(如果你的电脑上安装有Excel程序)";
            // 
            // FrmExportReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 180);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExportReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "输出报表";
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoTxtType;
        private System.Windows.Forms.RadioButton rdoExcelType;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Label label2;
    }
}