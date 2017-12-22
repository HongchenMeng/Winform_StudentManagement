namespace Interface
{
    partial class FrmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.trbAddUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.trbModifyUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.trbDeleteUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.trbFindUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.trbExportReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.trbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.trbReturnMain = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.cmuUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmuAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmuModifyUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmuDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmuFindUser = new System.Windows.Forms.ToolStripMenuItem();
            this.报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsInfo = new System.Windows.Forms.StatusStrip();
            this.tsl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MyPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.cmuUser.SuspendLayout();
            this.stsInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trbAddUser,
            this.toolStripSeparator1,
            this.trbModifyUser,
            this.toolStripSeparator2,
            this.trbDeleteUser,
            this.toolStripSeparator3,
            this.trbFindUser,
            this.toolStripSeparator4,
            this.trbExportReport,
            this.toolStripSeparator7,
            this.trbPrint,
            this.toolStripSeparator5,
            this.trbReturnMain,
            this.toolStripSeparator6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(579, 40);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // trbAddUser
            // 
            this.trbAddUser.Image = ((System.Drawing.Image)(resources.GetObject("trbAddUser.Image")));
            this.trbAddUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trbAddUser.Name = "trbAddUser";
            this.trbAddUser.Size = new System.Drawing.Size(67, 37);
            this.trbAddUser.Text = "添加";
            this.trbAddUser.Click += new System.EventHandler(this.trbAddUser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // trbModifyUser
            // 
            this.trbModifyUser.Image = ((System.Drawing.Image)(resources.GetObject("trbModifyUser.Image")));
            this.trbModifyUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trbModifyUser.Name = "trbModifyUser";
            this.trbModifyUser.Size = new System.Drawing.Size(67, 37);
            this.trbModifyUser.Text = "权限";
            this.trbModifyUser.Click += new System.EventHandler(this.trbModifyUser_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // trbDeleteUser
            // 
            this.trbDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("trbDeleteUser.Image")));
            this.trbDeleteUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trbDeleteUser.Name = "trbDeleteUser";
            this.trbDeleteUser.Size = new System.Drawing.Size(67, 37);
            this.trbDeleteUser.Text = "删除";
            this.trbDeleteUser.Click += new System.EventHandler(this.trbDeleteUser_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // trbFindUser
            // 
            this.trbFindUser.Image = ((System.Drawing.Image)(resources.GetObject("trbFindUser.Image")));
            this.trbFindUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trbFindUser.Name = "trbFindUser";
            this.trbFindUser.Size = new System.Drawing.Size(67, 37);
            this.trbFindUser.Text = "查找";
            this.trbFindUser.ToolTipText = "查找用户";
            this.trbFindUser.Click += new System.EventHandler(this.trbFindUser_Click_1);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 40);
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
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 40);
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
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.level,
            this.status});
            this.dgvDetails.ContextMenuStrip = this.cmuUser;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(0, 40);
            this.dgvDetails.MultiSelect = false;
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowTemplate.Height = 23;
            this.dgvDetails.Size = new System.Drawing.Size(579, 274);
            this.dgvDetails.TabIndex = 1;
            this.dgvDetails.Tag = "0";
            this.dgvDetails.DataSourceChanged += new System.EventHandler(this.dgvDetails_DataSourceChanged);
            // 
            // cmuUser
            // 
            this.cmuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmuAddUser,
            this.cmuModifyUser,
            this.cmuDeleteUser,
            this.toolStripMenuItem1,
            this.cmuFindUser,
            this.报表ToolStripMenuItem});
            this.cmuUser.Name = "cmuUser";
            this.cmuUser.Size = new System.Drawing.Size(149, 120);
            // 
            // cmuAddUser
            // 
            this.cmuAddUser.Name = "cmuAddUser";
            this.cmuAddUser.Size = new System.Drawing.Size(148, 22);
            this.cmuAddUser.Text = "添加(&A)...";
            this.cmuAddUser.Click += new System.EventHandler(this.trbAddUser_Click);
            // 
            // cmuModifyUser
            // 
            this.cmuModifyUser.Name = "cmuModifyUser";
            this.cmuModifyUser.Size = new System.Drawing.Size(148, 22);
            this.cmuModifyUser.Text = "设定权限(&S)...";
            this.cmuModifyUser.Click += new System.EventHandler(this.trbModifyUser_Click);
            // 
            // cmuDeleteUser
            // 
            this.cmuDeleteUser.Name = "cmuDeleteUser";
            this.cmuDeleteUser.Size = new System.Drawing.Size(148, 22);
            this.cmuDeleteUser.Text = "删除(&D)";
            this.cmuDeleteUser.Click += new System.EventHandler(this.trbDeleteUser_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 6);
            // 
            // cmuFindUser
            // 
            this.cmuFindUser.Image = ((System.Drawing.Image)(resources.GetObject("cmuFindUser.Image")));
            this.cmuFindUser.Name = "cmuFindUser";
            this.cmuFindUser.Size = new System.Drawing.Size(148, 22);
            this.cmuFindUser.Text = "查找(&F)...";
            this.cmuFindUser.Click += new System.EventHandler(this.trbFindUser_Click_1);
            // 
            // 报表ToolStripMenuItem
            // 
            this.报表ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("报表ToolStripMenuItem.Image")));
            this.报表ToolStripMenuItem.Name = "报表ToolStripMenuItem";
            this.报表ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.报表ToolStripMenuItem.Text = "报表(E)...";
            this.报表ToolStripMenuItem.Click += new System.EventHandler(this.trbExportReport_Click);
            // 
            // stsInfo
            // 
            this.stsInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl1});
            this.stsInfo.Location = new System.Drawing.Point(0, 314);
            this.stsInfo.Name = "stsInfo";
            this.stsInfo.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.stsInfo.Size = new System.Drawing.Size(579, 22);
            this.stsInfo.TabIndex = 2;
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
            // userName
            // 
            this.userName.DataPropertyName = "userName";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.userName.DefaultCellStyle = dataGridViewCellStyle1;
            this.userName.HeaderText = "用户名";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.Width = 150;
            // 
            // level
            // 
            this.level.DataPropertyName = "level";
            this.level.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.level.HeaderText = "系统管理员";
            this.level.Name = "level";
            this.level.ReadOnly = true;
            this.level.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.level.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.level.Width = 150;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status.HeaderText = "帐户启用";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.status.Width = 150;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 336);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.stsInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.cmuUser.ResumeLayout(false);
            this.stsInfo.ResumeLayout(false);
            this.stsInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.ContextMenuStrip cmuUser;
        private System.Windows.Forms.ToolStripMenuItem cmuAddUser;
        private System.Windows.Forms.ToolStripMenuItem cmuModifyUser;
        private System.Windows.Forms.ToolStripMenuItem cmuDeleteUser;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmuFindUser;
        private System.Windows.Forms.ToolStripMenuItem 报表ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stsInfo;
        private System.Windows.Forms.ToolStripStatusLabel tsl1;
        private System.Windows.Forms.ToolStripButton trbAddUser;
        private System.Windows.Forms.ToolStripButton trbModifyUser;
        private System.Windows.Forms.ToolStripButton trbDeleteUser;
        private System.Windows.Forms.ToolStripButton trbFindUser;
        private System.Windows.Forms.ToolStripButton trbExportReport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton trbReturnMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton trbPrint;
        private System.Drawing.Printing.PrintDocument MyPrintDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn level;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
    }
}