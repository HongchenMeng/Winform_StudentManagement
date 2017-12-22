using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmChangePwd : Form
    {
        private string _userName;
        public FrmChangePwd(string userName)
        {
            InitializeComponent();
            _userName = userName;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtNewPwd.Clear();
            this.txtConfirmPwd.Clear();
        }

        private bool CheckInput()
        {
            //检查用户输入
            if ((this.txtNewPwd.Text.Length < 8) || (this.txtConfirmPwd.Text.Length < 8))
            {
                MessageBox.Show("密码长度限制在8-20位之间！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false ;
            }
            else if (!this.txtNewPwd.Text.Trim().Equals(this.txtConfirmPwd.Text.Trim()))
            {
                MessageBox.Show("两次输入的密码不相同，请重新输入（注意大小写）！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            BusinessRuler.User objUser = new BusinessRuler.User();
            objUser.ChangePassword(this._userName, this.txtNewPwd.Text);
        }
    }
}