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

        //实例化班级
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

        //得到所有班级名
        public static DataTable GetAllClassName()
        {
            string strSql = "select ClassName from Class";
            SqlCommon sqlcomm = new SqlCommon();
            DataSet ds = sqlcomm.CreaDataSet(strSql, null);
            return ds.Tables[0];
        }

        //新建班级
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

        //更新班级
        public int Update()
        {
            string strSql = "update Class set [Director] = @director,[EntranceDate] = @entranceDate,[Remark] = @remark where [ClassName] = @className";
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.ExecuteNonQuery(strSql, new SqlParameter("@Director", this._director), new SqlParameter("@EntranceDate", this._entranceDate), new SqlParameter("@Remark", this._remark),new SqlParameter("@className",_className));
        }

        //删除班级
        public int Delete()
        {
            //删除班级的同时删除该班所有学生记录、课程记录、成绩记录
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Score where [StudentNo] in (Select [StudentNo] from Student where [ClassName] = @className) ;");
            strSql.Append("delete from Course where [ClassName] = @className ;");
            strSql.Append("delete from Student where [ClassName] = @className ;");
            strSql.Append("delete from Class where [ClassName] = @className ;");
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.ExecuteNonQuery(strSql.ToString(),true,false, new SqlParameter("@className", _className));
        }

        //检查是否有班
        public static SqlDataReader IsClassExists()
        {
            string strSql = "select * from Class ";
            SqlCommon sqlcomm = new SqlCommon();
            SqlDataReader reader = sqlcomm.ExecuteReader(strSql, null);
            return reader;
        }

        //检查是否有班
        public SqlDataReader IsStudentExists()
        {
            string strSql = "select * from Class where [ClassName] = @className and [CurrentCount] > 0 ";
            SqlCommon sqlcomm = new SqlCommon();
            SqlDataReader reader = sqlcomm.ExecuteReader(strSql,new SqlParameter("@className",_className));
            return reader;
        }

        //检查班级名是否已存在
        public static SqlDataReader CheckExists(string className)
        {
            string strSql = "select * from Class where [className] = @className";
            SqlCommon sqlcomm = new SqlCommon();
            SqlDataReader reader = sqlcomm.ExecuteReader(strSql, new SqlParameter("@className", className));
            return reader;
        }

        //得到所有班级的记录
        public static DataSet FillByAllClass()
        {
            string strSql = "select * from Class";
            SqlCommon sqlcomm = new SqlCommon();
            DataSet ds = sqlcomm.CreaDataSet(strSql, null);
            return ds;
        }

        //获取班级所有学生的集合
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

        //得到指定班级所有课程信息的记录
        public DataSet FillByAllCourse()
        {
            string strSql = "select SubjectName,Teacher,BeginDate,FinishDate,Remark from Course where [ClassName] = @className";
            SqlCommon sqlcomm = new SqlCommon();
            DataSet ds = sqlcomm.CreaDataSet(strSql,new SqlParameter("@className",_className));
            return ds;
        }

        //得到指定班级所有课程名称的记录
        public DataSet FillByAllSubjectName()
        {
            string strSql = "select SubjectName from Course where [ClassName] = @className";
            SqlCommon sqlcomm = new SqlCommon();
            DataSet ds = sqlcomm.CreaDataSet(strSql,new SqlParameter("@className",_className));
            return ds;
        }

        //判断该班是否已存在相应课程
        public SqlDataReader GetDataReaderBySubjectName(string subjectName)
        {
            string strSql = "select * from Course where [ClassName] = @className and [SubjectName] = @subjectName ";
            SqlCommon sqlcomm = new SqlCommon();
            SqlDataReader reader = sqlcomm.ExecuteReader(strSql, new SqlParameter("@className", _className), new SqlParameter("@subjectName", subjectName));
            return reader;
        }

    }
}
