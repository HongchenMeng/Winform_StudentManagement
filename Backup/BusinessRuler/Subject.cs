using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace BusinessRuler
{
    public class Subject
    {
        private DataGridView _dgvSubject;
        public Subject(DataGridView dgv)
        {
            _dgvSubject = dgv;
        }

        //更新FrmStudent中数据网格的显示
        public void UpdateDataGrid()
        {
            DataSet objDataSet = DataAccess.Subject.FillByAllSubject();
            this._dgvSubject.DataSource = objDataSet.Tables[0];
        }

        //填充组合框，然后将要修改的科目名称设为选择状态
        public static void FillCboByAllSubjectName(ComboBox cbo,string currentSubjectName)
        {
            DataTable objSubjectNameList = DataAccess.Subject.FillByAllSubjectName().Tables[0];
            cbo.Items.Clear();
            int position = 0;
            foreach (DataRow objRow in objSubjectNameList.Rows)
            {
                cbo.Items.Add(objRow["SubjectName"].ToString());
                if (objRow["SubjectName"].ToString().Equals(currentSubjectName))
                {
                    cbo.SelectedIndex = position;
                }
                else
                {
                    position++;
                }
            }
        }

        //填充组合框，然后将要修改的科目名称设为选择状态（修改成绩使用）
        public static void FillCboByCurrentSubjectName(DataGridView dgvSubject,ComboBox cbo, string StudentName)
        {
            DataTable objTable = dgvSubject.DataSource as DataTable;
            string currentSubjectName = dgvSubject.CurrentRow.Cells["SubjectName"].Value.ToString();
            cbo.Items.Clear();
            int position = 0;
            int i = 0;
            foreach (DataRow objRow in objTable.Rows)
            {
                if (objRow["StudentName"].ToString().Equals(StudentName))
                {
                    string subjectName = objRow["SubjectName"].ToString();
                    cbo.Items.Add(subjectName);
                    if (subjectName.Equals(currentSubjectName))
                    {
                        position = i;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            cbo.SelectedIndex = position;
        }

        //验证科目是否已存在
        public bool CheckExist(string subjectName)
        {
            if (DataAccess.Subject.GetReaderBySubjectName(subjectName).HasRows)
            {
                return true;
            }
            return false;
        }

        //添加科目
        public void Add(string subjectName, int period, string remark)
        {
            //首先科目名称是否已存在
            if (CheckExist(subjectName))
            {
                MessageBox.Show("科目" + subjectName + "已存在，请重新输入科目名！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DataAccess.Subject.Add(subjectName, period, remark) > 0)
                {
                    UpdateDataGrid();
                    MessageBox.Show("成功添加科目！", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("添加操作失败！", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
            }
        }

        //修改科目
        public void Update(string subjectName, int period, string remark)
        {
            DataAccess.Subject objSubject = new DataAccess.Subject(subjectName);
            objSubject.Period = period;
            objSubject.Remark = remark;
            if (objSubject.Update() > 0)
            {
                UpdateDataGrid();
                MessageBox.Show("修改科目资料成功！", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("更新科目操作失败，请重试！", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        //删除科目
        public void Delete()
        {
            string subjectName = this._dgvSubject.CurrentRow.Cells["SubjectName"].Value.ToString();
            DialogResult result = MessageBox.Show("真的要删除科目' " + subjectName + " '吗?", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                DataAccess.Subject objSubject = new DataAccess.Subject(subjectName);
                if (objSubject.Delete() > 0 )
                {
                    UpdateDataGrid();
                    MessageBox.Show("成功删除科目' " + subjectName + " '!", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("删除操作失败，请重试！", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
            }
        }

        //按科目名称查找
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

    }
}
