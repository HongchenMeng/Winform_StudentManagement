using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmFindStudent : Form
    {
        private DataGridView _dgvStudent;
        public FrmFindStudent(DataGridView dgv)
        {
            InitializeComponent();
            _dgvStudent = dgv;
        }

        private void txtStudentNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar < '0' || e.KeyChar > '9';
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
        }

        public bool CheckInput()
        {
            if (this.rdoStudentNo.Checked)
            {
                if (this.txtStudentNo.Text.Trim().Length == 0)
                {
                    MessageBox.Show("«Î ‰»Î—ß∫≈£°","¥ÌŒÛ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this.txtStudentNo.Focus();
                    return false;
                }
            }
            else
            {
                if (this.txtStudentName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("«Î ‰»Î—ß…˙–’√˚£°","¥ÌŒÛ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this.txtStudentName.Focus();
                    return false;
                }
            }
            return true;
        }

        private void rdoStudentNo_CheckedChanged(object sender, EventArgs e)
        {
            this.txtStudentNo.Enabled = this.chxMatchByStudentNo.Enabled = this.rdoStudentNo.Checked;
        }

        private void rdoStudentName_CheckedChanged(object sender, EventArgs e)
        {
            this.txtStudentName.Enabled = this.chxMatchByStudentName.Enabled = this.rdoStudentName.Checked;
        }

        private void FrmFindStudent_Load(object sender, EventArgs e)
        {
            this.txtStudentName.Enabled = this.chxMatchByStudentName.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            if (this.rdoStudentNo.Checked)
            {
                int studentNo = Int32.Parse(this.txtStudentNo.Text);
                bool useMatch = false;
                if(this.chxMatchByStudentNo.Checked)
                {
                    useMatch = true;
                }
                BusinessRuler.Student.FindByStudentNo(_dgvStudent, studentNo, useMatch);
            }
            else
            {
                string studentName = this.txtStudentName.Text.Trim();
                bool useMatch = false;
                if (this.chxMatchByStudentName.Checked)
                {
                    useMatch = true;
                }
                BusinessRuler.Student.FindByStudentName(_dgvStudent, studentName, useMatch);
            }

        }

       
    }
}