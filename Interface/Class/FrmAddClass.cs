using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmAddClass : Form
    {
        private DataGridView _dgvClass;
        public FrmAddClass(DataGridView dgv)
        {
            InitializeComponent();
            _dgvClass = dgv;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtClassName.Clear();
            this.txtDirector.Clear();
            this.txtRemark.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            BusinessRuler.Classes objClass = new BusinessRuler.Classes(this._dgvClass);
            objClass.AddClass(this.txtClassName.Text.Trim(), this.txtDirector.Text.Trim(), this.dtpCreateDate.Value, this.txtRemark.Text.Trim());
        }

        public bool CheckInput()
        {
            if (this.txtClassName.Text.Trim().Length == 0 )
            {
                MessageBox.Show("班级名称不可为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtClassName.Focus();
                return false;
            }
            else if (this.txtDirector.Text.Trim().Length  == 0 )
            {
                MessageBox.Show("班主任名称不可为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDirector.Focus();
                return false;
            }
            return true;
        }
    }
}