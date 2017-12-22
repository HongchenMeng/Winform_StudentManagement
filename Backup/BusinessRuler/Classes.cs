using System;
using System.Windows.Forms;
using DataAccess;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace BusinessRuler
{ 
	public class Classes
	{ 
        private DataGridView _dgvClass;

        public Classes(DataGridView dgv)
        {
            _dgvClass = dgv;
        }

        public Classes()
        { 
        
        }

        //��֤ϵͳ�Ƿ��а༶
        public static bool IsClassExists()
        {
            if (DataAccess.Classes.IsClassExists().HasRows)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Ŀǰ��û�а༶�������ȴ����༶", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        //��֤�ð��Ƿ���ѧ��
        public bool IsStudentExists(string className)
        {
            DataAccess.Classes objClass = DataAccess.Classes.CreateInstance(className);
            if (objClass.CurrentCount > 0 )
            { 
                return true;
            }
            else
            {
                MessageBox.Show("�ð�Ŀǰ��û��ѧ�����޷����гɼ��������������ѧ����", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        //��֤�ð�ѧ�������Ƿ��ѳ����
        public static bool isInCapacity(string className)
        {
            int studentCapacity = Int32.Parse(BusinessRuler.ReaderWirteConfig.GetValueByKey("studentCapaticyInClass"));
            DataAccess.Classes objClass = DataAccess.Classes.CreateInstance(className);
            if (objClass.CurrentCount == studentCapacity )
            {
                MessageBox.Show("�ð�ѧ������������", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //��֤�༶���Ƿ��Ѵ���
        public static bool CheckExists(string className)
        {
            return DataAccess.Classes.CheckExists(className).HasRows;
        }

        //���ð��Ƿ��ѿ���
        public bool IsCourseExist(string className)
        {
            DataAccess.Classes objClass = new DataAccess.Classes(className);
            if (objClass.FillByAllSubjectName().Tables[0].Rows.Count > 0 )
            {
                return true;
            }
            else
            {
                MessageBox.Show(className+ " �����޿γ̣��޷����гɼ�����������ӿγ̣�","����",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }

        //���������������ʾ
        public void UpdateDataGrid()
        {
            if (this._dgvClass != null)
            {
                DataSet objDataSet = DataAccess.Classes.FillByAllClass();
                this._dgvClass.DataSource = objDataSet.Tables[0];
            }
        }

        //��Ӱ༶
        public void AddClass(string className, string director, DateTime entranceDate, string remark)
        {
            //�����жϰ༶�����Ƿ��Ѵ���
            if (CheckExists(className))
            {
                MessageBox.Show("�༶��" + className + "�Ѵ��ڣ�����������༶����", "�༶���Ѵ���", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DataAccess.Classes.CreateClass(className, director, entranceDate, remark) > 0)
                {
                    UpdateDataGrid();
                    MessageBox.Show("�ɹ���Ӱ༶��", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //�޸İ༶
        public void ModifyClass(string className, string director,DateTime entranceDate, string remark)
        {
            DataAccess.Classes objClass = new DataAccess.Classes(className);
            objClass.Director = director;
            objClass.EntranceDate = entranceDate;
            objClass.Remark = remark;
            if (objClass.Update() > 0)
            {
                UpdateDataGrid();
                MessageBox.Show("�޸İ༶���ϳɹ���", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //ɾ���༶
        public void DeleteClass(string className)
        {
            if (!CheckExists(className))
            {
                MessageBox.Show("�༶��" + className + "�����ڣ�����������༶����", "�༶��������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("���Ҫɾ���༶' " + className + " '��?\n ɾ���ð�ʱ����ͬʱɾ���ð�����ѧ���ĵ�������ؿγ̡��ɼ��ļ�¼��ȷ��Ҫ������", "ɾ��ȷ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    DataAccess.Classes objClass = new DataAccess.Classes(className);
                    if (objClass.Delete() > 0)
                    {
                        UpdateDataGrid();
                        MessageBox.Show("�ɹ�ɾ���༶' " + className + " '!", "�����ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        public void FillCboByAllClassName(ComboBox cbo, int position)
        {
            cbo.Items.Clear();
            DataTable classNames = DataAccess.Classes.GetAllClassName();
            foreach (DataRow row in classNames.Rows)
            {
                cbo.Items.Add(row[0].ToString());
            }
            cbo.SelectedIndex = position;
        }

        public void FillCboByAllClassName(ComboBox cbo, string theClassName)
        {
            cbo.Items.Clear();
            int position = 0;
            int i = 0;
            DataTable classNames = DataAccess.Classes.GetAllClassName();
            foreach(DataRow row in classNames.Rows)
            {
                cbo.Items.Add(row[0].ToString());
                if (row[0].ToString().Equals(theClassName))
                {
                    position = i;
                }
                i++;
            }
            cbo.SelectedIndex = position;
        }

        //���Ұ༶
        public static void FindByClassName(DataGridView dgv, string className)
        {
            for (int row = 0; row < dgv.Rows.Count; row++)
            {
                
                if (dgv.Rows[row].Cells["colClassName"].Value.ToString().Equals(className))
                {  
                    dgv.Rows[row].Selected = true;
                    return ;
                }
            }
            MessageBox.Show("�ѵ���¼ĩβ��", "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //�������β���
        public static void FindByDirector(DataGridView dgv, string director,bool useMatch)
        {
            for (int row = Int32.Parse(dgv.Tag.ToString()); row < dgv.Rows.Count; row++)
            {
                bool condition = dgv.Rows[row].Cells["colDirector"].Value.ToString().Equals(director);
                if (useMatch)
                {
                    condition = dgv.Rows[row].Cells["colDirector"].Value.ToString().Contains(director);
                }
                if (condition)
                {
                    dgv.Rows[row].Selected = true;
                    dgv.Tag = (row+1).ToString();
                    return ;
                }
            }
            MessageBox.Show("�ѵ���¼ĩβ��", "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv.Tag = 0;
        }

        //���������ڲ���
        public static void FindByDate(DataGridView dgv, DateTime startDate, DateTime finishDate)
        {
            for (int row = Int32.Parse(dgv.Tag.ToString()); row < dgv.Rows.Count; row++)
            {
                DateTime dateValue = DateTime.Parse(dgv.Rows[row].Cells["colEntranceDate"].Value.ToString());
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
