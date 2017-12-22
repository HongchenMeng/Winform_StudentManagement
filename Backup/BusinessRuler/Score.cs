using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace BusinessRuler
{
    public class Score
    {
        private DataGridView _dgvScore;
        private string _className;

        public Score(DataGridView dgv,string className)
        {
            _dgvScore = dgv;
            _className = className;
        }

        public void UpdateDataGrid()
        {
            DataSet objDataSet = DataAccess.Score.FillByAllScoreInfo(_className);
            this._dgvScore.DataSource = objDataSet.Tables[0];
        }


        //添加课程
        public void Add(string studentName,string subjectName,double scoreCount)
        {
            int studentNo = DataAccess.Student.GetStudentNo(_className, studentName);
            DataAccess.Course objCourse = new DataAccess.Course(_className,subjectName);
            int courseID = objCourse.GetCourseID();
            if (DataAccess.Score.GetReader(studentNo,courseID).HasRows)
            {
                MessageBox.Show("该生 " + subjectName + " 课成绩已存在！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DataAccess.Score.Add(studentNo,courseID,scoreCount) > 0 )
                {
                    UpdateDataGrid();
                    MessageBox.Show("成功添加成绩！", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("添加成绩失败！", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //修改课程
        public void Update(string studentName,string subjectName, double scoreCount)
        {
            int studentNo = DataAccess.Student.GetStudentNo(_className, studentName);
            DataAccess.Course objCourse = new DataAccess.Course(_className, subjectName);
            int courseID = objCourse.GetCourseID();
            DataAccess.Score objScore = new DataAccess.Score(studentNo, courseID);
            objScore.ScoreCount = scoreCount;
            if (objScore.Update() > 0)
            {
                UpdateDataGrid();
                MessageBox.Show("修改成绩成功！", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("更新成绩失败！", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //删除课程
        public void Delete()
        {
            int studentNo = Int32.Parse(this._dgvScore.CurrentRow.Cells["StudentNo"].Value.ToString());
            string subjectName = this._dgvScore.CurrentRow.Cells["SubjectName"].Value.ToString();
            DataAccess.Course objCourse = new DataAccess.Course(_className, subjectName);
            int courseID = objCourse.GetCourseID();
            DialogResult result = MessageBox.Show("真的要删除吗?", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataAccess.Score objScore = new DataAccess.Score(studentNo, courseID);
                if (objScore.Delete() > 0)
                {
                    UpdateDataGrid();
                    MessageBox.Show("成功删除成绩!", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("删除操作失败!", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //按学号查找
        public static void FindByStudentNo(DataGridView dgv, int studentNo, bool useMatch)
        {
            for (int row = Int32.Parse(dgv.Tag.ToString()); row < dgv.Rows.Count; row++)
            {
                bool condition = Int32.Parse(dgv.Rows[row].Cells["StudentNo"].Value.ToString()) == studentNo;
                if (useMatch)
                {
                    condition = dgv.Rows[row].Cells["StudentNo"].Value.ToString().Contains(studentNo.ToString());
                }
                if (condition)
                {
                    dgv.Rows[row].Selected = true;
                    dgv.Tag = (row + 1).ToString();
                    return;
                }
            }
            MessageBox.Show("已到记录末尾！", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv.Tag = 0;
        }

        //按学生姓名查找
        public static void FindByStudentName(DataGridView dgv, string studentName, bool useMatch)
        {
            for (int row = Int32.Parse(dgv.Tag.ToString()); row < dgv.Rows.Count; row++)
            {
                bool condition = dgv.Rows[row].Cells["StudentName"].Value.ToString().Equals(studentName);
                if (useMatch)
                {
                    condition = dgv.Rows[row].Cells["StudentName"].Value.ToString().Contains(studentName);
                }
                if (condition)
                {
                    dgv.Rows[row].Selected = true;
                    dgv.Tag = (row + 1).ToString();
                    return;
                }
            }
            MessageBox.Show("已到记录末尾！", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv.Tag = 0;
        }

    }
}
