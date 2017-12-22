using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmChooseClass : Form
    {
        private string _target;
        public FrmChooseClass(string target)
        {
            InitializeComponent();
            _target = target;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            this.Hide();
            if (_target.Equals("ѧ������"))
            {
                FrmStudent frmStudent = new FrmStudent(this.cboClassNameList.SelectedItem.ToString());
                frmStudent.ShowDialog();
            }
            else if (_target.Equals("�γ̹���"))
            {
                FrmCourse frmCourse = new FrmCourse(this.cboClassNameList.SelectedItem.ToString());
                frmCourse.ShowDialog();
            }
            else if (_target.Equals("�ɼ�����"))
            {
                string className = this.cboClassNameList.SelectedItem.ToString();
                //����ѧ��������ʾ�����ѧ��
                BusinessRuler.Classes objClass = new BusinessRuler.Classes();
                bool isStudentExist = objClass.IsStudentExists(className);
                //����Ⱦ�����������ð�û�пγ̣�����ʾ�û�����ӿγ�
                if (isStudentExist && (objClass.IsCourseExist(className)))
                {
                    FrmScore frmScore = new FrmScore(this.cboClassNameList.SelectedItem.ToString());
                    frmScore.ShowDialog();
                }
                else
                {
                    this.Close();
                }
            }
            this.Close();
        }

        public bool CheckInput()
        {
            if (this.cboClassNameList.SelectedIndex < 0)
            {
                MessageBox.Show("��ѡ��༶��!", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cboClassNameList.Focus();
                return false;
            }
            return true;
        }

        private void FrmChooseClass_Load(object sender, EventArgs e)
        {
            BusinessRuler.Classes objClass = new BusinessRuler.Classes();
            objClass.FillCboByAllClassName(this.cboClassNameList, 0);
        }

    }
}