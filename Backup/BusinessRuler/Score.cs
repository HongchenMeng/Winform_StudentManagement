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


        //��ӿγ�
        public void Add(string studentName,string subjectName,double scoreCount)
        {
            int studentNo = DataAccess.Student.GetStudentNo(_className, studentName);
            DataAccess.Course objCourse = new DataAccess.Course(_className,subjectName);
            int courseID = objCourse.GetCourseID();
            if (DataAccess.Score.GetReader(studentNo,courseID).HasRows)
            {
                MessageBox.Show("���� " + subjectName + " �γɼ��Ѵ��ڣ�", "���ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DataAccess.Score.Add(studentNo,courseID,scoreCount) > 0 )
                {
                    UpdateDataGrid();
                    MessageBox.Show("�ɹ���ӳɼ���", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("��ӳɼ�ʧ�ܣ�", "����ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //�޸Ŀγ�
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
                MessageBox.Show("�޸ĳɼ��ɹ���", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("���³ɼ�ʧ�ܣ�", "����ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //ɾ���γ�
        public void Delete()
        {
            int studentNo = Int32.Parse(this._dgvScore.CurrentRow.Cells["StudentNo"].Value.ToString());
            string subjectName = this._dgvScore.CurrentRow.Cells["SubjectName"].Value.ToString();
            DataAccess.Course objCourse = new DataAccess.Course(_className, subjectName);
            int courseID = objCourse.GetCourseID();
            DialogResult result = MessageBox.Show("���Ҫɾ����?", "ɾ��ȷ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataAccess.Score objScore = new DataAccess.Score(studentNo, courseID);
                if (objScore.Delete() > 0)
                {
                    UpdateDataGrid();
                    MessageBox.Show("�ɹ�ɾ���ɼ�!", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ɾ������ʧ��!", "����ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
