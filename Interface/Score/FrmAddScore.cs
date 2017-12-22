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
            //��ӳɼ�
            BusinessRuler.Score objScore = new BusinessRuler.Score(this._dgvScore, _className);
            objScore.Add(this.cboStudentName.SelectedItem.ToString(), this.cboCourseNames.SelectedItem.ToString(), Double.Parse(this.nudScore.Value.ToString()));
        }

        public bool CheckInput()
        {
            if (this.cboStudentName.SelectedIndex == -1)
            {
                MessageBox.Show("��ѡ��ѧ������!","����",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.cboStudentName.Focus();
                return false;
            }
            else if (this.cboCourseNames.SelectedIndex == -1)
            {
                MessageBox.Show("��ѡ���Ŀ���ƣ�","����",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.cboCourseNames.Focus();
                return false;
            }
            else if (this.nudScore.Value < 0)
            {
                MessageBox.Show("������Ϸ���ѧ���ɼ�!","����",MessageBoxButtons.OK,MessageBoxIcon.Error);
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