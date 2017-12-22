using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmFindSubject : Form
    {
        private DataGridView _dgvSubject;
        public FrmFindSubject(DataGridView dgv)
        {
            InitializeComponent();
            _dgvSubject = dgv;
        }

        private void FrmFindSubject_Load(object sender, EventArgs e)
        {
            BusinessRuler.Subject.FillCboByAllSubjectName(cboSubjectName, null);
        }

        public bool Check()
        {
            if (this.cboSubjectName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选择或输入科目名称","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.cboSubjectName.Focus();
                return false;
            }
            return true;
        }
 
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                return;
            }
            string subjectName = this.cboSubjectName.Text.Trim();
            bool useMatch = false;
            if (chxUseMatch.Checked)
            {
                useMatch = true;
            }
            BusinessRuler.Subject.FindBySubjectName(_dgvSubject, subjectName, useMatch);
        }

    }
}