namespace Interface
{
    partial class FrmCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCourse));
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmuModify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.cmuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tbrCourse = new System.Windows.Forms.ToolStrip();
            this.trbAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.trbModify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.trbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.trbFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.trbExportReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.trbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.trbReturnMain = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slb1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slb2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.trbExit = new System.Windows.Forms.ToolStripLabel();
            this.MyPrintDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.cmuMain.SuspendLayout();
            this.tbrCourse.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectName,
            this.Teacher,
            this.BeginDate,
            this.FinishDate,
            this.Remark});
            this.dgvDetails.ContextMenuStrip = this.cmuMain;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(0, 40);
            this.dgvDetails.MultiSelect = false;
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowTemplate.Height = 23;
            this.dgvDetails.Size = new System.Drawing.Size(627, 360);
            this.dgvDetails.TabIndex = 5;
            this.dgvDetails.Tag = "0";
            this.dgvDetails.DataSourceChanged += new System.EventHandler(this.dgvDetails_DataSourceChanged);
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.Frozen = true;
            this.SubjectName.HeaderText = "科目名称";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            this.SubjectName.Width = 250;
            // 
            // Teacher
            // 
            this.Teacher.DataPropertyName = "Teacher";
            this.Teacher.HeaderText = "授课老师";
            this.Teacher.Name = "Teacher";
            this.Teacher.ReadOnly = true;
            // 
            // BeginDate
            // 
            this.BeginDate.DataPropertyName = "BeginDate";
            this.BeginDate.HeaderText = "开课日期";
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.ReadOnly = true;
            this.BeginDate.Width = 150;
            // 
            // FinishDate
            // 
            this.FinishDate.DataPropertyName = "FinishDate";
            this.FinishDate.HeaderText = "结课日期";
            this.FinishDate.Name = "FinishDate";
            this.FinishDate.ReadOnly = true;
            this.FinishDate.Width = 150;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.Width = 500;
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
            this.cmuMain.Size = new System.Drawing.Size(151, 126);
            // 
            // cmuAdd
            // 
            this.cmuAdd.Name = "cmuAdd";
            this.cmuAdd.Size = new System.Drawing.Size(150, 22);
            this.cmuAdd.Text = "添加(&A)...        ";
            this.cmuAdd.Click += new System.EventHandler(this.trbAdd_Click);
            // 
            // cmuModify
            // 
            this.cmuModify.Name = "cmuModify";
            this.cmuModify.Size = new System.Drawing.Size(150, 22);
            this.cmuModify.Text = "修改(&M)...        ";
            this.cmuModify.Click += new System.EventHandler(this.trbModify_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 6);
            // 
            // cmuDelete
            // 
            this.cmuDelete.Name = "cmuDelete";
            this.cmuDelete.Size = new System.Drawing.Size(150, 22);
            this.cmuDelete.Text = "删除(&D)...        ";
            this.cmuDelete.Click += new System.EventHandler(this.trbDelete_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(147, 6);
            // 
            // cmuFind
            // 
            this.cmuFind.Image = ((System.Drawing.Image)(resources.GetObject("cmuFind.Image")));
            this.cmuFind.Name = "cmuFind";
            this.cmuFind.Size = new System.Drawing.Size(150, 22);
            this.cmuFind.Text = "查找(&F)...        ";
            this.cmuFind.Click += new System.EventHandler(this.trbFind_Click);
            // 
            // cmuReport
            // 
            this.cmuReport.Image = ((System.Drawing.Image)(resources.GetObject("cmuReport.Image")));
            this.cmuReport.Name = "cmuReport";
            this.cmuReport.Size = new System.Drawing.Size(150, 22);
            this.cmuReport.Text = "报表(&R)...        ";
            this.cmuReport.Click += new System.EventHandler(this.trbExportReport_Click);
            // 
            // tbrCourse
            // 
            this.tbrCourse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trbAdd,
            this.toolStripSeparator5,
            this.trbModify,
            this.toolStripSeparator6,
            this.trbDelete,
            this.toolStripSeparator1,
            this.trbFind,
            this.toolStripSeparator2,
            this.trbExportReport,
            this.toolStripSeparator7,
            this.trbPrint,
            this.toolStripSeparator3,
            this.trbReturnMain,
            this.toolStripSeparator4});
            this.tbrCourse.Location = new System.Drawing.Point(0, 0);
            this.tbrCourse.Name = "tbrCourse";
            this.tbrCourse.Size = new System.Drawing.Size(627, 40);
            this.tbrCourse.TabIndex = 4;
            this.tbrCourse.Text = "toolStrip1";
            // 
            // trbAdd
            // 
            this.trbAdd.Image = ((System.Drawing.Image)(resources.GetObject("trbAdd.Image")));
            this.trbAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trbAdd.Name = "trbAdd";
            this.trbAdd.Size = new System.Drawing.Size(67, 37);
            this.trbAdd.Text = "添加";
            this.trbAdd.ToolTipText = "开新课";
            this.trbAdd.Click += new System.EventHandler(this.trbAdd_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 40);
            // 
            // trbModify
            // 
            this.trbModify.Image = ((System.Drawing.Image)(resources.GetObject("trbModify.Image")));
            this.trbModify.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trbModify.Name = "trbModify";
            this.trbModify.Size = new System.Drawing.Size(67, 37);
            this.trbModify.Text = "修改";
            this.trbModify.ToolTipText = "修改当前课程信息";
            this.trbModify.Click += new System.EventHandler(this.trbModify_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 40);
            // 
            // trbDelete
            // 
            this.trbDelete.Image = ((System.Drawing.Image)(resources.GetObject("trbDelete.Image")));
            this.trbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trbDelete.Name = "trbDelete";
            this.trbDelete.Size = new System.Drawing.Size(67, 37);
            this.trbDelete.Text = "删除";
            this.trbDelete.ToolTipText = "删除当前课程";
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
            this.trbFind.ToolTipText = "查询课程";
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
            this.trbExportReport.ToolTipText = "生成报表";
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 40);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slb1,
            this.slb2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(627, 25);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slb1
            // 
            this.slb1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.slb1.Image = ((System.Drawing.Image)(resources.GetObject("slb1.Image")));
            this.slb1.Name = "slb1";
            this.slb1.Size = new System.Drawing.Size(129, 20);
            this.slb1.Text = "toolStripStatusLabel1";
            // 
            // slb2
            // 
            this.slb2.Name = "slb2";
            this.slb2.Size = new System.Drawing.Size(61, 20);
            this.slb2.Text = "222222222";
            // 
            // trbExit
            // 
            this.trbExit.Name = "trbExit";
            this.trbExit.Size = new System.Drawing.Size(37, 28);
            this.trbExit.Text = "关闭  ";
            this.trbExit.ToolTipText = "关闭当前窗体";
            // 
            // MyPrintDocument
            // 
            this.MyPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.MyPrintDocument_PrintPage);
            // 
            // FrmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 425);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.tbrCourse);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.cmuMain.ResumeLayout(false);
            this.tbrCourse.ResumeLayout(false);
            this.tbrCourse.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.ToolStrip tbrCourse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.ContextMenuStrip cmuMain;
        private System.Windows.Forms.ToolStripMenuItem cmuAdd;
        private System.Windows.Forms.ToolStripMenuItem cmuModify;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmuDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cmuFind;
        private System.Windows.Forms.ToolStripMenuItem cmuReport;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slb1;
        private System.Windows.Forms.ToolStripStatusLabel slb2;
        private System.Windows.Forms.ToolStripButton trbAdd;
        private System.Windows.Forms.ToolStripButton trbModify;
        private System.Windows.Forms.ToolStripButton trbDelete;
        private System.Windows.Forms.ToolStripButton trbFind;
        private System.Windows.Forms.ToolStripButton trbExportReport;
        private System.Windows.Forms.ToolStripLabel trbExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton trbReturnMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton trbPrint;
        private System.Drawing.Printing.PrintDocument MyPrintDocument;
    }
}