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
    public partial class FrmStudent : Form
    {
        private BusinessRuler.DataGridViewPrinter MyDataGridViewPrinter;
        private string _className;
        public FrmStudent(string className)
        {
            InitializeComponent();
            _className = className;
        }

        public FrmStudent()
        { 
        
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            BusinessRuler.Student objStudent = new BusinessRuler.Student(this.dgvDetails, this._className);
            objStudent.UpdateDataGrid();
        }

        private void trbAdd_Click(object sender, EventArgs e)
        {
            if (BusinessRuler.Classes.isInCapacity(_className))
            {
                FrmAddStudent frmAddStudent = new FrmAddStudent(this.dgvDetails, this._className);
                frmAddStudent.ShowDialog();
            }
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

        private void trbModify_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            FrmModifyStudent frmModifyStudent = new FrmModifyStudent(this.dgvDetails, this._className);
            frmModifyStudent.ShowDialog();
        }

        private void trbDelete_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            int studentNo = (Int32.Parse(this.dgvDetails.CurrentRow.Cells[0].Value.ToString()));
            string studentName = this.dgvDetails.CurrentRow.Cells[1].Value.ToString();
            BusinessRuler.Student objStudent = new BusinessRuler.Student(this.dgvDetails, _className);
            objStudent.Delete(studentNo, studentName, _className);
        }
        //51aspx.com下载
        private void dgvDetails_DataSourceChanged(object sender, EventArgs e)
        {
            this.tsl1.Text = "当前操作班级: " + _className;
            this.tsl2.Text = "共有学生: " + dgvDetails.Rows.Count.ToString() + "名。";
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
            FrmExportReport frmExportReport = new FrmExportReport(dgvDetails, "学生档案信息");
            frmExportReport.ShowDialog();
        }

        private void dgvDetails_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void dgvDetails_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                this.Cursor = System.Windows.Forms.Cursors.Hand;
            }
        }

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 4)
            {
                return;
            }
            DisplayImage();
        }

        public void DisplayImage()
        {
            string fileName = this.dgvDetails.CurrentCell.Value.ToString();
            if (fileName.Trim().Length == 0)
            {
                return;
            }
            Image img = BusinessRuler.ImageManage.GetImageFromServer(fileName);
            FrmViewImage frmViewImage = new FrmViewImage(img);
            frmViewImage.Show();
        }

        private void trbFind_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            FrmFindStudent frmFindStudent = new FrmFindStudent(dgvDetails);
            frmFindStudent.Show();
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
            MyPrintDocument.DocumentName = _className+"班 学生信息";
            MyPrintDocument.PrinterSettings = MyPrintDialog.PrinterSettings;
            MyPrintDocument.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            MyPrintDocument.DefaultPageSettings.Margins = new Margins(40, 40, 40, 40);

            if (MessageBox.Show("你希望居中打印吗？", "打印居中", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MyDataGridViewPrinter = new DataGridViewPrinter(this.dgvDetails, MyPrintDocument, true, true, _className + "班 学生信息", new Font("Tahoma", 15, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
            }
            else
            {
                MyDataGridViewPrinter = new DataGridViewPrinter(this.dgvDetails, MyPrintDocument, false, true, _className + "班 学生信息", new Font("Tahoma", 15, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
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