using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BusinessRuler
{
    public class User
    {
        private DataGridView _dgvUser;
        public User(DataGridView dgv)
        {
            _dgvUser = dgv;
        }

        public User()
        { 
            
        }

        //��֤�û����Ƿ��Ѵ���
        public static bool CheckUserExists(string userName)
        {
            return DataAccess.User.GetReaderByUserName(userName).HasRows;
        }

        //����û�
        public void AddUser(string userName, bool level, bool status)
        {
            //�����ж��û����Ƿ��Ѵ���
            if (CheckUserExists(userName))
            {
                MessageBox.Show("�û��� " + userName + "�Ѵ��ڣ���ѡ�������û�����", "�û����Ѵ���", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DataAccess.User.CreaUser(userName, level, status) > 0)
                {
                    UpdateDataGrid();
                    MessageBox.Show("�ɹ�����û�!", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //����FrmUser�������������ʾ
        public void UpdateDataGrid()
        {
            DataSet objDataSet = DataAccess.User.FillByAllUser();
            this._dgvUser.DataSource = objDataSet.Tables[0];
        }

        //�ı��û�Ȩ��
        public void ChangeLevel(string userName, bool level, bool status)
        {
            DataAccess.User objUser = new DataAccess.User(userName);
            objUser.Level = level;
            objUser.Status = status;
            if (objUser.ChangeLevel() > 0)
            {
                UpdateDataGrid();
                MessageBox.Show("�޸��û�Ȩ�޳ɹ�!", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //ɾ���û�
        public void Delete()
        {
            string userName = this._dgvUser.CurrentRow.Cells["UserName"].Value.ToString();
            DataAccess.User objUser = new DataAccess.User(userName);
            if (DialogResult.Yes == MessageBox.Show("���Ҫɾ���û�' " + userName + " '��?", "ɾ���û�", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (objUser.Delete() > 0)
                {
                    UpdateDataGrid();
                    MessageBox.Show("�ɹ�ɾ���û�' " + userName + " '!", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //��֤��½
        public static bool Login(string userName, string password)
        {
            //�����ж��û����Ƿ���������
            if (!DataAccess.User.GetReaderByUserName(userName).HasRows)
            {
                MessageBox.Show("��������û����������ڣ�", "�Ƿ���½", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //���ж��û�����ȷ������������Ƿ���������
            if (!DataAccess.User.CheckByUserNameAndPwd(userName, password).HasRows)
            {
                MessageBox.Show("������������", "�Ƿ���½", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //�ж��û��������붼��ȷ��������ʻ��Ƿ񱻷�
            if (!DataAccess.User.CheckStatus(userName).HasRows)
            {
                MessageBox.Show("��ǰ�ʻ��ѱ���ͣ������ϵϵͳ����Ա���¿�ͨ", "�Ƿ���½", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
            //��֤�ɹ�������������
        }

        //�ж��Ƿ��ǹ���Ա
        public bool IsAdmin(string userName)
        {
            DataAccess.User objUser = new DataAccess.User(userName);
            return objUser.CheckAdmin().HasRows;
        }

        //��������
        public void ChangePassword(string userName, string password)
        {
            DataAccess.User objUser = new DataAccess.User(userName);
            objUser.Password = password;
            if (objUser.ChangePassword() > 0)
            {
                MessageBox.Show("��������ɹ���", "�ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("�������ʧ�ܣ������ԣ�", "ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //�����û�
        public static void FindByUserName(DataGridView dgv,string userName,bool useMatch)
        {
            for (int row = Int32.Parse(dgv.Tag.ToString()); row < dgv.Rows.Count; row++)
            {
                bool condition = dgv.Rows[row].Cells["userName"].Value.ToString().Equals(userName);
                if (useMatch)
                {
                    condition = dgv.Rows[row].Cells["userName"].Value.ToString().Contains(userName);
                }
                if (condition)
                {
                    dgv.Rows[row].Selected = true;
                    dgv.Tag = (row + 1).ToString();
                    return;
                }
            }
            MessageBox.Show("�ѵ���¼ĩβ��", "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv.Tag = 0;
        }


    }
}
