using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmModifyUser : Form
    {
        private DataGridView _dgvUser;
        public FrmModifyUser(DataGridView dgv)
        {
            InitializeComponent();
            _dgvUser = dgv;
        }

        private void FrmModifyUser_Load(object sender, EventArgs e)
        {
            this.lblNameContent.Text = this._dgvUser.CurrentRow.Cells[0].Value.ToString();
            if (bool.Parse(this._dgvUser.CurrentRow.Cells[1].Value.ToString()))
            {
                this.cboType.SelectedIndex = 0;
            }
            else
            {
                this.cboType.SelectedIndex = 1;
            }

            if (bool.Parse(this._dgvUser.CurrentRow.Cells[2].Value.ToString()))
            {
                this.rdoEnable.Checked = true;
            }
            else
            {
                this.rdoDisable.Checked = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool level = false;
            bool status = false;
            if (this.cboType.SelectedIndex == 0)
            {
                level = true;
            }
            if (this.rdoEnable.Checked)
            {
                status = true;
            }
            BusinessRuler.User objUser = new BusinessRuler.User(this._dgvUser);
            objUser.ChangeLevel(this.lblNameContent.Text, level, status);
            this.Close();
        }

    }
}