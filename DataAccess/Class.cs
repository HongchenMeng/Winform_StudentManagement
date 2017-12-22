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
		
		//�õ��༶�����б�
		public ArrayList GetClassNameList()
		{
			string strSql = "select ClassName from Class"; 
			return GetList(strSql);
		}
		
		//�����°༶
		public void Insert(string className,string createDate,string remark)
		{
			string strSql = "insert into Class (ClassName,EntranceDate) values('"+className+"','"+createDate+"')";	
			if(remark != null)
			{
				strSql = "insert into Class (ClassName,EntranceDate,Remark) values('"+className+"','"+createDate+"','"+remark+"')";
			}
			UpdateDataBaseBySql(strSql);
		}
		
		//�����û�ѡ��İ༶���ƣ����༶���Ƽ���ע��ʾ���ı�����
		public override DataRow GetRecord(string className)
		{
			string strSql = "select * from Class where ClassName = '"+className+"'";
			return base.GetRecord(strSql);
		}

		//���ݰ༶�����޸İ༶��ע
		public void UpdateClass(string className,string createDate,string remark)
		{
			string strSql = "update Class set ClassName = '"+className+"',EntranceDate = '"+createDate+"', Remark = '"+remark+"' where ClassName = '"+className+"'";
			base.UpdateDataBaseBySql(strSql);
		}

	}
}
