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
    public partial class FrmCourse : Form
    {
        private BusinessRuler.DataGridViewPrinter MyDataGridViewPrinter;
        private string _className;

        public FrmCourse(string className)
        {
            InitializeComponent();
            _className = className;
        }

        private void trbAdd_Click(object sender, EventArgs e)
        {
            FrmAddCourse frmAddCourse = new FrmAddCourse(this.dgvDetails, _className);
            frmAddCourse.ShowDialog();
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
            FrmModifyCourse frmModifyCourse = new FrmModifyCourse(this.dgvDetails, _className);
            frmModifyCourse.ShowDialog();
        }

        private void trbDelete_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            BusinessRuler.Course objCourse = new BusinessRuler.Course(this.dgvDetails, _className);
            objCourse.Delete();
        }

        private void FrmCourse_Load(object sender, EventArgs e)
        {
            BusinessRuler.Course objCourse = new BusinessRuler.Course(this.dgvDetails, _className);
            objCourse.UpdateDataGrid();
        }

        private void dgvDetails_DataSourceChanged(object sender, EventArgs e)
        {
            this.slb1.Text = "��ǰ�����༶: " + this._className;
            this.slb2.Text = "�ð�Ŀǰ����" + this.dgvDetails.Rows.Count.ToString() + "�ſγ�!";
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
            FrmExportReport frmExportReport = new FrmExportReport(dgvDetails, "�γ���Ϣ");
            frmExportReport.ShowDialog();
        }

        private void trbFind_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            FrmFindCourse frmFindCourse = new FrmFindCourse(dgvDetails, _className);
            frmFindCourse.Show();
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
            MyPrintDocument.DocumentName = "�γ���Ϣ";
            MyPrintDocument.PrinterSettings = MyPrintDialog.PrinterSettings;
            MyPrintDocument.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            MyPrintDocument.DefaultPageSettings.Margins = new Margins(40, 40, 40, 40);

            if (MessageBox.Show("��ϣ�����д�ӡ��", "��ӡ����", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MyDataGridViewPrinter = new DataGridViewPrinter(this.dgvDetails, MyPrintDocument, true, true, "�γ���Ϣ", new Font("Tahoma", 15, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
            }
            else
            {
                MyDataGridViewPrinter = new DataGridViewPrinter(this.dgvDetails, MyPrintDocument, false, true, "�γ���Ϣ", new Font("Tahoma", 15, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
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