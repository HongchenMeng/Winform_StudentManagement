namespace Interface
{
    partial class FrmViewImage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewImage));
            this.picStudentImage = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picStudentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picStudentImage
            // 
            this.picStudentImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picStudentImage.Location = new System.Drawing.Point(0, 0);
            this.picStudentImage.Name = "picStudentImage";
            this.picStudentImage.Size = new System.Drawing.Size(88, 118);
            this.picStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStudentImage.TabIndex = 1;
            this.picStudentImage.TabStop = false;
            this.toolTip1.SetToolTip(this.picStudentImage, "单击右键关闭");
            this.picStudentImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picStudentImage_MouseDown);
            this.picStudentImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picStudentImage_MouseMove);
            this.picStudentImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picStudentImage_MouseClick);
            this.picStudentImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picStudentImage_MouseUp);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 2000;
            this.toolTip1.AutoPopDelay = 2000000;
            this.toolTip1.InitialDelay = 1;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 1;
            this.toolTip1.ShowAlways = true;
            // 
            // FrmViewImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(88, 118);
            this.ControlBox = false;
            this.Controls.Add(this.picStudentImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmViewImage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.toolTip1.SetToolTip(this, "单击右键关闭");
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picStudentImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picStudentImage;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}