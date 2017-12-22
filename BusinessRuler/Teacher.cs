using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace BusinessRuler
{
    public class Teacher
    {
        private DataGridView _dgvTeacher;

        public Teacher(DataGridView dgv)
        {
            _dgvTeacher = dgv;
        }

        public Teacher()
        {
 
        }

        //更新数据网格的显示
        public void UpdateDataGrid()
        {
            DataSet objDataSet = DataAccess.Teacher.FillByAllTeacher();
            this._dgvTeacher.DataSource = objDataSet.Tables[0];
        }

        //验证学号是否已存在
        public bool CheckTeacherExist(string teacherName)
        {
            if (DataAccess.Teacher.GetReaderByTeacherName(teacherName).HasRows)
            {
                MessageBox.Show("教师 " + teacherName + " 已经存在，请重新输入！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        //插入教师资料
        public void Add(string teacherName, string gender, DateTime birthday, string idCard, string university, string specialfield, string diploma, string imagePath, string remark)
        {
            string newFileName = imagePath;
            if (imagePath.Trim().Length > 0)
            {
                newFileName = teacherName.ToString() + new FileInfo(imagePath).Extension;
            } 
            //首先判断教师是否已存在
            if (!CheckTeacherExist(teacherName))
            {
                if (DataAccess.Teacher.AddTeacher(teacherName, gender, birthday, idCard, university, specialfield, diploma, newFileName, remark) > 0)
                {
                    UpdateDataGrid();
                    //复制图片
                    if (imagePath.Trim().Length > 0)
                    {
                        BusinessRuler.ImageManage.CopyImageFileToServer(imagePath, newFileName);
                    }
                    MessageBox.Show("添加教师资料成功！", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("添加教师资料失败，请重试！", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //修改教师资料
        public void Update(string teacherName, string gender, DateTime birthday, string idCard, string university, string specialfield, string diploma, string imagePath, string remark)
        {
            string newFileName = imagePath;
            if (imagePath.Trim().Length > 0)
            {
                newFileName = teacherName.ToString() + new FileInfo(imagePath).Extension;
            }

            DataAccess.Teacher objTeacher = new DataAccess.Teacher(teacherName);
            objTeacher.Gender = gender;
            objTeacher.Birthday = birthday;
            objTeacher.IDCard = idCard;
            objTeacher.University = university;
            objTeacher.Specialfield = specialfield;
            objTeacher.Diploma = diploma;
            objTeacher.Picture = newFileName;
            objTeacher.Remark = remark;
            if (objTeacher.Update() > 0)
            {
                UpdateDataGrid();
                //更新图片
                if (imagePath.Trim().Length > 0)
                {
                    BusinessRuler.ImageManage.UpdateImageFile(imagePath, newFileName);
                }
                MessageBox.Show("修改教师资料成功！", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("更新教师资料失败，请重试！", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //删除教师
        public void Delete()
        {
            string teacherName = this._dgvTeacher.CurrentRow.Cells["TeacherName"].Value.ToString();
            DialogResult result = MessageBox.Show("真的要删除教师' " + teacherName + " '吗?\n删除教师资料，将级联删除该教师所授课程记录以及相应课程的成绩记录，确定要继续吗？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( result == DialogResult.Yes)
            {
                DataAccess.Teacher objTeacher = new DataAccess.Teacher(teacherName);
                if (objTeacher.Delete() > 0 )
                {
                    UpdateDataGrid();
                    MessageBox.Show("成功删除教师资料!' " + teacherName + " '!", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("删除操作失败，请重试!", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static void FillCboByAllTeacherName(ComboBox cbo, string teacherName)
        {
            cbo.Items.Clear();
            int position = 0;
            int i = 0;
            DataTable teacherNames = DataAccess.Teacher.FillByAllTeacherName().Tables[0];
            foreach (DataRow row in teacherNames.Rows)
            {
                cbo.Items.Add(row[0].ToString());
                if (row[0].ToString().Equals(teacherName))
                {
                    position = i;
                }
                i++;
            }
            cbo.SelectedIndex = position;
        }

        //按科目查找老师
        public static void FindByTeacherName(DataGridView dgv, string teacherName, bool useMatch)
        {
            for (int row = Int32.Parse(dgv.Tag.ToString()); row < dgv.Rows.Count; row++)
            {
                bool condition = dgv.Rows[row].Cells["TeacherName"].Value.ToString().Equals(teacherName);
                if (useMatch)
                {
                    condition = dgv.Rows[row].Cells["TeacherName"].Value.ToString().Contains(teacherName);
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

        //按身份证号查找老师
        public static void FindByCardID(DataGridView dgv, string cardID, bool useMatch)
        {
            for (int row = Int32.Parse(dgv.Tag.ToString()); row < dgv.Rows.Count; row++)
            {
                bool condition = dgv.Rows[row].Cells["IDCard"].Value.ToString().Equals(cardID);
                if (useMatch)
                {
                    condition = dgv.Rows[row].Cells["IDCard"].Value.ToString().Contains(cardID);
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
