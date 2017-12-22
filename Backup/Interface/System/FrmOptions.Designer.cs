namespace Interface
{
    partial class FrmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOptions));
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.nupImageCapacity = new System.Windows.Forms.NumericUpDown();
            this.lblImageCapacity = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpClass = new System.Windows.Forms.GroupBox();
            this.nupStudentCapacity = new System.Windows.Forms.NumericUpDown();
            this.lblClassCapacity = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupImageCapacity)).BeginInit();
            this.grpClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStudentCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // grpImage
            // 
            this.grpImage.Controls.Add(this.nupImageCapacity);
            this.grpImage.Controls.Add(this.lblImageCapacity);
            this.grpImage.Location = new System.Drawing.Point(12, 12);
            this.grpImage.Name = "grpImage";
            this.grpImage.Size = new System.Drawing.Size(353, 56);
            this.grpImage.TabIndex = 0;
            this.grpImage.TabStop = false;
            this.grpImage.Text = "相片设置";
            // 
            // nupImageCapacity
            // 
            this.nupImageCapacity.Location = new System.Drawing.Point(164, 20);
            this.nupImageCapacity.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nupImageCapacity.Name = "nupImageCapacity";
            this.nupImageCapacity.Size = new System.Drawing.Size(101, 21);
            this.nupImageCapacity.TabIndex = 3;
            this.nupImageCapacity.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nupImageCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nupImageCapacity_KeyPress);
            // 
            // lblImageCapacity
            // 
            this.lblImageCapacity.AutoSize = true;
            this.lblImageCapacity.Location = new System.Drawing.Point(51, 25);
            this.lblImageCapacity.Name = "lblImageCapacity";
            this.lblImageCapacity.Size = new System.Drawing.Size(107, 12);
            this.lblImageCapacity.TabIndex = 1;
            this.lblImageCapacity.Text = "相片限制大小(K)：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(190, 163);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grpClass
            // 
            this.grpClass.Controls.Add(this.nupStudentCapacity);
            this.grpClass.Controls.Add(this.lblClassCapacity);
            this.grpClass.Location = new System.Drawing.Point(12, 76);
            this.grpClass.Name = "grpClass";
            this.grpClass.Size = new System.Drawing.Size(353, 56);
            this.grpClass.TabIndex = 2;
            this.grpClass.TabStop = false;
            this.grpClass.Text = "班级设置";
            // 
            // nupStudentCapacity
            // 
            this.nupStudentCapacity.Location = new System.Drawing.Point(164, 20);
            this.nupStudentCapacity.Name = "nupStudentCapacity";
            this.nupStudentCapacity.Size = new System.Drawing.Size(101, 21);
            this.nupStudentCapacity.TabIndex = 2;
            this.nupStudentCapacity.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nupStudentCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nupImageCapacity_KeyPress);
            // 
            // lblClassCapacity
            // 
            this.lblClassCapacity.AutoSize = true;
            this.lblClassCapacity.Location = new System.Drawing.Point(51, 24);
            this.lblClassCapacity.Name = "lblClassCapacity";
            this.lblClassCapacity.Size = new System.Drawing.Size(89, 12);
            this.lblClassCapacity.TabIndex = 1;
            this.lblClassCapacity.Text = "班级人数限定：";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(289, 163);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 198);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpClass);
            this.Controls.Add(this.grpImage);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选项";
            this.Load += new System.EventHandler(this.FrmOptions_Load);
            this.grpImage.ResumeLayout(false);
            this.grpImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupImageCapacity)).EndInit();
            this.grpClass.ResumeLayout(false);
            this.grpClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStudentCapacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpImage;
        private System.Windows.Forms.Label lblImageCapacity;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grpClass;
        private System.Windows.Forms.Label lblClassCapacity;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nupImageCapacity;
        private System.Windows.Forms.NumericUpDown nupStudentCapacity;

    }
}