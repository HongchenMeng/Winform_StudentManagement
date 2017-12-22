using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmFindCourse : Form
    {
        private DataGridView _dgvCourse;
        private string _className;
        public FrmFindCourse(DataGridView dgv,string className)
        {
            InitializeComponent();
            _dgvCourse = dgv;
            _className = className;
        }

        public bool CheckInput()
        {
            bool result = true;
            if (this.tabFindCourse.SelectedIndex == 0)
            {
                if (this.cboSubjectName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请选择或输入科目！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this.cboSubjectName.Focus();
                    result = false;
                }
            }
            else if (this.tabFindCourse.SelectedIndex == 1)
            {
                if (this.cboTeacherName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请选择或输入教师姓名！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cboTeacherName.Focus();
                    result = false;
                }
            }
            else if (this.tabFindCourse.SelectedIndex == 2)
            {
                if (this.dtpStartDate1.Value >= this.dtpFinishDate1.Value)
                {
                    MessageBox.Show("起始日期不可大于结束日期!","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this.dtpStartDate1.Focus();
                    result = false;
                }
            }
            else if (this.tabFindCourse.SelectedIndex == 3)
            {
                if (this.dtpStartDate2.Value >= this.dtpFinishDate2.Value)
                {
                    MessageBox.Show("起始日期不可大于结束日期!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.dtpStartDate2.Focus();
                    result = false;
                } 
            }
            return result;
        }

        private void tabFindCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabFindCourse.SelectedIndex == 1)
            {
                BusinessRuler.Teacher.FillCboByAllTeacherName(this.cboTeacherName, null);
            }
        }

        private void FrmFindCourse_Load(object sender, EventArgs e)
        {
            BusinessRuler.Course.FillCboByAllSubjectName(this.cboSubjectName, _className, null);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            if (this.tabFindCourse.SelectedIndex == 0)
            {
                string subjectName = this.cboSubjectName.Text.Trim();
                bool useMatch = false;
                if(this.chxUseMatchBySubject.Checked)
                {
                    useMatch = true;
                }
                BusinessRuler.Course.FindBySubjectName(_dgvCourse, subjectName, useMatch);
            }
            else if (this.tabFindCourse.SelectedIndex == 1)
            {
                string teacherName = this.cboTeacherName.Text.Trim();
                bool useMatch = false;
                if (this.chxUserMatchByTeacher.Checked)
                {
                    useMatch = true;
                }
                BusinessRuler.Course.FindByTeacherName(_dgvCourse, teacherName, useMatch);
            }
            else if (this.tabFindCourse.SelectedIndex == 2)
            {
                DateTime startDate = this.dtpStartDate1.Value;
                DateTime finishDate = this.dtpFinishDate1.Value;
                BusinessRuler.Course.FindByStartDate(_dgvCourse, startDate, finishDate);
            }
            else if (this.tabFindCourse.SelectedIndex == 3)
            {
                DateTime startDate = this.dtpStartDate2.Value;
                DateTime finishDate = this.dtpFinishDate2.Value;
                BusinessRuler.Course.FindByFinishDate(_dgvCourse, startDate, finishDate);
            }
        }

        

        

    }
}