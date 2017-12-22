using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccess
{
	public class Login:Common
	{
		private string _userName;
		private string _password;
		
		public Login(string userName,string password):base()
		{
			_userName = userName;
			_password = password;
		}

		//验证用户登陆
		public virtual bool CheckLogin()
		{
			bool result = false;
			string strSql = "select * from userInfo where userName = '"+_userName+"'and password = '"+_password+"'";
			this._objSqlCommand.CommandText = strSql;
			this.ConnDataBase();
			try
			{
				this._objSqlDataReader = _objSqlCommand.ExecuteReader();
				result = _objSqlDataReader.Read();
			}
			catch(SqlException ex)
			{
				MessageBox.Show(ex.Message,"出错",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				this._objSqlConnection.Close();
				_objSqlDataReader.Close();
			}
			return result;
		}


	}
}
