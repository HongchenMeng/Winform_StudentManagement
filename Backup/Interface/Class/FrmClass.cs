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
    public partial class FrmClass : Form
    {
        private BusinessRuler.DataGridViewPrinter MyDataGridViewPrinter;

        public FrmClass()
        {
            InitializeComponent();
        }

        private void cmuAddClass_Click(object sender, EventArgs e)
        {
            trbAddClass_Click(sender, e);
        }

        private void cmuModifyClass_Click(object sender, EventArgs e)
        {
            trbModifyClass_Click(sender, e);
        }

        private void cmuDeleteClass_Click(object sender, EventArgs e)
        {
            trbDeleteClass_Click(sender, e);
        }

        private void cmuFindClass_Click(object sender, EventArgs e)
        {
            trbFindClass_Click(sender, e);
        }

        private void FrmClass_Load(object sender, EventArgs e)
        {
            BusinessRuler.Classes objClass = new BusinessRuler.Classes(this.dgvDetails);
            objClass.UpdateDataGrid();
        }
               
        private void trbAddClass_Click(object sender, EventArgs e)
        {
            FrmAddClass frmAddClass = new FrmAddClass(this.dgvDetails);
            frmAddClass.ShowDialog();
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

        private void trbModifyClass_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            FrmModifyClass frmModifyClass = new FrmModifyClass(this.dgvDetails);
            frmModifyClass.ShowDialog();
        }

        private void trbDeleteClass_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            BusinessRuler.Classes objClass = new BusinessRuler.Classes(this.dgvDetails);
            objClass.DeleteClass(this.dgvDetails.CurrentRow.Cells[0].Value.ToString());
        }

        private void trbFindClass_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            FrmFindClass frmFindClass = new FrmFindClass(dgvDetails);
            frmFindClass.Show();
        }

        private void dgvDetails_DataSourceChanged(object sender, EventArgs e)
        {
            this.tslInfo.Text = "当前系统共有班级：" + this.dgvDetails.Rows.Count.ToString() + "个。"; 
        }

        private void tbrExportReport_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            FrmExportReport frmExportReport = new FrmExportReport(dgvDetails, "班级信息");
            frmExportReport.ShowDialog();
        }

        private void trbReturnMain_Click(object sender, EventArgs e)
        {
            this.Close();
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
            MyPrintDocument.DocumentName = "班级信息";
            MyPrintDocument.PrinterSettings = MyPrintDialog.PrinterSettings;
            MyPrintDocument.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            MyPrintDocument.DefaultPageSettings.Margins = new Margins(40, 40, 40, 40);

            if (MessageBox.Show("你希望居中打印吗？", "打印居中", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MyDataGridViewPrinter = new DataGridViewPrinter(this.dgvDetails, MyPrintDocument, true, true, "班级信息", new Font("Tahoma", 15, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
            }
            else
            {
                MyDataGridViewPrinter = new DataGridViewPrinter(this.dgvDetails, MyPrintDocument, false, true, "班级信息", new Font("Tahoma", 15, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
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