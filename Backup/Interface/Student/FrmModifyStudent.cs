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
    public partial class FrmModifyStudent : Form
    {
        private DataGridView _dgvStudent;
        private string _className;
        public FrmModifyStudent(DataGridView dgv,string className)
        {
            InitializeComponent();
            _dgvStudent = dgv;
            _className = className;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(!CheckInput())
            {
                return ;
            }
            BusinessRuler.Student objStudent = new BusinessRuler.Student(this._dgvStudent,_className);
            int studentNo =Int32.Parse(this.cboStudentNo.SelectedItem.ToString());
            string studentName = this.txtName.Text.Trim();
            string gender = "��";
            if(this.rdoFemale.Checked)
            {
                gender = "Ů";
            }
            DateTime birthday = this.dtpBirthday.Value;
            string className = this.cboClass.SelectedItem.ToString();
            string remark = this.txtRemark.Text.Trim();
            objStudent.Update(studentNo, studentName, gender, birthday, className, this.picStudent.Tag.ToString(), remark);
        }

        //�ͻ�����֤����
        public bool CheckInput()
        {
            if (this.txtName.Text.Trim() == "")
            {
                MessageBox.Show("��������Ϊ�գ�", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtName.Focus();
                return false;
            }
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtName.Clear();
            this.dtpBirthday.Value = System.DateTime.Today;
            this.txtRemark.Clear();
        }

        private void FrmModifyStudent_Load(object sender, EventArgs e)
        {
            int studentNo = Int32.Parse(this._dgvStudent.CurrentRow.Cells["StudentNo"].Value.ToString());
            BusinessRuler.Student objStudent = new BusinessRuler.Student();
            int position = objStudent.FillCboByAllStudentNo(this.cboStudentNo, studentNo, _className);
            this.cboStudentNo.SelectedItem = this.cboStudentNo.Items[position];
            cboStudentNo_SelectedIndexChanged(sender, e);
            LoadImage(this._dgvStudent.CurrentRow.Cells["Picture"].Value.ToString());
        }

        public void LoadImage(string fileName)
        {
            if (fileName.Trim().Length > 0 )
            {
                this.picStudent.Image = BusinessRuler.ImageManage.GetImageFromServer(fileName);
            }
        }

        private void chxChangeClass_CheckedChanged(object sender, EventArgs e)
        {
            this.cboClass.Enabled = this.chxChangeClass.Checked;
        }

        private void cboStudentNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //����ѧ�Ž���Ӧ��������
            int studentNo = Int32.Parse(this.cboStudentNo.SelectedItem.ToString());
            DataAccess.Student objStudent = DataAccess.Student.CreateInstance(studentNo);
            this.txtName.Text = objStudent.StudentName;
            if (objStudent.Gender.Equals("Ů"))
            {
                this.rdoFemale.Checked = true;
            }
            else
            {
                this.rdoMale.Checked = true;
            }
            this.dtpBirthday.Value = objStudent.Birthday;
            this.chxChangeClass.Checked = false;
            this.cboClass.Enabled = false;
            //���༶�����б�
            BusinessRuler.Classes objClass = new BusinessRuler.Classes();
            objClass.FillCboByAllClassName(this.cboClass, objStudent.ClassName);
            LoadImage(objStudent.Picture);
            this.txtRemark.Text = objStudent.Remark;
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
		
    }
}