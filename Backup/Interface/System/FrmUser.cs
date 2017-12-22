using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using BusinessRuler;

namespace Interface
{
    public partial class FrmUser : Form
    {
        private BusinessRuler.DataGridViewPrinter MyDataGridViewPrinter;
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            BusinessRuler.User objUser = new BusinessRuler.User(this.dgvDetails);
            objUser.UpdateDataGrid();
        }

        private void dgvDetails_DataSourceChanged(object sender, EventArgs e)
        {
            this.tsl1.Text = "系统共有用户：" + dgvDetails.Rows.Count.ToString() + "个。";
        }

        private void trbReturnMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool CheckCondition()
        {
            if (dgvDetails.Rows.Count == 0)
            {
                MessageBox.Show("当前无任何数据,操作无法执行!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void trbExportReport_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            FrmExportReport frmExportReport = new FrmExportReport(dgvDetails, "用户信息");
            frmExportReport.ShowDialog();
        }

        private void trbFindUser_Click_1(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            FrmFindUser frmFindUser = new FrmFindUser(dgvDetails);
            frmFindUser.Show();
        }

        private void trbAddUser_Click(object sender, EventArgs e)
        {
            FrmAddUser frmAddUser = new FrmAddUser(this.dgvDetails);
            frmAddUser.ShowDialog();
        }

        private void trbModifyUser_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            FrmModifyUser frmModifyUser = new FrmModifyUser(this.dgvDetails);
            frmModifyUser.ShowDialog(); 
        }

        private void trbDeleteUser_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            BusinessRuler.User objUser = new BusinessRuler.User(this.dgvDetails);
            objUser.Delete();
            objUser.UpdateDataGrid();
        }

        #region printing

        private void MyPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool more = MyDataGridViewPrinter.DrawDataGridView(e.Graphics);
            if (more == true)
            {
                e.HasMorePages = true;
            }
        }

        private bool SetupThePrinting()
        {
            PrintDialog MyPrintDialog = new PrintDialog();
            MyPrintDialog.AllowCurrentPage = false;
            MyPrintDialog.AllowPrintToFile = false;
            MyPrintDialog.AllowSelection = false;
            MyPrintDialog.AllowSomePages = false;
            MyPrintDialog.PrintToFile = false;
            MyPrintDialog.ShowHelp = false;
            MyPrintDialog.ShowNetwork = false;
            if (MyPrintDialog.ShowDialog() != DialogResult.OK)
            {
                return false;
            }
            MyPrintDocument.DocumentName = "用户信息";
            MyPrintDocument.PrinterSettings = MyPrintDialog.PrinterSettings;
            MyPrintDocument.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            MyPrintDocument.DefaultPageSettings.Margins = new Margins(40, 40, 40, 40);

            if (MessageBox.Show("你希望居中打印吗？", "打印居中", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MyDataGridViewPrinter = new DataGridViewPrinter(this.dgvDetails, MyPrintDocument, true, true, "用户信息", new Font("Tahoma", 15, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
            }
            else
            {
                MyDataGridViewPrinter = new DataGridViewPrinter(this.dgvDetails, MyPrintDocument, false, true, "用户信息", new Font("Tahoma", 15, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
            }
            return true;
        }

        private void trbPrintPreview_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            if (SetupThePrinting())
            {
                PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
                MyPrintPreviewDialog.Document = MyPrintDocument;
                MyPrintPreviewDialog.ShowDialog();
            }
        }

        #endregion


    }
}