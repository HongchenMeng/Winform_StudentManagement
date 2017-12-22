using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmAddTeacher : Form
    {
        private DataGridView _dgvTeacher;
        public FrmAddTeacher(DataGridView dgv)
        {
            InitializeComponent();
            _dgvTeacher = dgv;
        }

        private void FrmAddTeacher_Load(object sender, EventArgs e)
        {
            this.cboDiploma.Items.Add("��ר");
            this.cboDiploma.Items.Add("����");
            this.cboDiploma.Items.Add("�о���");
            this.cboDiploma.Items.Add("˶ʿ");
            this.cboDiploma.Items.Add("��ʿ");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtTeachertName.Clear();
            this.dtpBirthday.Value = System.DateTime.Today;
            this.txtIdCard.Clear();
            this.txtUniversity.Clear();
            this.cboDiploma.SelectedIndex = -1;
            this.txtRemark.Clear();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            //��ӽ�ʦ����
            string teacherName = this.txtTeachertName.Text.Trim();
            string gender = "��";
            if(this.rdoFemale.Checked)
            {
                gender = "Ů";
            }
            DateTime birthday = this.dtpBirthday.Value;
            string idCard = this.txtIdCard.Text.Trim();
            string university = this.txtUniversity.Text.Trim();
            string specialfield = this.txtSpecialfield.Text.Trim();
            string diploma = this.cboDiploma.Text.ToString();
            string remark = this.txtRemark.Text;
            BusinessRuler.Teacher objTeacher = new BusinessRuler.Teacher(this._dgvTeacher);
            objTeacher.Add(teacherName, gender, birthday, idCard, university, specialfield, diploma, this.picTeacher.Tag.ToString(), remark);
        }

        public bool CheckInput()
        {
            if (this.txtTeachertName.Text.Trim().Length == 0)
            {
                MessageBox.Show("��ʦ��������Ϊ��!", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTeachertName.Focus();
                return false;
            }
            else if (this.txtIdCard.Text.Trim().Length == 0 )
            {
                MessageBox.Show("���֤���벻��Ϊ��!", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtIdCard.Focus();
                return false;
            }
            else if (this.txtUniversity.Text.Trim().Length == 0)
            {
                MessageBox.Show("��ҵԺУ����Ϊ��!", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUniversity.Focus();
                return false;
            }
            else if (this.txtSpecialfield.Text.Trim().Length == 0)
            {
                MessageBox.Show("רҵ����Ϊ��!", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSpecialfield.Focus();
                return false;
            }
            else if (this.cboDiploma.Text.Trim().Length == 0 )
            {
                MessageBox.Show("ѧ������Ϊ��!", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cboDiploma.Focus();
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
                    this.picTeacher.Tag = dlg.FileName;
                    this.picTeacher.Image = BusinessRuler.ImageManage.GetImageFromLocal(dlg.FileName);
                }
            }
        }
    }
}