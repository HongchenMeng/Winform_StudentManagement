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
            //����û�����
            if ((this.txtNewPwd.Text.Length < 8) || (this.txtConfirmPwd.Text.Length < 8))
            {
                MessageBox.Show("���볤��������8-20λ֮�䣡", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false ;
            }
            else if (!this.txtNewPwd.Text.Trim().Equals(this.txtConfirmPwd.Text.Trim()))
            {
                MessageBox.Show("������������벻��ͬ�����������루ע���Сд����", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
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