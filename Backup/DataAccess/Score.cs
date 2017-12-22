using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
   public class Score
    {
        private int _studentNo;
        private int _courseID;
        private double _scoreCount;

        #region attribute

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

        public int CourseID
        {
            get
            {
                return _courseID;
            }
            set
            {
                _courseID = value;
            }
        }

        public double ScoreCount
        {
            get
            {
                return _scoreCount;
            }
            set
            {
                _scoreCount = value;
            }
        }

        #endregion

        public Score(int studentNo, int courseID)
        {
            _studentNo = studentNo;
            _courseID = courseID;
        }

        //添加分数
        public static int Add(int studentNo, int courseID, double score)
        {
            string strSql = "insert into Score values(@studentNo,@courseID,@score)";
            SqlCommon sqlcomm = new SqlCommon();
            SqlParameter[] paras = new SqlParameter[3];
            paras[0] = new SqlParameter("@studentNo", studentNo);
            paras[1] = new SqlParameter("@courseID", courseID);
            paras[2] = new SqlParameter("@score", score);
            return sqlcomm.ExecuteNonQuery(strSql, paras);
        }

        //修改分数
        public int Update()
        {
            string strSql = "update Score set [Score] = @score where [StudentNo] = @studentNo and [CourseID] = @courseID";
            SqlCommon sqlcomm = new SqlCommon();
            SqlParameter[] paras = new SqlParameter[3];
            paras[0] = new SqlParameter("@studentNo", _studentNo);
            paras[1] = new SqlParameter("@courseID", _courseID);
            paras[2] = new SqlParameter("@score", _scoreCount);
            return sqlcomm.ExecuteNonQuery(strSql, paras);
        }

        //删除分数
        public int Delete()
        {
            string strSql = "delete from Score where [StudentNo] = @studentNo and CourseID = @courseID";
            SqlCommon sqlcomm = new SqlCommon();
            return sqlcomm.ExecuteNonQuery(strSql, new SqlParameter("@studentNo", _studentNo), new SqlParameter("@courseID", _courseID));
        }

        //得到该班所有学生的成绩
        public static DataSet FillByAllScoreInfo(string className)
        {
            string strSql = "select * from ScoreView where StudentNo in (select StudentNo from Student where ClassName = @className)";
            SqlCommon sqlcomm = new SqlCommon();
            DataSet ds = sqlcomm.CreaDataSet(strSql, new SqlParameter("@className",className));
            return ds;
        }

       //判断该学生是否已存在相应课程成绩
       public static SqlDataReader GetReader(int studentNo, int courseID)
       {
           string strSql = "select * from Score where [StudentNo] = @studentNo and [CourseID] = @courseID";
           SqlCommon  sqlcomm = new SqlCommon();
           SqlDataReader reader = sqlcomm.ExecuteReader(strSql, new SqlParameter("@studentNo", studentNo), new SqlParameter("@courseID", courseID));
           return reader;
       }
    }
}
