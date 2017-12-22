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
    public partial class FrmScore : Form
    {
        private BusinessRuler.DataGridViewPrinter MyDataGridViewPrinter;
        private string _className;
        public FrmScore(string className)
        {
            InitializeComponent();
            _className = className;
        }

        private void FrmScore_Load(object sender, EventArgs e)
        {
            BusinessRuler.Score objScore = new BusinessRuler.Score(this.dgvDetails, _className);
            objScore.UpdateDataGrid();
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

        private void trbAdd_Click(object sender, EventArgs e)
        {
            FrmAddScore frmAddScore = new FrmAddScore(this.dgvDetails, _className);
            frmAddScore.ShowDialog();
        }

        private void trbModify_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            FrmModifyScore frmModifyScore = new FrmModifyScore(this.dgvDetails, _className);
            frmModifyScore.ShowDialog();
        }

        private void trbDelete_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            BusinessRuler.Score objScore = new BusinessRuler.Score(this.dgvDetails, _className);
            objScore.Delete();
        }

        private void dgvDetails_DataSourceChanged(object sender, EventArgs e)
        {
            this.tsl1.Text = "��ǰ�����༶: " + _className;
            this.tsl2.Text = "��ǰ����ѧ���ɼ���¼: " + dgvDetails.Rows.Count.ToString() + "��";
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
            FrmExportReport frmExportReport = new FrmExportReport(dgvDetails, _className+"�� ѧ���ɼ���Ϣ");
            frmExportReport.ShowDialog();
        }

        private void trbFind_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            FrmFindScore frmFindScore = new FrmFindScore(dgvDetails);
            frmFindScore.Show();
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
            MyPrintDocument.DocumentName = _className+"�� �ɼ���Ϣ";
            MyPrintDocument.PrinterSettings = MyPrintDialog.PrinterSettings;
            MyPrintDocument.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            MyPrintDocument.DefaultPageSettings.Margins = new Margins(40, 40, 40, 40);

            if (MessageBox.Show("��ϣ�����д�ӡ��", "��ӡ����", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MyDataGridViewPrinter = new DataGridViewPrinter(this.dgvDetails, MyPrintDocument, true, true, _className + "�� �ɼ���Ϣ", new Font("Tahoma", 15, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
            }
            else
            {
                MyDataGridViewPrinter = new DataGridViewPrinter(this.dgvDetails, MyPrintDocument, false, true, _className + "�� �ɼ���Ϣ", new Font("Tahoma", 15, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
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