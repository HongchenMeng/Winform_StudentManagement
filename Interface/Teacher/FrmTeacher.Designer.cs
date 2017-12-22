namespace Interface
{
    partial class FrmTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTeacher));
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.University = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialfield = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diploma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmuModify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.cmuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tbrTeacher = new System.Windows.Forms.ToolStrip();
            this.trbAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.trbModify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.trbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.trbFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.trbExportReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.trbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.trbReturnMain = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.stsInfo = new System.Windows.Forms.StatusStrip();
            this.tsl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MyPrintDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.cmuMain.SuspendLayout();
            this.tbrTeacher.SuspendLayout();
            this.stsInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherName,
            this.Gender,
            this.Birthday,
            this.IDCard,
            this.University,
            this.Specialfield,
            this.Diploma,
            this.Picture,
            this.Remark});
            this.dgvDetails.ContextMenuStrip = this.cmuMain;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(0, 40);
            this.dgvDetails.MultiSelect = false;
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowTemplate.Height = 23;
            this.dgvDetails.Size = new System.Drawing.Size(676, 342);
            this.dgvDetails.TabIndex = 5;
            this.dgvDetails.Tag = "0";
            this.dgvDetails.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellMouseLeave);
            this.dgvDetails.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellMouseEnter);
            this.dgvDetails.DataSourceChanged += new System.EventHandler(this.dgvDetails_DataSourceChanged);
            this.dgvDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellContentClick);
            // 
            // TeacherName
            // 
            this.TeacherName.DataPropertyName = "TeacherName";
            this.TeacherName.Frozen = true;
            this.TeacherName.HeaderText = "教师姓名";
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 60;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "出生日期";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // IDCard
            // 
            this.IDCard.DataPropertyName = "IDCard";
            this.IDCard.HeaderText = "身份证号码";
            this.IDCard.Name = "IDCard";
            this.IDCard.ReadOnly = true;
            this.IDCard.Width = 150;
            // 
            // University
            // 
            this.University.DataPropertyName = "University";
            this.University.HeaderText = "毕业院校";
            this.University.Name = "University";
            this.University.ReadOnly = true;
            this.University.Width = 180;
            // 
            // Specialfield
            // 
            this.Specialfield.DataPropertyName = "Specialfield";
            this.Specialfield.HeaderText = "专业";
            this.Specialfield.Name = "Specialfield";
            this.Specialfield.ReadOnly = true;
            this.Specialfield.Width = 80;
            // 
            // Diploma
            // 
            this.Diploma.DataPropertyName = "Diploma";
            this.Diploma.HeaderText = "学历";
            this.Diploma.Name = "Diploma";
            this.Diploma.ReadOnly = true;
            this.Diploma.Width = 70;
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "Picture";
            this.Picture.HeaderText = "相片";
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            this.Picture.ToolTipText = "单击单元格查看相片";
            this.Picture.Width = 80;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.Width = 450;
            // 
            // cmuMain
            // 
            this.cmuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmuAdd,
            this.cmuModify,
            this.toolStripMenuItem1,
            this.cmuDelete,
            this.toolStripMenuItem2,
            this.cmuFind,
            this.cmuReport});
            this.cmuMain.Name = "cmuMain";
            this.cmuMain.Size = new System.Drawing.Size(154, 126);
            // 
            // cmuAdd
            // 
            this.cmuAdd.Name = "cmuAdd";
            this.cmuAdd.Size = new System.Drawing.Size(153, 22);
            this.cmuAdd.Text = "添加(&A)...         ";
            this.cmuAdd.Click += new System.EventHandler(this.trbAdd_Click);
            // 
            // cmuModify
            // 
            this.cmuModify.Name = "cmuModify";
            this.cmuModify.Size = new System.Drawing.Size(153, 22);
            this.cmuModify.Text = "修改(&M)...         ";
            this.cmuModify.Click += new System.EventHandler(this.trbModify_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // cmuDelete
            // 
            this.cmuDelete.Name = "cmuDelete";
            this.cmuDelete.Size = new System.Drawing.Size(153, 22);
            this.cmuDelete.Text = "删除(&D)...         ";
            this.cmuDelete.Click += new System.EventHandler(this.trbDelete_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 6);
            // 
            // cmuFind
            // 
            this.cmuFind.Image = ((System.Drawing.Image)(resources.GetObject("cmuFind.Image")));
            this.cmuFind.Name = "cmuFind";
            this.cmuFind.Size = new System.Drawing.Size(153, 22);
            this.cmuFind.Text = "查找(&F)...         ";
            this.cmuFind.Click += new System.EventHandler(this.trbFind_Click);
            // 
            // cmuReport
            // 
            this.cmuReport.Image = ((System.Drawing.Image)(resources.GetObject("cmuReport.Image")));
            this.cmuReport.Name = "cmuReport";
            this.cmuReport.Size = new System.Drawing.Size(153, 22);
            this.cmuReport.Text = "报表(&R)...        ";
            this.cmuReport.Click += new System.EventHandler(this.trbExportReport_Click);
            // 
            // tbrTeacher
            // 
            this.tbrTeacher.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trbAdd,
            this.toolStripSeparator4,
            this.trbModify,
            this.toolStripSeparator5,
            this.trbDelete,
            this.toolStripSeparator1,
            this.trbFind,
            this.toolStripSeparator2,
            this.trbExportReport,
            this.toolStripSeparator7,
            this.trbPrint,
            this.toolStripSeparator3,
            this.trbReturnMain,
            this.toolStripSeparator6});
            this.tbrTeacher.Location = new System.Drawing.Point(0, 0);
            this.tbrTeacher.Name = "tbrTeacher";
            this.tbrTeacher.Size = new System.Drawing.Size(676, 40);
            this.tbrTeacher.TabIndex = 4;
            this.tbrTeacher.Text = "toolStrip1";
            // 
            // trbAdd
            // 
            this.trbAdd.Image = ((System.Drawing.Image)(resources.GetObject("trbAdd.Image")));
            this.trbAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trbAdd.Name = "trbAdd";
            this.trbAdd.Size = new System.Drawing.Size(67, 37);
            this.trbAdd.Text = "添加";
            this.trbAdd.ToolTipText = "添加教师";
            this.trbAdd.Click += new System.EventHandler(this.trbAdd_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 40);
            // 
            // trbModify
            // 
            this.trbModify.Image = ((System.Drawing.Image)(resources.GetObject("trbModify.Image")));
            this.trbModify.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trbModify.Name = "trbModify";
            this.trbModify.Size = new System.Drawing.Size(67, 37);
            this.trbModify.Text = "修改";
            this.trbModify.ToolTipText = "修改教师档案";
            this.trbModify.Click += new System.EventHandler(this.trbModify_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 40);
            // 
            // trbDelete
            // 
            this.trbDelete.Image = ((System.Drawing.Image)(resources.GetObject("trbDelete.Image")));
            this.trbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trbDelete.Name = "trbDelete";
            this.trbDelete.Size = new System.Drawing.Size(67, 37);
            this.trbDelete.Text = "删除";
            this.trbDelete.ToolTipText = "删除教师档案";
            this.trbDelete.Click += new System.EventHandler(this.trbDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // trbFind
            // 
            this.trbFind.Image = ((System.Drawing.Image)(resources.GetObject("trbFind.Image")));
            this.trbFind.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trbFind.Name = "trbFind";
            this.trbFind.Size = new System.Drawing.Size(67, 37);
            this.trbFind.Text = "查询";
            this.trbFind.ToolTipText = "按条件查询教师";
            this.trbFind.Click += new System.EventHandler(this.trbFind_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // trbExportReport
            // 
            this.trbExportReport.Image = ((System.Drawing.Image)(resources.GetObject("trbExportReport.Image")));
            this.trbExportReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trbExportReport.Name = "trbExportReport";
            this.trbExportReport.Size = new System.Drawing.Size(67, 37);
            this.trbExportReport.Text = "报表";
            this.trbExportReport.ToolTipText = "导出内容到Excel";
            this.trbExportReport.Click += new System.EventHandler(this.trbExportReport_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 40);
            // 
            // trbPrint
            // 
            this.trbPrint.Image = ((System.Drawing.Image)(resources.GetObject("trbPrint.Image")));
            this.trbPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trbPrint.Name = "trbPrint";
            this.trbPrint.Size = new System.Drawing.Size(66, 37);
            this.trbPrint.Text = "打印";
            this.trbPrint.ToolTipText = "打印当前内容";
            this.trbPrint.Click += new System.EventHandler(this.trbPrintPreview_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // trbReturnMain
            // 
            this.trbReturnMain.Image = ((System.Drawing.Image)(resources.GetObject("trbReturnMain.Image")));
            this.trbReturnMain.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trbReturnMain.Name = "trbReturnMain";
            this.trbReturnMain.Size = new System.Drawing.Size(66, 37);
            this.trbReturnMain.Text = "返回";
            this.trbReturnMain.ToolTipText = "返回主界面";
            this.trbReturnMain.Click += new System.EventHandler(this.trbReturnMain_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 40);
            // 
            // stsInfo
            // 
            this.stsInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl1});
            this.stsInfo.Location = new System.Drawing.Point(0, 382);
            this.stsInfo.Name = "stsInfo";
            this.stsInfo.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.stsInfo.Size = new System.Drawing.Size(676, 22);
            this.stsInfo.TabIndex = 6;
            this.stsInfo.Text = "statusStrip1";
            // 
            // tsl1
            // 
            this.tsl1.Image = ((System.Drawing.Image)(resources.GetObject("tsl1.Image")));
            this.tsl1.Name = "tsl1";
            this.tsl1.Size = new System.Drawing.Size(125, 17);
            this.tsl1.Text = "toolStripStatusLabel1";
            // 
            // MyPrintDocument
            // 
            this.MyPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.MyPrintDocument_PrintPage);
            // 
            // FrmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 404);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.tbrTeacher);
            this.Controls.Add(this.stsInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.cmuMain.ResumeLayout(false);
            this.tbrTeacher.ResumeLayout(false);
            this.tbrTeacher.PerformLayout();
            this.stsInfo.ResumeLayout(false);
            this.stsInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.ToolStrip tbrTeacher;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ContextMenuStrip cmuMain;
        private System.Windows.Forms.ToolStripMenuItem cmuAdd;
        private System.Windows.Forms.ToolStripMenuItem cmuModify;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmuDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cmuFind;
        private System.Windows.Forms.ToolStripMenuItem cmuReport;
        private System.Windows.Forms.StatusStrip stsInfo;
        private System.Windows.Forms.ToolStripStatusLabel tsl1;
        private System.Windows.Forms.ToolStripButton trbAdd;
        private System.Windows.Forms.ToolStripButton trbModify;
        private System.Windows.Forms.ToolStripButton trbDelete;
        private System.Windows.Forms.ToolStripButton trbFind;
        private System.Windows.Forms.ToolStripButton trbExportReport;
        private System.Windows.Forms.ToolStripButton trbReturnMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn University;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialfield;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diploma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton trbPrint;
        private System.Drawing.Printing.PrintDocument MyPrintDocument;
    }
}