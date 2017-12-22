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

        //���������������ʾ
        public void UpdateDataGrid()
        {
            DataSet objDataSet = DataAccess.Teacher.FillByAllTeacher();
            this._dgvTeacher.DataSource = objDataSet.Tables[0];
        }

        //��֤ѧ���Ƿ��Ѵ���
        public bool CheckTeacherExist(string teacherName)
        {
            if (DataAccess.Teacher.GetReaderByTeacherName(teacherName).HasRows)
            {
                MessageBox.Show("��ʦ " + teacherName + " �Ѿ����ڣ����������룡", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        //�����ʦ����
        public void Add(string teacherName, string gender, DateTime birthday, string idCard, string university, string specialfield, string diploma, string imagePath, string remark)
        {
            string newFileName = imagePath;
            if (imagePath.Trim().Length > 0)
            {
                newFileName = teacherName.ToString() + new FileInfo(imagePath).Extension;
            } 
            //�����жϽ�ʦ�Ƿ��Ѵ���
            if (!CheckTeacherExist(teacherName))
            {
                if (DataAccess.Teacher.AddTeacher(teacherName, gender, birthday, idCard, university, specialfield, diploma, newFileName, remark) > 0)
                {
                    UpdateDataGrid();
                    //����ͼƬ
                    if (imagePath.Trim().Length > 0)
                    {
                        BusinessRuler.ImageManage.CopyImageFileToServer(imagePath, newFileName);
                    }
                    MessageBox.Show("��ӽ�ʦ���ϳɹ���", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("��ӽ�ʦ����ʧ�ܣ������ԣ�", "����ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //�޸Ľ�ʦ����
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
                //����ͼƬ
                if (imagePath.Trim().Length > 0)
                {
                    BusinessRuler.ImageManage.UpdateImageFile(imagePath, newFileName);
                }
                MessageBox.Show("�޸Ľ�ʦ���ϳɹ���", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("���½�ʦ����ʧ�ܣ������ԣ�", "����ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //ɾ����ʦ
        public void Delete()
        {
            string teacherName = this._dgvTeacher.CurrentRow.Cells["TeacherName"].Value.ToString();
            DialogResult result = MessageBox.Show("���Ҫɾ����ʦ' " + teacherName + " '��?\nɾ����ʦ���ϣ�������ɾ���ý�ʦ���ڿγ̼�¼�Լ���Ӧ�γ̵ĳɼ���¼��ȷ��Ҫ������", "ɾ��ȷ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( result == DialogResult.Yes)
            {
                DataAccess.Teacher objTeacher = new DataAccess.Teacher(teacherName);
                if (objTeacher.Delete() > 0 )
                {
                    UpdateDataGrid();
                    MessageBox.Show("�ɹ�ɾ����ʦ����!' " + teacherName + " '!", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ɾ������ʧ�ܣ�������!", "����ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //����Ŀ������ʦ
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
            MessageBox.Show("�ѵ���¼ĩβ��", "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv.Tag = 0;
        }

        //�����֤�Ų�����ʦ
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
            MessageBox.Show("�ѵ���¼ĩβ��", "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv.Tag = 0;
        }
        
    }
}
