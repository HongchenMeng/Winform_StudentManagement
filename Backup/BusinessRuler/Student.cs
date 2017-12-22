using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Drawing;

namespace BusinessRuler
{
   public class Student
    {
        private DataGridView _dgvStudent;
        private string _className;

        public Student(DataGridView dgv, string className)
        {
            _dgvStudent = dgv;
            _className = className;
        }

       public Student()
       { 
       
       }

        //更新数据网格的显示
        public void UpdateDataGrid()
        {
            DataAccess.Classes objClass = new DataAccess.Classes(_className);
            DataSet objDataSet = objClass.FillByAllStudent();
            this._dgvStudent.DataSource = objDataSet.Tables[0];
        }

        //验证学号是否已存在
        public static bool CheckStudentExist(int studentNo)
        {
            if (DataAccess.Student.CheckExist(studentNo).HasRows)
            {
                MessageBox.Show("学号 " + studentNo + " 已经存在，请重新输入！", "学号已存在", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        //插入学生资料
        public void AddStudent(int studentNo, string studentName, string gender, DateTime birthday, string imagePath, string remark)
        {
            string newFileName = imagePath;
            if (imagePath.Trim().Length > 0)
            {
                newFileName = studentNo.ToString() + new FileInfo(imagePath).Extension; 
            } 
            //首先判断学号是否已存在
            if (!CheckStudentExist(studentNo))
            {
                if (DataAccess.Student.CreateStudent(studentNo, studentName, gender, birthday, _className, newFileName, remark) > 0)
                {
                    UpdateDataGrid();
                    //复制图片
                    if (imagePath.Trim().Length > 0)
                    {
                        BusinessRuler.ImageManage.CopyImageFileToServer(imagePath, newFileName);
                    }
                    MessageBox.Show("插入学生资料成功！", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("插入操作失败！", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //修改学生资料
        public void Update(int studentNo, string studentName, string gender, DateTime birthday, string className, string imagePath, string remark)
        {
            string newFileName = imagePath;
            if (imagePath.Trim().Length > 0)
            {
                newFileName = studentNo.ToString() + new FileInfo(imagePath).Extension;
            }
            DataAccess.Student objStudent = new DataAccess.Student(studentNo);
            objStudent.StudentName = studentName;
            objStudent.Gender = gender;
            objStudent.Birthday = birthday;
            objStudent.ClassName = className;
            objStudent.Picture = newFileName;
            objStudent.Remark = remark;
            int result = 0;
            if (className.Equals(_className))
            {
                result = objStudent.Update();
            }
            else
            {
                result = objStudent.Update(_className);
            }
            if (result > 0)
            {
                UpdateDataGrid();
                //更新图片
                if (imagePath.Trim().Length > 0)
                {
                    BusinessRuler.ImageManage.UpdateImageFile(imagePath, newFileName);
                }
                MessageBox.Show("修改学生资料成功！", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("更新操作失败！", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //删除学生
        public void Delete(int studentNo,string studentName,string className)
        {
            if (DialogResult.Yes == MessageBox.Show("真的要删除学生' " + studentName + " '吗?\n删除学生，将同时删除与该学生相关的所有成绩信息，要继续吗？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DataAccess.Student objStudent = new DataAccess.Student(studentNo);
                objStudent.ClassName = className;
                if (objStudent.Delete() > 0)
                {
                    UpdateDataGrid();
                    MessageBox.Show("成功删除学生' " + studentName + " '!", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("删除操作失败！", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

       public int FillCboByAllStudentNo(ComboBox cbo, int studentNo,string className)
       {
           cbo.Items.Clear();
           int position = 0;
           int i = 0;
           DataAccess.Classes objClass = new DataAccess.Classes(className);
           DataTable studentNos = objClass.GetAllStudentNo();
           foreach (DataRow row in studentNos.Rows)
           {
               int stuNo = Int32.Parse(row[0].ToString());
               cbo.Items.Add(stuNo);
               if (stuNo == studentNo)
               {
                   position = i;
               }
               i++;
           }
           cbo.SelectedIndex = position;
           return position;
       }

       public static void FillCboByAllStudentName(ComboBox cbo, string className,string studentName)
       {
           cbo.Items.Clear();
           int position = 0;
           int i = 0;
           DataTable studentNames = DataAccess.Student.FillByAllStudentName(className).Tables[0];
           foreach (DataRow row in studentNames.Rows)
           {
               cbo.Items.Add(row[0].ToString());
               if (row[0].ToString().Equals(studentName))
               {
                   position = i;
               }
               i++;
           }
           cbo.SelectedIndex = position;
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
