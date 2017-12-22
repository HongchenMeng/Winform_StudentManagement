using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmModifyTeacher : Form
    {
        private DataGridView _dgvTeacher;
        public FrmModifyTeacher(DataGridView dgv)
        {
            InitializeComponent();
            _dgvTeacher = dgv;
        }

        private void FrmModifyTeacher_Load(object sender, EventArgs e)
        {
            string teacherName = this._dgvTeacher.CurrentRow.Cells["TeacherName"].Value.ToString();
            BusinessRuler.Teacher.FillCboByAllTeacherName(this.cboTeacherNames, teacherName);
            if (this._dgvTeacher.CurrentRow.Cells["Gender"].Value.ToString().Equals("Ů"))
            {
                this.rdoFemale.Checked = true;
            }
            else
            {
                this.rdoMale.Checked = true;
            }
            this.dtpBirthday.Value = DateTime.Parse(this._dgvTeacher.CurrentRow.Cells["Birthday"].Value.ToString());
            this.txtIdCard.Text = this._dgvTeacher.CurrentRow.Cells["IDCard"].Value.ToString();
            this.txtUniversity.Text = this._dgvTeacher.CurrentRow.Cells["University"].Value.ToString();
            this.txtSpecialfield.Text = this._dgvTeacher.CurrentRow.Cells["Specialfield"].Value.ToString();
            FillCboDiploma(this._dgvTeacher.CurrentRow.Cells["Diploma"].Value.ToString());
            this.txtRemark.Text = this._dgvTeacher.CurrentRow.Cells["Remark"].Value.ToString();
            LoadImage(this._dgvTeacher.CurrentRow.Cells["Picture"].Value.ToString());
        }

        public void LoadImage(string fileName)
        {
            if (fileName.Trim().Length > 0)
            {
                this.picTeacher.Image = BusinessRuler.ImageManage.GetImageFromServer(fileName);
            }
        }


        public void FillCboDiploma(string diploma)
        {
            this.cboDiploma.Items.Clear();
            this.cboDiploma.Items.Add("��ר");
            this.cboDiploma.Items.Add("����");
            this.cboDiploma.Items.Add("�о���");
            this.cboDiploma.Items.Add("˶ʿ");
            this.cboDiploma.Items.Add("��ʿ");
            for (int i = 0; i < this.cboDiploma.Items.Count; i++)
            {
                string str = this._dgvTeacher.CurrentRow.Cells["Diploma"].Value.ToString();
                if (cboDiploma.Items[i].ToString().Equals(str))
                {
                    this.cboDiploma.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            string teacherName = this.cboTeacherNames.SelectedItem.ToString();
            string gender = "��";
            if (this.rdoFemale.Checked)
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
            objTeacher.Update(teacherName, gender, birthday, idCard, university, specialfield, diploma, this.picTeacher.Tag.ToString(), remark);
        }

        public bool CheckInput()
        {
            if (this.txtIdCard.Text.Trim().Length == 0 )
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.cboTeacherNames.SelectedIndex = 0;
            this.dtpBirthday.Value = System.DateTime.Today;
            this.txtIdCard.Clear();
            this.txtUniversity.Clear();
            this.cboDiploma.SelectedIndex = -1;
            this.txtRemark.Clear();
        }

        private void cboTeacherNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccess.Teacher objTeacher = DataAccess.Teacher.CreateInstance(this.cboTeacherNames.SelectedItem.ToString());            
            if (objTeacher != null)
            {
                if (objTeacher.Gender.Equals("��"))
                {
                    this.rdoMale.Checked = true;
                }
                else
                {
                    this.rdoFemale.Checked = true;
                }
                this.dtpBirthday.Value = objTeacher.Birthday;
                this.txtIdCard.Text = objTeacher.IDCard;
                this.txtUniversity.Text = objTeacher.University;
                this.txtSpecialfield.Text = objTeacher.Specialfield;
                FillCboDiploma(objTeacher.Diploma);
                this.txtRemark.Text = objTeacher.Remark;
            }
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