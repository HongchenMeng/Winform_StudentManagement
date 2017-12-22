using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmModifyCourse : Form
    {
        private DataGridView _dgvCourse;
        private string _className;
        public FrmModifyCourse(DataGridView dgv,string className)
        {
            InitializeComponent();
            _dgvCourse = dgv;
            _className = className;
        }

        private void FrmModifyCourse_Load(object sender, EventArgs e)
        {
            //����Ŀ���ϣ�����ʾָʾ��Ŀ���ƣ�
            string subjectName = this._dgvCourse.CurrentRow.Cells["SubjectName"].Value.ToString();
            BusinessRuler.Subject.FillCboByAllSubjectName(this.cboSubjectName, subjectName);
            string teacherName = this._dgvCourse.CurrentRow.Cells["Teacher"].Value.ToString();
            BusinessRuler.Teacher.FillCboByAllTeacherName(this.cboTeacher, teacherName);
            this.dtpStartDate.Value = DateTime.Parse(this._dgvCourse.CurrentRow.Cells["BeginDate"].Value.ToString());
            this.dtpFinishDate.Value = DateTime.Parse(this._dgvCourse.CurrentRow.Cells["FinishDate"].Value.ToString());
            this.txtRemark.Text = this._dgvCourse.CurrentRow.Cells["Remark"].Value.ToString();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            string teacherName = this.cboTeacher.SelectedItem.ToString();
            DateTime beginDate = this.dtpStartDate.Value;
            DateTime finishDate = this.dtpFinishDate.Value;
            string remark = this.txtRemark.Text.Trim();
            BusinessRuler.Course objCourse = new BusinessRuler.Course(this._dgvCourse, _className);
            objCourse.Update(this.cboSubjectName.SelectedItem.ToString(), teacherName, beginDate, finishDate, remark);
        }
        
        public bool CheckInput()
        {
            if (this.dtpStartDate.Value >= this.dtpFinishDate.Value)
            {
                MessageBox.Show("�������ڱ���С�ڽ�����ڣ���������д��", "��д����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dtpStartDate.Focus();
                return false;
            }
            return true;
        }

        private void cboSubjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //����ѡ��ͬ�Ŀγ�������ʾ��Ӧ������
            DataAccess.Course objCourse = DataAccess.Course.CreateInstance(_className, this.cboSubjectName.SelectedItem.ToString());
            BusinessRuler.Teacher.FillCboByAllTeacherName(this.cboTeacher, objCourse.Teacher);
            this.dtpStartDate.Value = objCourse.BeginDate;
            this.dtpFinishDate.Value = objCourse.FinishDate;
            this.txtRemark.Text = objCourse.Remark;
        }

    }
}