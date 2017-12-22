using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class Subject
    {
        private string _subjectName;
        private int _period;
        private string _remark;

        #region attribute

        public string SubjectName
        {
            get
            {
                return _subjectName;
            }
        }

        public int Period
        {
            get
            {
                return _period;
            }
            set
            {
                _period = value;
            }
        }

        public string Remark
        {
            get
            {
                return _remark;
            }
            set
            {
                _remark = value;
            }
        }

        #endregion

        public Subject(string subjectName)
        {
            _subjectName = subjectName;
        }

        public static Subject CreateInstance(string subjectName)
        {
            Subject objSubject = null;
            string strSql = "select * from Subject where [SubjectName] = @subjectName ";
            SqlCommon sqlcomm = new SqlCommon();
            SqlDataReader reader = sqlcomm.ExecuteReader(strSql, new SqlParameter("@subjectName", subjectName));
            if (reader.Read())
            {
                objSubject = new Subject(subjectName);
                objSubject._period = Int32.Parse(reader["Period"].ToString());
                objSubject._remark = reader["Remark"].ToString();
            }
            reader.Close();
            return objSubject;
        }

        //ͨ����Ŀ���Ʒ���һ����¼,���жϿ�Ŀ�Ƿ����
        public static SqlDataReader GetReaderBySubjectName(string subjectName)
        {
            string strSql = "select SubjectName from Subject where [SubjectName] = @subjectName";
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.ExecuteReader(strSql,new SqlParameter("@subjectName",subjectName));
        }

        //��ӿ�Ŀ
        public static int Add(string subjectName, int period, string remark)
        {
            string strSql = "insert into Subject(SubjectName,Period,Remark) values(@subjectName,@period,@remark)";
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.ExecuteNonQuery(strSql, new SqlParameter("@subjectName", subjectName), new SqlParameter("@period", period), new SqlParameter("@remark", remark));
        }

        //�޸Ŀ�Ŀ
        public int Update()
        {
            string strSql = "update Subject set [Period] = @period, Remark = @remark where [SubjectName] = @subjectName";
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.ExecuteNonQuery(strSql,new SqlParameter("@period", _period), new SqlParameter("@remark", _remark) ,new SqlParameter("@subjectName", _subjectName) );
        }

        //ɾ����Ŀ
        public int Delete()
        {
            //ɾ����Ŀ��ͬʱ����ɾ���γ̡��ɼ���Ϣ
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Score where [CourseID] in (select CourseID from Course where [SubjectName] = @subjectName) ;") ;
            strSql.Append("delete from Course where [SubjectName] = @subjectName ;");
            strSql.Append("delete from Subject where [SubjectName] = @subjectName");
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.ExecuteNonQuery(strSql.ToString(),true,false,new SqlParameter("@subjectName", _subjectName));
        }

        //��ȡ���п�Ŀ��¼�ļ���
        public static DataSet FillByAllSubject()
        {
            string strSql = "select * from Subject";
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.CreaDataSet(strSql, null);
        }

        //��ȡ���пγ����Ƶļ���
        public static DataSet FillByAllSubjectName()
        {
            string strSql = "select SubjectName from Subject";
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.CreaDataSet(strSql, null);
        }
    }
}
