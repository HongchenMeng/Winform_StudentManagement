using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace BusinessRuler
{
    public class Course
    {
        private DataGridView _dgvCourse;
        private string _className;

        public Course(DataGridView dgr, string className)
        {
            _dgvCourse = dgr;
            _className = className;
        }

        //更新数据网格的显示
        public void UpdateDataGrid()
        {
            DataAccess.Classes objClass = new DataAccess.Classes(_className);
            DataSet objDataSet = objClass.FillByAllCourse();
            this._dgvCourse.DataSource = objDataSet.Tables[0];
        }

        //添加课程
        public void Add(string subjectName, string teacher, DateTime beginDate, DateTime finishDate, string remark)
        {
            DataAccess.Classes objClass = new DataAccess.Classes(_className);
            if (objClass.GetDataReaderBySubjectName(subjectName).HasRows)
            {
                MessageBox.Show("该班已有课程" + subjectName + "，请重新输入！", "课程已存在", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DataAccess.Course.Add(_className,subjectName,teacher,beginDate,finishDate,remark) > 0 )
                {
                    UpdateDataGrid();
                    MessageBox.Show("成功添加课程！", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("添加课程失败！", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //修改课程
        public void Update(string subjectName,string teacher, DateTime beginDate, DateTime finishDate, string remark)
        {
            DataAccess.Course objCourse = new DataAccess.Course(_className, subjectName);
            objCourse.Teacher = teacher;
            objCourse.BeginDate = beginDate;
            objCourse.FinishDate = finishDate;
            objCourse.Remark = remark;
            if (objCourse.Update() > 0)
            {
                UpdateDataGrid();
                MessageBox.Show("修改课程成功！", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("更新操作失败！", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //删除课程
        public void Delete()
        {
            string subjectName = this._dgvCourse.CurrentRow.Cells["SubjectName"].Value.ToString();
            if (DialogResult.Yes == MessageBox.Show("真的要删除课程' " + subjectName + " '吗?\n删除课程，将同时删除与该课程相关的所有成绩信息，要继续吗？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DataAccess.Course objCourse = new DataAccess.Course(_className, subjectName);
                if (objCourse.Delete() > 0 )
                {
                    UpdateDataGrid();
                    MessageBox.Show("成功删除课程" + subjectName + " '!", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("删除操作失败 " + subjectName + " '!", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static void FillCboByAllSubjectName(ComboBox cbo,string className,string subjectName)
        {
            cbo.Items.Clear();
            int position = 0;
            int i = 0;
            DataTable subjectNames = DataAccess.Course.FillByAllSubjectName(className).Tables[0];
            foreach (DataRow row in subjectNames.Rows)
            {
                cbo.Items.Add(row[0].ToString());
                if (row[0].ToString().Equals(subjectName))
                {
                    position = i;
                }
                i++;
            }
            cbo.SelectedIndex = position;
        }

        //按科目名称查找课程
        public static void FindBySubjectName(DataGridView dgv, string subjectName, bool useMatch)
        {
            for (int row = Int32.Parse(dgv.Tag.ToString()); row < dgv.Rows.Count; row++)
            {
                bool condition = dgv.Rows[row].Cells["SubjectName"].Value.ToString().Equals(subjectName);
                if (useMatch)
                {
                    condition = dgv.Rows[row].Cells["SubjectName"].Value.ToString().Contains(subjectName);
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

        //按老师查找课程
        public static void FindByTeacherName(DataGridView dgv, string teacherName, bool useMatch)
        {
            for (int row = Int32.Parse(dgv.Tag.ToString()); row < dgv.Rows.Count; row++)
            {
                bool condition = dgv.Rows[row].Cells["Teacher"].Value.ToString().Equals(teacherName);
                if (useMatch)
                {
                    condition = dgv.Rows[row].Cells["Teacher"].Value.ToString().Contains(teacherName);
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

        //按开课日期查找
        public static void FindByStartDate(DataGridView dgv, DateTime startDate, DateTime finishDate)
        {
            for (int row = Int32.Parse(dgv.Tag.ToString()); row < dgv.Rows.Count; row++)
            {
                DateTime dateValue = DateTime.Parse(dgv.Rows[row].Cells["BeginDate"].Value.ToString());
                if (dateValue >= startDate && dateValue <= finishDate)
                {
                    dgv.Rows[row].Selected = true;
                    dgv.Tag = (row + 1).ToString();
                    return;
                }
            }
            MessageBox.Show("已到记录末尾！", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv.Tag = 0;
        }

        //按结课日期查找
        public static void FindByFinishDate(DataGridView dgv, DateTime startDate, DateTime finishDate)
        {
            for (int row = Int32.Parse(dgv.Tag.ToString()); row < dgv.Rows.Count; row++)
            {
                DateTime dateValue = DateTime.Parse(dgv.Rows[row].Cells["FinishDate"].Value.ToString());
                if (dateValue >= startDate && dateValue <= finishDate)
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
