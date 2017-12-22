using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmFindUser : Form
    {
        private DataGridView _dgvUser;
        public FrmFindUser(DataGridView dgv)
        {
            InitializeComponent();
            _dgvUser = dgv;
        }

        public bool CheckInput()
        {
            if (this.txtUserName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入用户名！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.txtUserName.Focus();
                return false;
            }
            return true;
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            string userName = this.txtUserName.Text.Trim();
            bool useMatch = false;
            if(this.chxUseMatch.Checked)
            {
                useMatch = true;
            }
            BusinessRuler.User.FindByUserName(_dgvUser, userName, useMatch);
        }
    }
}