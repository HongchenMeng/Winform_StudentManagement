using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmModifyScore : Form
    {
        private DataGridView _dgvScore;
        private string _className;

        public FrmModifyScore(DataGridView dgv,string className)
        {
            InitializeComponent();
            _dgvScore = dgv;
            _className = className;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool CheckInput()
        {
            if (this.cboStudentName.SelectedIndex == -1)
            {
                MessageBox.Show("��ѡ��Ҫ��ѡ�ɼ���ѧ��!","����",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.cboStudentName.Focus();
                return false;
            }
            if (this.cboCourseName.SelectedIndex == -1)
            {
                MessageBox.Show("��ѡ����Ӧ�Ŀ�Ŀ!", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cboCourseName.Focus();
                return false;
            }
            return true;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            //�޸ĳɼ�
            BusinessRuler.Score objScore = new BusinessRuler.Score(this._dgvScore, _className);
            objScore.Update(this.cboStudentName.SelectedItem.ToString(), this.cboCourseName.SelectedItem.ToString(), Double.Parse(this.nudScore.Value.ToString()));
        }

        private void FrmModifyScore_Load(object sender, EventArgs e)
        {
            //����Ҫ�޸ĵ�����
            string studentName = this._dgvScore.CurrentRow.Cells["StudentName"].Value.ToString();
            BusinessRuler.Student.FillCboByAllStudentName(this.cboStudentName,_className,studentName);
            this.cboStudentName.Enabled = false;
            string subjectName = this._dgvScore.CurrentRow.Cells["SubjectName"].Value.ToString();
            BusinessRuler.Subject.FillCboByCurrentSubjectName(this._dgvScore,cboCourseName,studentName);
            this.nudScore.Value = Decimal.Parse(this._dgvScore.CurrentRow.Cells["Score"].Value.ToString());
        }

        private void cboCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //���ݲ�ͬ�Ŀγ����ԭʼ����

        }

       
    }
}