using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DataAccess
{
    public class Classes
    {
        private string _className;
        private string _director;
        private int _currentCount;
        private DateTime _entranceDate;
        private string _remark;
        #region
        public string Name
        {
            get
            {
                return _className;
            }
            set
            {
                _className = value;
            }
        }

        public string Director
        {
            get
            {
                return _director;
            }
            set
            {
                _director = value;
            }
        }

        public int CurrentCount
        {
            get
            {
                return _currentCount;
            }
            set
            {
                _currentCount = value;
            }
        }

        public DateTime EntranceDate
        {
            get
            {
                return _entranceDate;
            }
            set
            {
                _entranceDate = value;
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

        //ʵ�����༶
        public Classes(string className)
        {
            _className = className;
        }

        public Classes()
        {

        }

        public static Classes CreateInstance(string className)
        {
            Classes c = null;
            string strSql = "select * from Class where [ClassName] = @className ";
            SqlCommon sqlcomm = new SqlCommon();
            SqlDataReader reader = sqlcomm.ExecuteReader(strSql, new SqlParameter("@className", className));
            if (reader.Read())
            {
                c = new Classes(className);
                c._director = reader["Director"].ToString();
                c._currentCount = (Int32.Parse(reader["CurrentCount"].ToString()));
                c._entranceDate = (DateTime)reader["EntranceDate"];
                c._remark = reader["Remark"].ToString();
            }
            reader.Close();
            return c;
        }

        //�õ����а༶��
        public static DataTable GetAllClassName()
        {
            string strSql = "select ClassName from Class";
            SqlCommon sqlcomm = new SqlCommon();
            DataSet ds = sqlcomm.CreaDataSet(strSql, null);
            return ds.Tables[0];
        }

        //�½��༶
        public static int CreateClass(string className, string director, DateTime entranceDate, string remark)
        {
            string strSql = "insert into Class(ClassName,Director,EntranceDate,Remark) values(@className,@director,@entranceDate,@remark);";
            SqlCommon sqlcomm = new SqlCommon();
            SqlParameter[] pa = new SqlParameter[4];
            pa[0] = new SqlParameter("@ClassName", className);
            pa[1] = new SqlParameter("@Director", director);
            pa[2] = new SqlParameter("@EntranceDate", entranceDate);
            pa[3] = new SqlParameter("@Remark", remark);
            return sqlcomm.ExecuteNonQuery(strSql, pa);
        }

        //���°༶
        public int Update()
        {
            string strSql = "update Class set [Director] = @director,[EntranceDate] = @entranceDate,[Remark] = @remark where [ClassName] = @className";
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.ExecuteNonQuery(strSql, new SqlParameter("@Director", this._director), new SqlParameter("@EntranceDate", this._entranceDate), new SqlParameter("@Remark", this._remark),new SqlParameter("@className",_className));
        }

        //ɾ���༶
        public int Delete()
        {
            //ɾ���༶��ͬʱɾ���ð�����ѧ����¼���γ̼�¼���ɼ���¼
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Score where [StudentNo] in (Select [StudentNo] from Student where [ClassName] = @className) ;");
            strSql.Append("delete from Course where [ClassName] = @className ;");
            strSql.Append("delete from Student where [ClassName] = @className ;");
            strSql.Append("delete from Class where [ClassName] = @className ;");
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.ExecuteNonQuery(strSql.ToString(),true,false, new SqlParameter("@className", _className));
        }

        //����Ƿ��а�
        public static SqlDataReader IsClassExists()
        {
            string strSql = "select * from Class ";
            SqlCommon sqlcomm = new SqlCommon();
            SqlDataReader reader = sqlcomm.ExecuteReader(strSql, null);
            return reader;
        }

        //����Ƿ��а�
        public SqlDataReader IsStudentExists()
        {
            string strSql = "select * from Class where [ClassName] = @className and [CurrentCount] > 0 ";
            SqlCommon sqlcomm = new SqlCommon();
            SqlDataReader reader = sqlcomm.ExecuteReader(strSql,new SqlParameter("@className",_className));
            return reader;
        }

        //���༶���Ƿ��Ѵ���
        public static SqlDataReader CheckExists(string className)
        {
            string strSql = "select * from Class where [className] = @className";
            SqlCommon sqlcomm = new SqlCommon();
            SqlDataReader reader = sqlcomm.ExecuteReader(strSql, new SqlParameter("@className", className));
            return reader;
        }

        //�õ����а༶�ļ�¼
        public static DataSet FillByAllClass()
        {
            string strSql = "select * from Class";
            SqlCommon sqlcomm = new SqlCommon();
            DataSet ds = sqlcomm.CreaDataSet(strSql, null);
            return ds;
        }

        //��ȡ�༶����ѧ���ļ���
        public DataSet FillByAllStudent()
        {
            string strSql = "select StudentNo,StudentName,Gender,Birthday,Picture,Remark from Student where [ClassName] = @className";
            SqlCommon sqlcomm = new SqlCommon();
            DataSet ds = sqlcomm.CreaDataSet(strSql, new SqlParameter("@className", _className));
            return ds;
        }

        public DataTable GetAllStudentNo()
        {
            string strSql = "select StudentNo from Student where [ClassName] = @className";
            SqlCommon sqlcomm = new SqlCommon();
            DataSet ds = sqlcomm.CreaDataSet(strSql, new SqlParameter("@className", _className));
            return ds.Tables[0];
        }

        //�õ�ָ���༶���пγ���Ϣ�ļ�¼
        public DataSet FillByAllCourse()
        {
            string strSql = "select SubjectName,Teacher,BeginDate,FinishDate,Remark from Course where [ClassName] = @className";
            SqlCommon sqlcomm = new SqlCommon();
            DataSet ds = sqlcomm.CreaDataSet(strSql,new SqlParameter("@className",_className));
            return ds;
        }

        //�õ�ָ���༶���пγ����Ƶļ�¼
        public DataSet FillByAllSubjectName()
        {
            string strSql = "select SubjectName from Course where [ClassName] = @className";
            SqlCommon sqlcomm = new SqlCommon();
            DataSet ds = sqlcomm.CreaDataSet(strSql,new SqlParameter("@className",_className));
            return ds;
        }

        //�жϸð��Ƿ��Ѵ�����Ӧ�γ�
        public SqlDataReader GetDataReaderBySubjectName(string subjectName)
        {
            string strSql = "select * from Course where [ClassName] = @className and [SubjectName] = @subjectName ";
            SqlCommon sqlcomm = new SqlCommon();
            SqlDataReader reader = sqlcomm.ExecuteReader(strSql, new SqlParameter("@className", _className), new SqlParameter("@subjectName", subjectName));
            return reader;
        }

    }
}
