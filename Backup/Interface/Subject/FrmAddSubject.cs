using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmAddSubject : Form
    {
        private DataGridView _dgvSubject;
        public FrmAddSubject(DataGridView dgv)
        {
            InitializeComponent();
            _dgvSubject = dgv;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            //新增科目
            string subjectName = this.txtSubjectName.Text.Trim();
            int period = Int32.Parse(this.txtPeriod.Text);
            string remark = this.txtRemark.Text.Trim();
            BusinessRuler.Subject objSubject = new BusinessRuler.Subject(this._dgvSubject);
            objSubject.Add(subjectName, period, remark);
        }

        public bool CheckInput()
        {
            if (this.txtSubjectName.Text.Trim() == "")
            {
                MessageBox.Show("科目名称不可为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSubjectName.Focus();
                return false;
            }
            else if (this.txtPeriod.Text.Trim().Length == 0)
            {
                MessageBox.Show("学时数不可为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPeriod.Focus();
                return false;
            }
            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtSubjectName.Clear();
            this.txtPeriod.Clear();
            this.txtRemark.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}