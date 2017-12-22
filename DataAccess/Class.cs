using System;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Timers;

namespace DataAccess
{ 
	public class Class:Common
	{
		public Class():base()
		{
			
		}
		
		//得到班级名称列表
		public ArrayList GetClassNameList()
		{
			string strSql = "select ClassName from Class"; 
			return GetList(strSql);
		}
		
		//插入新班级
		public void Insert(string className,string createDate,string remark)
		{
			string strSql = "insert into Class (ClassName,EntranceDate) values('"+className+"','"+createDate+"')";	
			if(remark != null)
			{
				strSql = "insert into Class (ClassName,EntranceDate,Remark) values('"+className+"','"+createDate+"','"+remark+"')";
			}
			UpdateDataBaseBySql(strSql);
		}
		
		//根据用户选择的班级名称，将班级名称及备注显示在文本框中
		public override DataRow GetRecord(string className)
		{
			string strSql = "select * from Class where ClassName = '"+className+"'";
			return base.GetRecord(strSql);
		}

		//根据班级名称修改班级备注
		public void UpdateClass(string className,string createDate,string remark)
		{
			string strSql = "update Class set ClassName = '"+className+"',EntranceDate = '"+createDate+"', Remark = '"+remark+"' where ClassName = '"+className+"'";
			base.UpdateDataBaseBySql(strSql);
		}

	}
}
