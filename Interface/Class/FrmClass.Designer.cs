namespace Interface
{
    partial class FrmClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClass));
            this.tbrClass = new System.Windows.Forms.ToolStrip();
            this.trbAddClass = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.trbModifyClass = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.trbDeleteClass = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.trbFindClass = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbrExportReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.trbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.trbReturnMain = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDirector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntranceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuClass = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmuAddClass = new System.Windows.Forms.ToolStripMenuItem();
            this.cmuModifyClass = new System.Windows.Forms.ToolStripMenuItem();
            this.cmuDeleteClass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmuFindClass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.MyPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.tbrClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.cmuClass.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbrClass
            // 
            this.tbrClass.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trbAddClass,
            this.toolStripSeparator6,
            this.trbModifyClass,
            this.toolStripSeparator7,
            this.trbDeleteClass,
            this.toolStripSeparator1,
            this.trbFindClass,
            this.toolStripSeparator2,
            this.tbrExportReport,
            this.toolStripSeparator9,
            this.trbPrint,
            this.toolStripSeparator3,
            this.trbReturnMain,
            this.toolStripSeparator5});
            this.tbrClass.Location = new System.Drawing.Point(0, 0);
            this.tbrClass.Name = "tbrClass";
            this.tbrClass.Size = new System.Drawing.Size(701, 40);
            this.tbrClass.TabIndex = 0;
            this.tbrClass.Text = "toolStrip1";
            // 
            // trbAddClass
            // 
            this.trbAddClass.Image = ((System.Drawing.Image)(resources.GetObject("trbAddClass.Image")));
            this.trbAddClass.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trbAddClass.Name = "trbAddClass";
            this.trbAddClass.Size = new System.Drawing.Size(67, 37);
            this.trbAddClass.Text = "添加";
            this.trbAddClass.ToolTipText = "添加新班级";
            this.trbAddClass.Click += new System.EventHandler(this.trbAddClass_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 40);
            // 
            // trbModifyClass
            // 
            this.trbModifyClass.Image = ((System.Drawing.Image)(resources.GetObject("trbModifyClass.Image")));
            this.trbModifyClass.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trbModifyClass.Name = "trbModifyClass";
            this.trbModifyClass.Size = new System.Drawing.Size(67, 37);
            this.trbModifyClass.Text = "修改";
            this.trbModifyClass.ToolTipText = "修改当前班级信息";
            this.trbModifyClass.Click += new System.EventHandler(this.trbModifyClass_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 40);
            // 
            // trbDeleteClass
            // 
            this.trbDeleteClass.Image = ((System.Drawing.Image)(resources.GetObject("trbDeleteClass.Image")));
            this.trbDeleteClass.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trbDeleteClass.Name = "trbDeleteClass";
            this.trbDeleteClass.Size = new System.Drawing.Size(73, 37);
            this.trbDeleteClass.Text = "删除  ";
            this.trbDeleteClass.ToolTipText = "删除当前班级";
            this.trbDeleteClass.Click += new System.EventHandler(this.trbDeleteClass_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // trbFindClass
            // 
            this.trbFindClass.Image = ((System.Drawing.Image)(resources.GetObject("trbFindClass.Image")));
            this.trbFindClass.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trbFindClass.Name = "trbFindClass";
            this.trbFindClass.Size = new System.Drawing.Size(67, 37);
            this.trbFindClass.Text = "查询";
            this.trbFindClass.ToolTipText = "查询班级";
            this.trbFindClass.Click += new System.EventHandler(this.trbFindClass_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // tbrExportReport
            // 
            this.tbrExportReport.Image = ((System.Drawing.Image)(resources.GetObject("tbrExportReport.Image")));
            this.tbrExportReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbrExportReport.Name = "tbrExportReport";
            this.tbrExportReport.Size = new System.Drawing.Size(67, 37);
            this.tbrExportReport.Text = "报表";
            this.tbrExportReport.ToolTipText = "生成报表";
            this.tbrExportReport.Click += new System.EventHandler(this.tbrExportReport_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 40);
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
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 40);
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClassName,
            this.colDirector,
            this.colCurrentCount,
            this.colEntranceDate,
            this.colRemark});
            this.dgvDetails.ContextMenuStrip = this.cmuClass;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(0, 40);
            this.dgvDetails.MultiSelect = false;
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowTemplate.Height = 23;
            this.dgvDetails.Size = new System.Drawing.Size(701, 344);
            this.dgvDetails.TabIndex = 1;
            this.dgvDetails.Tag = "0";
            this.dgvDetails.DataSourceChanged += new System.EventHandler(this.dgvDetails_DataSourceChanged);
            // 
            // colClassName
            // 
            this.colClassName.DataPropertyName = "ClassName";
            this.colClassName.Frozen = true;
            this.colClassName.HeaderText = "班级名称";
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            // 
            // colDirector
            // 
            this.colDirector.DataPropertyName = "Director";
            this.colDirector.HeaderText = "班主任";
            this.colDirector.Name = "colDirector";
            this.colDirector.ReadOnly = true;
            this.colDirector.Width = 80;
            // 
            // colCurrentCount
            // 
            this.colCurrentCount.DataPropertyName = "CurrentCount";
            this.colCurrentCount.HeaderText = "学生人数";
            this.colCurrentCount.Name = "colCurrentCount";
            this.colCurrentCount.ReadOnly = true;
            this.colCurrentCount.Width = 80;
            // 
            // colEntranceDate
            // 
            this.colEntranceDate.DataPropertyName = "EntranceDate";
            this.colEntranceDate.HeaderText = "建班日期";
            this.colEntranceDate.Name = "colEntranceDate";
            this.colEntranceDate.ReadOnly = true;
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            this.colRemark.Width = 350;
            // 
            // cmuClass
            // 
            this.cmuClass.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmuAddClass,
            this.cmuModifyClass,
            this.cmuDeleteClass,
            this.toolStripMenuItem1,
            this.cmuFindClass,
            this.toolStripSeparator4,
            this.cmuReport});
            this.cmuClass.Name = "cmuClass";
            this.cmuClass.Size = new System.Drawing.Size(127, 126);
            // 
            // cmuAddClass
            // 
            this.cmuAddClass.Name = "cmuAddClass";
            this.cmuAddClass.Size = new System.Drawing.Size(126, 22);
            this.cmuAddClass.Text = "添加(&A)...";
            this.cmuAddClass.Click += new System.EventHandler(this.cmuAddClass_Click);
            // 
            // cmuModifyClass
            // 
            this.cmuModifyClass.Name = "cmuModifyClass";
            this.cmuModifyClass.Size = new System.Drawing.Size(126, 22);
            this.cmuModifyClass.Text = "修改(&M)...";
            this.cmuModifyClass.Click += new System.EventHandler(this.cmuModifyClass_Click);
            // 
            // cmuDeleteClass
            // 
            this.cmuDeleteClass.Name = "cmuDeleteClass";
            this.cmuDeleteClass.Size = new System.Drawing.Size(126, 22);
            this.cmuDeleteClass.Text = "删除(&D)...";
            this.cmuDeleteClass.Click += new System.EventHandler(this.cmuDeleteClass_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(123, 6);
            // 
            // cmuFindClass
            // 
            this.cmuFindClass.Image = ((System.Drawing.Image)(resources.GetObject("cmuFindClass.Image")));
            this.cmuFindClass.Name = "cmuFindClass";
            this.cmuFindClass.Size = new System.Drawing.Size(126, 22);
            this.cmuFindClass.Text = "查找(&F)...";
            this.cmuFindClass.Click += new System.EventHandler(this.cmuFindClass_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(123, 6);
            // 
            // cmuReport
            // 
            this.cmuReport.Image = ((System.Drawing.Image)(resources.GetObject("cmuReport.Image")));
            this.cmuReport.Name = "cmuReport";
            this.cmuReport.Size = new System.Drawing.Size(126, 22);
            this.cmuReport.Text = "报表(&R)...";
            this.cmuReport.Click += new System.EventHandler(this.tbrExportReport_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(701, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslInfo
            // 
            this.tslInfo.Image = ((System.Drawing.Image)(resources.GetObject("tslInfo.Image")));
            this.tslInfo.Name = "tslInfo";
            this.tslInfo.Size = new System.Drawing.Size(125, 17);
            this.tslInfo.Text = "toolStripStatusLabel1";
            // 
            // MyPrintDocument
            // 
            this.MyPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.MyPrintDocument_PrintPage);
            // 
            // FrmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 406);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.tbrClass);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "班级管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmClass_Load);
            this.tbrClass.ResumeLayout(false);
            this.tbrClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.cmuClass.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tbrClass;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.ContextMenuStrip cmuClass;
        private System.Windows.Forms.ToolStripMenuItem cmuAddClass;
        private System.Windows.Forms.ToolStripMenuItem cmuModifyClass;
        private System.Windows.Forms.ToolStripMenuItem cmuDeleteClass;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmuFindClass;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cmuReport;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslInfo;
        private System.Windows.Forms.ToolStripButton trbAddClass;
        private System.Windows.Forms.ToolStripButton trbModifyClass;
        private System.Windows.Forms.ToolStripButton trbDeleteClass;
        private System.Windows.Forms.ToolStripButton trbFindClass;
        private System.Windows.Forms.ToolStripButton trbReturnMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirector;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntranceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.ToolStripButton tbrExportReport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Drawing.Printing.PrintDocument MyPrintDocument;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton trbPrint;
    }
}