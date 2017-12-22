using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class Course
    {
        private int _courseID;
        private string _className;
        private string _subjectName;
        private string _teacher;
        private DateTime _beginDate;
        private DateTime _finishDate;
        private string _remark;

        #region attribute

        public int CourseID
        {
            get
            {
                return _courseID;
            }
        }

        public string ClassName
        {
            get
            {
                return _className;
            }
        }

        public string SubjectName
        {
            get
            {
                return _subjectName;
            }
        }

        public string Teacher
        {
            get
            {
                return _teacher;
            }
            set
            {
                _teacher = value;
            }
        }

        public DateTime BeginDate
        {
            get
            {
                return _beginDate;
            }
            set
            {
                _beginDate = value;
            }
        }

        public DateTime FinishDate
        {
            get
            {
                return _finishDate;
            }
            set
            {
                _finishDate = value;
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

        public Course(string className, string subjectName)
        {
            _className = className;
            _subjectName = subjectName;
        }

        public static Course CreateInstance(string className, string subjectName)
        {
            string strSql = "select * from Course where [ClassName] = @className and [SubjectName]= @subjectName";
            SqlCommon sqlcomm = new SqlCommon();
            SqlDataReader reader = sqlcomm.ExecuteReader(strSql, new SqlParameter("@className", className), new SqlParameter("@subjectName", subjectName));
            Course objCourse = new Course(className, subjectName);
            reader.Read();
            objCourse.Teacher = reader["Teacher"].ToString();
            objCourse.BeginDate = DateTime.Parse(reader["BeginDate"].ToString());
            objCourse.FinishDate = DateTime.Parse(reader["FinishDate"].ToString());
            objCourse.Remark = reader["Remark"].ToString();
            return objCourse;
        }

        //通过课程名及班级名称得到CourseID
        public int GetCourseID()
        {
            string strSql = "select CourseID from Course where [ClassName] = @className and [SubjectName] = @subjectName";
            SqlCommon sqlcomm = new SqlCommon();
            SqlDataReader reader = sqlcomm.ExecuteReader(strSql, new SqlParameter("@className", _className), new SqlParameter("@subjectName", _subjectName));
            reader.Read();
            return Int32.Parse(reader["CourseID"].ToString());
        }

        //添加课程
        public static int Add(string className,string subjectName,string teacher, DateTime beginDate, DateTime finishDate, string remark)
        {
            string strSql = "insert into Course(className,subjectName,teacher,beginDate,finishDate,remark) values(@className,@subjectName,@teacher,@beginDate,@finishDate,@remark)";
            SqlCommon sqlcomm = new SqlCommon();
            SqlParameter[] paras = new SqlParameter[6];
            paras[0] = new SqlParameter("@className",className);
            paras[1] = new SqlParameter("@subjectName", subjectName);
            paras[2] = new SqlParameter("@teacher", teacher);
            paras[3] = new SqlParameter("@beginDate", beginDate);
            paras[4] = new SqlParameter("@finishDate", finishDate);
            paras[5] = new SqlParameter("@remark", remark);
            return sqlcomm.ExecuteNonQuery(strSql, paras);            
        }

        //修改课程
        public int Update()
        {
            string strSql = "update Course set Teacher = @teacher,[BeginDate] = @beginDate, [FinishDate] = @finishDate ,[Remark] = @remark where [ClassName] = @className and [SubjectName] = @subjectName";
            SqlCommon sqlcomm = new SqlCommon();
            SqlParameter[] paras = new SqlParameter[6];
            paras[0] = new SqlParameter("@teacher", _teacher);
            paras[1] = new SqlParameter("@beginDate", _beginDate);
            paras[2] = new SqlParameter("@finishDate", _finishDate);
            paras[3] = new SqlParameter("@Remark", _remark);
            paras[4] = new SqlParameter("@className", _className);
            paras[5] = new SqlParameter("@subjectName", _subjectName);
            return sqlcomm.ExecuteNonQuery(strSql, paras); 
        }

        //删除课程
        public int Delete()
        {
            int courseID = GetCourseID();
            //删除课程的同时将删除与其对应的所有成绩记录
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Score where [CourseID] = @courseID ;");
            strSql.Append("delete from Course where [CourseID] = @courseID;");
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.ExecuteNonQuery(strSql.ToString(),true,false,new SqlParameter("@courseID",courseID));
        }

        //得到所有科目名称
        public static DataSet FillByAllSubjectName(string className)
        {
            string strSql = "select SubjectName from Course where [ClassName] = @className";
            SqlCommon sqlcomm = new SqlCommon();
            DataSet ds = sqlcomm.CreaDataSet(strSql, new SqlParameter("@className",className));
            return ds;
        }

    }
}
