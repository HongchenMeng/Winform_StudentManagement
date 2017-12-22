using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccess
{
    public class Student
    {
        private int _studentNo;
        private string _studentName;
        private string _gender;
        private DateTime _birthday;
        private string _className;
        private string _picture;
        private string _remark;

        #region

        public int StudentNo
        {
            get
            {
                return _studentNo;
            }
            set
            {
                _studentNo = value;
            }
        }

        public string StudentName
        {
            get
            {
                return _studentName;
            }
            set
            {
                _studentName = value;
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

        public string ClassName
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

        public Student()
        {
 
        }

        public Student(int studentNo)
        {
            _studentNo = studentNo;
        }

        //通过姓名及班级名称得到StudentNo
        public static int GetStudentNo(string className, string studentName)
        {
            string strSql = "select StudentNo from Student where [ClassName] = @className and [StudentName] = @studentName";
            SqlCommon sqlcomm = new SqlCommon();
            SqlDataReader reader = sqlcomm.ExecuteReader(strSql, new SqlParameter("@className", className), new SqlParameter("@studentName", studentName));
            reader.Read();
            return Int32.Parse(reader["StudentNo"].ToString());
        }

        public static Student CreateInstance(int studentNo)
        {
            Student s = null;
            string strSql = "select * from Student where [StudentNo] = @studentNo ";
            SqlCommon sqlcomm = new SqlCommon();
            SqlDataReader reader = sqlcomm.ExecuteReader(strSql, new SqlParameter("@studentNo", studentNo));
            if (reader.Read())
            {
                s = new Student(studentNo);
                s._studentName = reader["StudentName"].ToString();
                s._gender = reader["Gender"].ToString();
                s._birthday = DateTime.Parse(reader["Birthday"].ToString());
                s._className = reader["ClassName"].ToString();
                s._picture = reader["Picture"].ToString();
                s._remark = reader["Remark"].ToString();
            }
            reader.Close();
            return s;
        }

        //判断学号是否已存在
        public static SqlDataReader CheckExist(int studentNo)
        {
            string strSql = "select * from Student where [StudentNo] = @studentNo";
            SqlCommon sqlcomm = new SqlCommon();
            SqlDataReader reader = sqlcomm.ExecuteReader(strSql, new SqlParameter("@studentNo", studentNo));
            return reader;
        }

        //添加学生
        public static int CreateStudent(int studentNo, string studentName, string gender, DateTime birthday,string className, string imagePath, string remark)
        {
            string strSql = "insert into Student values(@studentNo,@studentName,@gender,@birthday,@className,@picture,@remark);";
            strSql += "update Class set [currentCount] = [currentCount]+1 where [ClassName] = @className";
            SqlCommon sqlcomm = new SqlCommon();
            SqlParameter[] pa = new SqlParameter[7];
            pa[0] = new SqlParameter("@studentNo", studentNo);
            pa[1] = new SqlParameter("@studentName", studentName);
            pa[2] = new SqlParameter("@gender", gender);
            pa[3] = new SqlParameter("@birthday", birthday);
            pa[4] = new SqlParameter("@className", className);
            pa[5] = new SqlParameter("@picture", imagePath);
            pa[6] = new SqlParameter("@remark", remark);
            return sqlcomm.ExecuteNonQuery(strSql, pa);
        }

        //修改学生资料（不修改学生所在班级）
        public int Update()
        {
            string strSql = "update Student set [StudentName] = @studentName,[Gender] = @gender,[Birthday] = @birthday,[ClassName] = @className,[Picture] = @picture,[Remark] = @remark where [StudentNo] = @studentNo;";
            strSql += "Update Class set [CurrentCount] = [CurrentCount] + 1 where [ClassName] = @className ";
            SqlCommon sqlcomm = new SqlCommon();
            SqlParameter[] pa = new SqlParameter[7];
            pa[0] = new SqlParameter("@studentNo", _studentNo);
            pa[1] = new SqlParameter("@studentName", _studentName);
            pa[2] = new SqlParameter("@gender", _gender);
            pa[3] = new SqlParameter("@birthday", _birthday);
            pa[4] = new SqlParameter("@className", _className);
            pa[5] = new SqlParameter("@picture", _picture);
            pa[6] = new SqlParameter("@remark", _remark);
            return sqlcomm.ExecuteNonQuery(strSql,true,false,pa);
        }

        //修改学生资料（修改学生所在班级）
        public int Update(string oldClassName)
        {
            StringBuilder str = new StringBuilder();
            str.Append("update Student set [StudentName] = @studentName,[Gender] = @gender,[Birthday] = @birthday,[ClassName] = @className,[Picture] = @picture,[Remark] = @remark where [StudentNo] = @studentNo;");
            str.Append("Update Class set [CurrentCount] = [CurrentCount] - 1 where ClassName = @oldClassName ;");
            str.Append("Update Class set [CurrentCount] = [CurrentCount] + 1 where ClassName = @className ");
            SqlCommon sqlcomm = new SqlCommon();
            SqlParameter[] pa = new SqlParameter[8];
            pa[0] = new SqlParameter("@studentNo", _studentNo);
            pa[1] = new SqlParameter("@studentName", _studentName);
            pa[2] = new SqlParameter("@gender", _gender);
            pa[3] = new SqlParameter("@birthday", _birthday);
            pa[4] = new SqlParameter("@className", _className);
            pa[5] = new SqlParameter("@picture", _picture);
            pa[6] = new SqlParameter("@remark", _remark);
            pa[7] = new SqlParameter("@oldClassName", oldClassName);
            return sqlcomm.ExecuteNonQuery(str.ToString(), true, false, pa);
        }

        public int Delete()
        {
            //删除学生资料时，同时删除该生成绩
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Score where [StudentNo] = @studentNo ;");
            strSql.Append("delete from Student where [StudentNo] = @studentNo;");
            strSql.Append("update Class set [currentCount] = [currentCount]-1 where [ClassName] = @className ;");
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.ExecuteNonQuery(strSql.ToString(),true,false,new SqlParameter("@studentNo",_studentNo),new SqlParameter("@className",_className));
        }

        //获取所有学生姓名的集合
        public static DataSet FillByAllStudentName(string className)
        {
            string strSql = "select StudentName from Student where [ClassName] = @className";
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.CreaDataSet(strSql, new SqlParameter("@className",className));
        }
        
    }
}
