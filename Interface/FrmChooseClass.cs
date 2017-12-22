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
            if (_target.Equals("学生管理"))
            {
                FrmStudent frmStudent = new FrmStudent(this.cboClassNameList.SelectedItem.ToString());
                frmStudent.ShowDialog();
            }
            else if (_target.Equals("课程管理"))
            {
                FrmCourse frmCourse = new FrmCourse(this.cboClassNameList.SelectedItem.ToString());
                frmCourse.ShowDialog();
            }
            else if (_target.Equals("成绩管理"))
            {
                string className = this.cboClassNameList.SelectedItem.ToString();
                //如无学生，则提示先添加学生
                BusinessRuler.Classes objClass = new BusinessRuler.Classes();
                bool isStudentExist = objClass.IsStudentExists(className);
                //添加先决条件，如果该班没有课程，则提示用户先添加课程
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
                MessageBox.Show("请选择班级名!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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