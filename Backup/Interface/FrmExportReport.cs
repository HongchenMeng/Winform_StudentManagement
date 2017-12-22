using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Interface
{
    public partial class FrmExportReport : Form
    {
        private DataGridView _dgvDetails;
        private string _title;
        public FrmExportReport(DataGridView dgv,string title)
        {
            InitializeComponent();
            _dgvDetails = dgv;
            _title = title;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.rdoTxtType.Checked)
            {
                BusinessRuler.ExportExcel.DoForText(_dgvDetails,_title);
            }
            else
            {
                BusinessRuler.ExportExcel.DoForExcel(_dgvDetails,_title);
            }
            this.Close();
        }  

    }
}