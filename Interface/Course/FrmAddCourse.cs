using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmAddCourse : Form
    {
        private DataGridView _dgvCourse;
        private string _className;
        public FrmAddCourse(DataGridView dgv,string className)
        {
            InitializeComponent();
            _dgvCourse = dgv;
            _className = className;
        }

        private void FrmAddCourse_Load(object sender, EventArgs e)
        {
            BusinessRuler.Subject.FillCboByAllSubjectName(this.cboSujectName,null);
            BusinessRuler.Teacher.FillCboByAllTeacherName(this.cboTeacher, null);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            string subjectName = this.cboSujectName.SelectedItem.ToString();
            string teacherName = this.cboTeacher.SelectedItem.ToString();
            DateTime beginDate = this.dtpStartDate.Value;
            DateTime finishDate = this.dtpFinishDate.Value;
            string remark = this.txtRemark.Text.Trim();
            BusinessRuler.Course objCourse = new BusinessRuler.Course(this._dgvCourse, _className);
            objCourse.Add(subjectName, teacherName, beginDate, finishDate, remark);            
        }

        public bool CheckInput()
        {
            if (this.cboSujectName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择科目！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cboSujectName.Focus();
                return false;
            }
            else if (this.cboTeacher.SelectedIndex == -1)
            {
                MessageBox.Show("请选择授课老师！", "错误", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                this.cboTeacher.Focus();
                return false;
            }
            else if (this.dtpStartDate.Value >= this.dtpFinishDate.Value)
            {
                MessageBox.Show("开课日期必须小于结课日期，请重新填写！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dtpStartDate.Focus();
                return false;
            }
            return true;
        }
    }
}