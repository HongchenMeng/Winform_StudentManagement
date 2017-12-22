using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{ 
	public class User
	{
        private string _userName;
        private string _password;
        private bool _level;
        private bool _status;

        #region attribute
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public bool Level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;
            }
        }

        public bool Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
        #endregion

        public User(string userName)
        {
            _userName = userName;
        }

        #region login

        public static SqlDataReader GetReaderByUserName(string userName)
		{
			string strSql = "select * from UserInfo where [UserName] = @userName";
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.ExecuteReader(strSql,new SqlParameter("@userName",userName));            
		}

		public static SqlDataReader CheckByUserNameAndPwd(string userName,string password)
		{
            string strSql = "select userName from UserInfo where [userName] = @userName and [password] = @password";
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.ExecuteReader(strSql, new SqlParameter("@userName", userName), new SqlParameter("@password", password));				
		}
		
		public static SqlDataReader CheckStatus(string userName)
		{
            string strSql = "select * from UserInfo where [userName] = @userName and status = '1'";
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.ExecuteReader(strSql, new SqlParameter("@userName", userName));
		}
		#endregion
			
		//添加用户
		public static int CreaUser(string userName,bool level,bool status)
		{
            string strSql = "insert into UserInfo(UserName,Level,Status) values(@userName,@level,@status)";
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.ExecuteNonQuery(strSql,new SqlParameter("@userName",userName),new SqlParameter("@level",level),new SqlParameter("@status",status));
		}
		
		//改变用户权限
		public int ChangeLevel()
		{
            string strSql = "update UserInfo set [Level] = @level ,Status = @status where [UserName] = @userName";
            SqlCommon sqlcomm = new SqlCommon();
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@level",_level);
            para[1] = new SqlParameter("@status",_status);
            para[2] = new SqlParameter("@userName",_userName);
            return sqlcomm.ExecuteNonQuery(strSql, para);
		}

		//判断用户是否为管理员
		public SqlDataReader CheckAdmin()
		{
            string strSql = "select level from UserInfo where [userName] = @userName and [level] = '1'";
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.ExecuteReader(strSql, new SqlParameter("@userName", _userName));
		}

		//改变密码
		public int ChangePassword()
		{
            string strSql = "update UserInfo set [password] = @password where [userName] = @userName";
            SqlParameter[] para = { new SqlParameter("@password", _password), new SqlParameter("@userName", _userName) };
            SqlCommon sqlcomm = new SqlCommon();
			return sqlcomm.ExecuteNonQuery(strSql,para);
		}

		//删除用户
		public int Delete()
		{
            string strSql = "delete from UserInfo where [userName] = @userName";
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.ExecuteNonQuery(strSql, new SqlParameter("@userName", _userName));
		}

		//得到所有用户的记录
		public static DataSet FillByAllUser()
		{
            string strSql = "select UserName,Level,Status from UserInfo";
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.CreaDataSet(strSql, null);
		}


	}
}
