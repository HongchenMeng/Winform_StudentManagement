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
            if (this._dgvTeacher.CurrentRow.Cells["Gender"].Value.ToString().Equals("女"))
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
            this.cboDiploma.Items.Add("大专");
            this.cboDiploma.Items.Add("本科");
            this.cboDiploma.Items.Add("研究生");
            this.cboDiploma.Items.Add("硕士");
            this.cboDiploma.Items.Add("博士");
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
            string gender = "男";
            if (this.rdoFemale.Checked)
            {
                gender = "女";
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
                MessageBox.Show("身份证号码不可为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtIdCard.Focus();
                return false;
            }
            else if (this.txtUniversity.Text.Trim().Length == 0)
            {
                MessageBox.Show("毕业院校不可为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUniversity.Focus();
                return false;
            }
            else if (this.txtSpecialfield.Text.Trim().Length == 0)
            {
                MessageBox.Show("专业不可为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSpecialfield.Focus();
                return false;
            }
            else if (this.cboDiploma.Text.Trim().Length == 0 )
            {
                MessageBox.Show("学历不可为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (objTeacher.Gender.Equals("男"))
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
            dlg.Filter = ".png文件|*.png|.jpg文件|*.jpg|.jpeg文件|.jpeg|.gif文件|*.gif|.bmp文件|*.bmp";
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