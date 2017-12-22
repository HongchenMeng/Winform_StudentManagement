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

        //验证用户名是否已存在
        public static bool CheckUserExists(string userName)
        {
            return DataAccess.User.GetReaderByUserName(userName).HasRows;
        }

        //添加用户
        public void AddUser(string userName, bool level, bool status)
        {
            //首先判断用户名是否已存在
            if (CheckUserExists(userName))
            {
                MessageBox.Show("用户名 " + userName + "已存在，请选择其它用户名！", "用户名已存在", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DataAccess.User.CreaUser(userName, level, status) > 0)
                {
                    UpdateDataGrid();
                    MessageBox.Show("成功添加用户!", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //更新FrmUser中数据网格的显示
        public void UpdateDataGrid()
        {
            DataSet objDataSet = DataAccess.User.FillByAllUser();
            this._dgvUser.DataSource = objDataSet.Tables[0];
        }

        //改变用户权限
        public void ChangeLevel(string userName, bool level, bool status)
        {
            DataAccess.User objUser = new DataAccess.User(userName);
            objUser.Level = level;
            objUser.Status = status;
            if (objUser.ChangeLevel() > 0)
            {
                UpdateDataGrid();
                MessageBox.Show("修改用户权限成功!", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //删除用户
        public void Delete()
        {
            string userName = this._dgvUser.CurrentRow.Cells["UserName"].Value.ToString();
            DataAccess.User objUser = new DataAccess.User(userName);
            if (DialogResult.Yes == MessageBox.Show("真的要删除用户' " + userName + " '吗?", "删除用户", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (objUser.Delete() > 0)
                {
                    UpdateDataGrid();
                    MessageBox.Show("成功删除用户' " + userName + " '!", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //验证登陆
        public static bool Login(string userName, string password)
        {
            //首先判断用户名是否输入有误
            if (!DataAccess.User.GetReaderByUserName(userName).HasRows)
            {
                MessageBox.Show("你输入的用户名并不存在！", "非法登陆", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //再判断用户名正确的情况下密码是否输入有误
            if (!DataAccess.User.CheckByUserNameAndPwd(userName, password).HasRows)
            {
                MessageBox.Show("密码输入有误！", "非法登陆", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //判断用户名和密码都正确的情况下帐户是否被封
            if (!DataAccess.User.CheckStatus(userName).HasRows)
            {
                MessageBox.Show("当前帐户已被暂停，请联系系统管理员重新开通", "非法登陆", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
            //验证成功，进入主界面
        }

        //判断是否是管理员
        public bool IsAdmin(string userName)
        {
            DataAccess.User objUser = new DataAccess.User(userName);
            return objUser.CheckAdmin().HasRows;
        }

        //更改密码
        public void ChangePassword(string userName, string password)
        {
            DataAccess.User objUser = new DataAccess.User(userName);
            objUser.Password = password;
            if (objUser.ChangePassword() > 0)
            {
                MessageBox.Show("更改密码成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("密码更改失败，请重试！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //查找用户
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
            MessageBox.Show("已到记录末尾！", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv.Tag = 0;
        }


    }
}
