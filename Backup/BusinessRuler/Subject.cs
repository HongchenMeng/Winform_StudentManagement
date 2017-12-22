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

        //����FrmStudent�������������ʾ
        public void UpdateDataGrid()
        {
            DataSet objDataSet = DataAccess.Subject.FillByAllSubject();
            this._dgvSubject.DataSource = objDataSet.Tables[0];
        }

        //�����Ͽ�Ȼ��Ҫ�޸ĵĿ�Ŀ������Ϊѡ��״̬
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

        //�����Ͽ�Ȼ��Ҫ�޸ĵĿ�Ŀ������Ϊѡ��״̬���޸ĳɼ�ʹ�ã�
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

        //��֤��Ŀ�Ƿ��Ѵ���
        public bool CheckExist(string subjectName)
        {
            if (DataAccess.Subject.GetReaderBySubjectName(subjectName).HasRows)
            {
                return true;
            }
            return false;
        }

        //��ӿ�Ŀ
        public void Add(string subjectName, int period, string remark)
        {
            //���ȿ�Ŀ�����Ƿ��Ѵ���
            if (CheckExist(subjectName))
            {
                MessageBox.Show("��Ŀ" + subjectName + "�Ѵ��ڣ������������Ŀ����", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DataAccess.Subject.Add(subjectName, period, remark) > 0)
                {
                    UpdateDataGrid();
                    MessageBox.Show("�ɹ���ӿ�Ŀ��", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("��Ӳ���ʧ�ܣ�", "����ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
            }
        }

        //�޸Ŀ�Ŀ
        public void Update(string subjectName, int period, string remark)
        {
            DataAccess.Subject objSubject = new DataAccess.Subject(subjectName);
            objSubject.Period = period;
            objSubject.Remark = remark;
            if (objSubject.Update() > 0)
            {
                UpdateDataGrid();
                MessageBox.Show("�޸Ŀ�Ŀ���ϳɹ���", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("���¿�Ŀ����ʧ�ܣ������ԣ�", "����ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        //ɾ����Ŀ
        public void Delete()
        {
            string subjectName = this._dgvSubject.CurrentRow.Cells["SubjectName"].Value.ToString();
            DialogResult result = MessageBox.Show("���Ҫɾ����Ŀ' " + subjectName + " '��?", "ɾ��ȷ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                DataAccess.Subject objSubject = new DataAccess.Subject(subjectName);
                if (objSubject.Delete() > 0 )
                {
                    UpdateDataGrid();
                    MessageBox.Show("�ɹ�ɾ����Ŀ' " + subjectName + " '!", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ɾ������ʧ�ܣ������ԣ�", "����ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
            }
        }

        //����Ŀ���Ʋ���
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

    }
}
