using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmFindTeacher : Form
    {
        private DataGridView _dgvTeacher;
        public FrmFindTeacher(DataGridView dgv)
        {
            InitializeComponent();
            _dgvTeacher = dgv;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool CheckInput()
        {
            if (this.rdoTeacherName.Checked)
            {
                if (cboTeacherName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请选择或输入教师姓名", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cboTeacherName.Focus();
                    return false;
                }
            }
            else
            {
                if (txtIdCard.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请选择或输入身份证号", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIdCard.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (this.rdoTeacherName.Checked)
            {
                string teacherName = this.cboTeacherName.Text.Trim();
                bool useMatch = false;
                if (this.cbxLikeTeacherName.Checked)
                {
                    useMatch = true;
                }
                BusinessRuler.Teacher.FindByTeacherName(_dgvTeacher, teacherName, useMatch);
            }
            else if(this.rdoByCardID.Checked)
            {
                string cardId = this.txtIdCard.Text.Trim();
                bool useMatch = false;
                if (this.chxUseMatchByIdCard.Checked)
                {
                    useMatch = true;
                }
                BusinessRuler.Teacher.FindByCardID(_dgvTeacher, cardId, useMatch);
            }
        }

        private void rdoTeacherName_CheckedChanged(object sender, EventArgs e)
        {
            this.cboTeacherName.Enabled = this.cbxLikeTeacherName.Enabled = this.rdoTeacherName.Checked;
        }

        private void FrmFindTeacher_Load(object sender, EventArgs e)
        {
            BusinessRuler.Teacher.FillCboByAllTeacherName(this.cboTeacherName, null);
            this.txtIdCard.Enabled = this.chxUseMatchByIdCard.Enabled = false;
        }

        private void rdoByCardID_CheckedChanged(object sender, EventArgs e)
        {
            this.txtIdCard.Enabled = this.chxUseMatchByIdCard.Enabled = this.rdoByCardID.Checked;
        }
    }
}