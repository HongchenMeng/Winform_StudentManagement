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
    public partial class FrmSubject : Form
    {
        private BusinessRuler.DataGridViewPrinter MyDataGridViewPrinter;
        public FrmSubject()
        {
            InitializeComponent();
        }

        private void trbAdd_Click(object sender, EventArgs e)
        {
            FrmAddSubject frmAddSubject = new FrmAddSubject(this.dgvDetails);
            frmAddSubject.ShowDialog();
        }

        public bool CheckCondition()
        {
            if (dgvDetails.Rows.Count == 0)
            {
                MessageBox.Show("��ǰ���κ�����,�����޷�ִ��!", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void trbModify_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            FrmModifySubject frmModifySubject = new FrmModifySubject(this.dgvDetails);
            frmModifySubject.ShowDialog();
        }

        private void trbDelete_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            BusinessRuler.Subject objSubject = new BusinessRuler.Subject(this.dgvDetails);
            objSubject.Delete();
        }

        private void trbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSubject_Load(object sender, EventArgs e)
        {
            BusinessRuler.Subject objSubject = new BusinessRuler.Subject(this.dgvDetails);
            objSubject.UpdateDataGrid();
        }

        private void dgvDetails_DataSourceChanged(object sender, EventArgs e)
        {
            this.tsl1.Text = "��ǰϵͳ���п�Ŀ������ " + dgvDetails.Rows.Count.ToString(); 
        }

        private void trbReturnMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trbExportReport_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            FrmExportReport frmExportReport = new FrmExportReport(dgvDetails, "��Ŀ��Ϣ");
            frmExportReport.ShowDialog();
        }

        private void trbFind_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            FrmFindSubject frmFindSubject = new FrmFindSubject(dgvDetails);
            frmFindSubject.Show();
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
            MyPrintDocument.DocumentName = "��Ŀ��Ϣ";
            MyPrintDocument.PrinterSettings = MyPrintDialog.PrinterSettings;
            MyPrintDocument.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            MyPrintDocument.DefaultPageSettings.Margins = new Margins(40, 40, 40, 40);

            if (MessageBox.Show("��ϣ�����д�ӡ��", "��ӡ����", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MyDataGridViewPrinter = new DataGridViewPrinter(this.dgvDetails, MyPrintDocument, true, true, "��Ŀ��Ϣ", new Font("Tahoma", 15, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
            }
            else
            {
                MyDataGridViewPrinter = new DataGridViewPrinter(this.dgvDetails, MyPrintDocument, false, true, "��Ŀ��Ϣ", new Font("Tahoma", 15, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
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