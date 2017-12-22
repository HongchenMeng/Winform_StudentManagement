using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmModifySubject : Form
    {
        private DataGridView _dgvSubject;
        public FrmModifySubject(DataGridView dgv)
        {
            InitializeComponent();
            _dgvSubject = dgv;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            //修改科目
            string subjectName = this.cboSubjectName.SelectedItem.ToString();
            int period = Int32.Parse(this.txtPeriod.Text);
            string remark = this.txtRemark.Text.Trim();
            BusinessRuler.Subject objSubject = new BusinessRuler.Subject(this._dgvSubject);
            objSubject.Update(subjectName, period, remark);
        }

        public bool CheckInput()
        {
            if (this.txtPeriod.Text.Trim().Length == 0)
            {
                MessageBox.Show("学时数不可为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPeriod.Focus();
                return false;
            }
            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtPeriod.Clear();
            this.txtRemark.Clear();
        }

        private void FrmModifySubject_Load(object sender, EventArgs e)
        {
            string subjectName = this._dgvSubject.CurrentRow.Cells["SubjectName"].Value.ToString();
            BusinessRuler.Subject.FillCboByAllSubjectName(this.cboSubjectName, subjectName);
            this.txtPeriod.Text = this._dgvSubject.CurrentRow.Cells["Period"].Value.ToString();
            this.txtRemark.Text = this._dgvSubject.CurrentRow.Cells["Remark"].Value.ToString();
        }

        private void cboSubjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string subjectName = this.cboSubjectName.SelectedItem.ToString();
            DataAccess.Subject objSubject = DataAccess.Subject.CreateInstance(subjectName);
            this.txtPeriod.Text = objSubject.Period.ToString();
            this.txtRemark.Text = objSubject.Remark;
        }

    }
}