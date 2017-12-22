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

        //���������������ʾ
        public void UpdateDataGrid()
        {
            DataAccess.Classes objClass = new DataAccess.Classes(_className);
            DataSet objDataSet = objClass.FillByAllCourse();
            this._dgvCourse.DataSource = objDataSet.Tables[0];
        }

        //��ӿγ�
        public void Add(string subjectName, string teacher, DateTime beginDate, DateTime finishDate, string remark)
        {
            DataAccess.Classes objClass = new DataAccess.Classes(_className);
            if (objClass.GetDataReaderBySubjectName(subjectName).HasRows)
            {
                MessageBox.Show("�ð����пγ�" + subjectName + "�����������룡", "�γ��Ѵ���", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DataAccess.Course.Add(_className,subjectName,teacher,beginDate,finishDate,remark) > 0 )
                {
                    UpdateDataGrid();
                    MessageBox.Show("�ɹ���ӿγ̣�", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("��ӿγ�ʧ�ܣ�", "����ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //�޸Ŀγ�
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
                MessageBox.Show("�޸Ŀγ̳ɹ���", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("���²���ʧ�ܣ�", "����ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //ɾ���γ�
        public void Delete()
        {
            string subjectName = this._dgvCourse.CurrentRow.Cells["SubjectName"].Value.ToString();
            if (DialogResult.Yes == MessageBox.Show("���Ҫɾ���γ�' " + subjectName + " '��?\nɾ���γ̣���ͬʱɾ����ÿγ���ص����гɼ���Ϣ��Ҫ������", "ɾ��ȷ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DataAccess.Course objCourse = new DataAccess.Course(_className, subjectName);
                if (objCourse.Delete() > 0 )
                {
                    UpdateDataGrid();
                    MessageBox.Show("�ɹ�ɾ���γ�" + subjectName + " '!", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ɾ������ʧ�� " + subjectName + " '!", "����ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //����Ŀ���Ʋ��ҿγ�
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
            MessageBox.Show("�ѵ���¼ĩβ��", "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv.Tag = 0;
        }

        //����ʦ���ҿγ�
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
            MessageBox.Show("�ѵ���¼ĩβ��", "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv.Tag = 0;
        }

        //���������ڲ���
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
            MessageBox.Show("�ѵ���¼ĩβ��", "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv.Tag = 0;
        }

        //��������ڲ���
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
            MessageBox.Show("�ѵ���¼ĩβ��", "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv.Tag = 0;
        }



    }
}
