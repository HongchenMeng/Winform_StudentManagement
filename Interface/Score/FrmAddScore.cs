using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmAddScore : Form
    {
        private DataGridView _dgvScore;
        private string _className;

        public FrmAddScore(DataGridView dgv,string className)
        {
            InitializeComponent();
            _dgvScore = dgv;
            _className = className;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            //添加成绩
            BusinessRuler.Score objScore = new BusinessRuler.Score(this._dgvScore, _className);
            objScore.Add(this.cboStudentName.SelectedItem.ToString(), this.cboCourseNames.SelectedItem.ToString(), Double.Parse(this.nudScore.Value.ToString()));
        }

        public bool CheckInput()
        {
            if (this.cboStudentName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择学生姓名!","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.cboStudentName.Focus();
                return false;
            }
            else if (this.cboCourseNames.SelectedIndex == -1)
            {
                MessageBox.Show("请选择科目名称！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.cboCourseNames.Focus();
                return false;
            }
            else if (this.nudScore.Value < 0)
            {
                MessageBox.Show("请输入合法的学生成绩!","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.nudScore.Focus();
                return false;
            }
            return true;
        }

        private void FrmAddScore_Load(object sender, EventArgs e)
        {
            BusinessRuler.Student.FillCboByAllStudentName(this.cboStudentName,_className, null);
            BusinessRuler.Course.FillCboByAllSubjectName(this.cboCourseNames,_className,null);
        }
    }
}