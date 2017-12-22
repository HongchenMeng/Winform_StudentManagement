using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessRuler;

namespace Interface
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                return;
            } 
            if (BusinessRuler.User.Login(this.txtUserName.Text.Trim(), this.txtPassword.Text.Trim()))
            {
                if (this.chxSaveUserName.Checked)
                {
                    BusinessRuler.ReaderWirteConfig.WriteToAppConfig("userName", this.txtUserName.Text.Trim());
                }
                else
                {
                    BusinessRuler.ReaderWirteConfig.WriteToAppConfig("userName", "");
                }
                this.Hide();
                FrmMain frmMain = new FrmMain(this.txtUserName.Text);
                //�����½���û���
                frmMain.CurrentUser = this.txtUserName.Text.Trim();
                BusinessRuler.User objUser = new User();
                frmMain.SetMnuSystemManageVisible(objUser.IsAdmin(this.txtUserName.Text.Trim()));
                frmMain.ShowDialog();
                this.Close();
            }
        }

       public bool Check()
		{
			if(this.txtUserName.Text.Trim().Length < 8 )
			{
                this.lblPrompt.Text = "�û���������8-20λ֮�䣡";
				this.txtUserName.Focus();
                this.txtUserName.Select();
				return false;
			}
			else if(this.txtPassword.Text.Trim().Length < 8 )
			{
                this.lblPrompt.Text = "���볤��������8-20λ֮�䣡";
				this.txtPassword.Focus();
                this.txtPassword.Select();
				return false;
			}
			return true;
		}

        private void txtUserName_MouseEnter(object sender, EventArgs e)
        {
            this.lblPrompt.Text = "�û�������8-20λ֮��";
        }

        private void txtUserName_MouseLeave(object sender, EventArgs e)
        {
            this.lblPrompt.Text = string.Empty;
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            this.lblPrompt.Text = "��½���볤��8-20λ֮��";
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            this.lblPrompt.Text = string.Empty;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //����Ĭ���û���
            string userName = BusinessRuler.ReaderWirteConfig.GetValueByKey("userName");
            this.txtUserName.Text = userName;
            if (userName.Trim().Length == 0)
            {
                this.chxSaveUserName.Checked = false;
            }
            else
            {
                this.chxSaveUserName.Checked = true;
            }
        }

    }
}