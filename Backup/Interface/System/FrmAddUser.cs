using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmAddUser : Form
    {
        private DataGridView _dgvUser;
        public FrmAddUser(DataGridView dgv)
        {
            InitializeComponent();
            _dgvUser = dgv;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            bool level = false;
            bool status = false;
            if(this.cboType.SelectedIndex == 0)
            {
                level = true;
            }
            if(this.rdoEnable.Checked)
            {
                status = true;
            }
            BusinessRuler.User objUser = new BusinessRuler.User(this._dgvUser);
            objUser.AddUser(this.txtUserName.Text.Trim(), level, status);
        }

        public bool CheckInput()
        {
            if (this.txtUserName.Text.Trim().Length < 8 )
            {
                MessageBox.Show("用户名长度不能小于8个字符", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUserName.Focus();
                return false;
            }
            else if (this.cboType.SelectedIndex < 0)
            {
                MessageBox.Show("请选择帐户类型!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cboType.Focus();
                return false;
            }
            return true;
        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            this.cboType.SelectedIndex = 1;
            this.rdoDisable.Checked = true;
        }

    }
}