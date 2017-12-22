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

        //���������������ʾ
        public void UpdateDataGrid()
        {
            DataAccess.Classes objClass = new DataAccess.Classes(_className);
            DataSet objDataSet = objClass.FillByAllStudent();
            this._dgvStudent.DataSource = objDataSet.Tables[0];
        }

        //��֤ѧ���Ƿ��Ѵ���
        public static bool CheckStudentExist(int studentNo)
        {
            if (DataAccess.Student.CheckExist(studentNo).HasRows)
            {
                MessageBox.Show("ѧ�� " + studentNo + " �Ѿ����ڣ����������룡", "ѧ���Ѵ���", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        //����ѧ������
        public void AddStudent(int studentNo, string studentName, string gender, DateTime birthday, string imagePath, string remark)
        {
            string newFileName = imagePath;
            if (imagePath.Trim().Length > 0)
            {
                newFileName = studentNo.ToString() + new FileInfo(imagePath).Extension; 
            } 
            //�����ж�ѧ���Ƿ��Ѵ���
            if (!CheckStudentExist(studentNo))
            {
                if (DataAccess.Student.CreateStudent(studentNo, studentName, gender, birthday, _className, newFileName, remark) > 0)
                {
                    UpdateDataGrid();
                    //����ͼƬ
                    if (imagePath.Trim().Length > 0)
                    {
                        BusinessRuler.ImageManage.CopyImageFileToServer(imagePath, newFileName);
                    }
                    MessageBox.Show("����ѧ�����ϳɹ���", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("�������ʧ�ܣ�", "����ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //�޸�ѧ������
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
                //����ͼƬ
                if (imagePath.Trim().Length > 0)
                {
                    BusinessRuler.ImageManage.UpdateImageFile(imagePath, newFileName);
                }
                MessageBox.Show("�޸�ѧ�����ϳɹ���", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("���²���ʧ�ܣ�", "����ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //ɾ��ѧ��
        public void Delete(int studentNo,string studentName,string className)
        {
            if (DialogResult.Yes == MessageBox.Show("���Ҫɾ��ѧ��' " + studentName + " '��?\nɾ��ѧ������ͬʱɾ�����ѧ����ص����гɼ���Ϣ��Ҫ������", "ɾ��ȷ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DataAccess.Student objStudent = new DataAccess.Student(studentNo);
                objStudent.ClassName = className;
                if (objStudent.Delete() > 0)
                {
                    UpdateDataGrid();
                    MessageBox.Show("�ɹ�ɾ��ѧ��' " + studentName + " '!", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ɾ������ʧ�ܣ�", "����ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

       //��ѧ�Ų���
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
           MessageBox.Show("�ѵ���¼ĩβ��", "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
           dgv.Tag = 0;
       }

       //��ѧ����������
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
           MessageBox.Show("�ѵ���¼ĩβ��", "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
           dgv.Tag = 0;
       }


    }
}
