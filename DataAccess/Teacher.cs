using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class Teacher
    {
        private string _teacherName;
        private string _gender;
        private DateTime _birthday;
        private string _idCard;
        private string _university;
        private string _specialfield;
        private string _diploma;
        private string _picture;
        private string _remark;

        #region attribute

        public string TeacherName
        {
            get
            {
                return _teacherName;
            }
        }

        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                _birthday = value;
            }
        }

        public string IDCard
        {
            get
            {
                return _idCard;
            }
            set
            {
                _idCard = value;
            }
        }

        public string University
        {
            get
            {
                return _university;
            }
            set
            {
                _university = value;
            }
        }

        public string Specialfield
        {
            get
            {
                return _specialfield;
            }
            set
            {
                _specialfield = value;
            }
        }

        public string Diploma
        {
            get
            {
                return _diploma;
            }
            set
            {
                _diploma = value;
            }
        }

        public string Picture
        {
            get
            {
                return _picture;
            }
            set
            {
                _picture = value;
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
        public Teacher(string teacherName)
        {
            _teacherName = teacherName;
        }

        //获取所有教师名称的集合
        public static DataSet FillByAllTeacherName()
        {
            string strSql = "select TeacherName from Teacher";
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.CreaDataSet(strSql, null);
        }

        //获取所有教师的集合
        public static DataSet FillByAllTeacher()
        {
            string strSql = "select TeacherName,Gender,Birthday,IDCard,University,Specialfield,Diploma,Picture,Remark from Teacher";
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.CreaDataSet(strSql, null);
        }

        //判断教师是否已存在
        public static SqlDataReader GetReaderByTeacherName(string teacherName)
        {
            string strSql = "select TeacherName from Teacher where [TeacherName] = @teacherName";
            SqlCommon sqlcomm = new SqlCommon();
            SqlDataReader reader = sqlcomm.ExecuteReader(strSql,new SqlParameter("@teacherName",teacherName));
            return reader;
        }

        //添加学生
        public static int AddTeacher(string teacherName, string gender, DateTime birthday, string idCard, string university, string specialfield, string diploma, string picturePath, string remark)
        {
            string strSql = "insert into Teacher values(@teacherName,@gender,@birthday,@idCard,@university,@specialfield,@diploma,@picturePath,@remark)";
            SqlCommon sqlcomm = new SqlCommon();
            SqlParameter[] paras = new SqlParameter[9];
            paras[0] = new SqlParameter("@teacherName", teacherName);
            paras[1] = new SqlParameter("@gender", gender);
            paras[2] = new SqlParameter("@birthday", birthday);
            paras[3] = new SqlParameter("@idCard", idCard);
            paras[4] = new SqlParameter("@university", university);
            paras[5] = new SqlParameter("@specialfield", specialfield);
            paras[6] = new SqlParameter("@diploma", diploma);
            paras[7] = new SqlParameter("@picturePath", picturePath);
            paras[8] = new SqlParameter("@remark", remark);
            return sqlcomm.ExecuteNonQuery(strSql, paras);
        }

        //修改老师资料
        public int Update()
        {
            string strSql = "update Teacher set Gender =@gender,Birthday = @birthday,IDCard = @idCard,University =@university,Specialfield = @specialfield,Diploma = @diploma ,Picture = @picturePath,Remark = @remark where TeacherName = @teacherName";
            SqlCommon sqlcomm = new SqlCommon();
            SqlParameter[] paras = new SqlParameter[9];
            paras[0] = new SqlParameter("@teacherName", _teacherName);
            paras[1] = new SqlParameter("@gender", _gender);
            paras[2] = new SqlParameter("@birthday", _birthday);
            paras[3] = new SqlParameter("@idCard", _idCard);
            paras[4] = new SqlParameter("@university", _university);
            paras[5] = new SqlParameter("@specialfield", _specialfield);
            paras[6] = new SqlParameter("@diploma", _diploma);
            paras[7] = new SqlParameter("@picturePath", _picture);
            paras[8] = new SqlParameter("@remark", _remark);
            return sqlcomm.ExecuteNonQuery(strSql, paras);
        }

        //删除教师
        public int Delete()
        {
            //删除教师的同时将同时删除你相应的课程以及相应课程成绩的信息
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Score where [CourseID] in (select CourseID from Course where [Teacher] = @teacherName);");
            strSql.Append("delete from Course where [Teacher] = @teacherName ;");
            strSql.Append("delete from Teacher where [TeacherName] = @teacherName ;");
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.ExecuteNonQuery(strSql.ToString(),true,false,new SqlParameter("@teacherName",_teacherName));
        }

        public static Teacher CreateInstance(string teacherName)
        {
            DataAccess.Teacher objTeacher = null;
            string strSql = "select * from Teacher where [TeacherName] = @teacherName ";
            SqlCommon sqlcomm = new SqlCommon();
            SqlDataReader reader = sqlcomm.ExecuteReader(strSql, new SqlParameter("@teacherName", teacherName));
            if (reader.Read())
            {
                objTeacher = new DataAccess.Teacher(teacherName);
                objTeacher.Gender = reader["Gender"].ToString();
                objTeacher.Birthday = DateTime.Parse(reader["Birthday"].ToString());
                objTeacher.IDCard = reader["IDCard"].ToString();
                objTeacher.University = reader["University"].ToString();
                objTeacher.Diploma = reader["Diploma"].ToString();
                objTeacher.Picture = reader["Picture"].ToString();
                objTeacher.Remark = reader["Remark"].ToString();
            }
            reader.Close();
            return objTeacher;
        }

    }
}
