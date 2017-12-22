using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Interface
{
    public partial class FrmAddStudent : Form
    {
        private DataGridView _dgvStudent;
        private string _className;

        public FrmAddStudent(DataGridView dgv,string className)
        {
            InitializeComponent();
            _dgvStudent = dgv;
            _className = className;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            //��ȡ����
            string gender = "��";
            if (this.rdoFemale.Checked == true)
            {
                gender = "Ů";
            }
            int studentNo = (Int32.Parse(this.txtStudentID.Text.Trim()));
            BusinessRuler.Student objStudent = new BusinessRuler.Student(this._dgvStudent, this._className);
            objStudent.AddStudent(studentNo, this.txtName.Text.Trim(), gender, this.dtpBirthday.Value, this.picStudent.Tag.ToString(), this.txtRemark.Text.Trim());
        }

        //�ͻ�����֤����
        public bool CheckInput()
        {
            if (this.txtStudentID.Text.Length < 6 )
            {
                MessageBox.Show("ѧ�ų���ӦΪ6λ��", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtStudentID.Focus();
                return false;
            }
            else if (this.txtName.Text.Trim() == "")
            {
                MessageBox.Show("��������Ϊ�գ���������д��", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtName.Focus();
                return false;
            }
            return true;
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = ".png�ļ�|*.png|.jpg�ļ�|*.jpg|.jpeg�ļ�|.jpeg|.gif�ļ�|*.gif|.bmp�ļ�|*.bmp";
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (BusinessRuler.ImageManage.CheckImageSize(dlg.FileName))
                {
                    this.picStudent.Tag = dlg.FileName;
                    this.picStudent.Image = BusinessRuler.ImageManage.GetImageFromLocal(dlg.FileName);
                }
            }
        }

        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar < '0' || e.KeyChar > '9';
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
        }

     

    }
}