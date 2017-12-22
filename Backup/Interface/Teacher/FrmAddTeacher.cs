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
            this.cboDiploma.Items.Add("大专");
            this.cboDiploma.Items.Add("本科");
            this.cboDiploma.Items.Add("研究生");
            this.cboDiploma.Items.Add("硕士");
            this.cboDiploma.Items.Add("博士");
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
            //添加教师资料
            string teacherName = this.txtTeachertName.Text.Trim();
            string gender = "男";
            if(this.rdoFemale.Checked)
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
            objTeacher.Add(teacherName, gender, birthday, idCard, university, specialfield, diploma, this.picTeacher.Tag.ToString(), remark);
        }

        public bool CheckInput()
        {
            if (this.txtTeachertName.Text.Trim().Length == 0)
            {
                MessageBox.Show("教师姓名不可为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTeachertName.Focus();
                return false;
            }
            else if (this.txtIdCard.Text.Trim().Length == 0 )
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