using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmFindClass : Form
    {
        private DataGridView _dgvClass;
        public FrmFindClass(DataGridView dgv)
        {
            InitializeComponent();
            _dgvClass = dgv;
        }

        private void FrmFindClass_Load(object sender, EventArgs e)
        {
            this.txtDirector.Enabled = this.chxUseMatchByDirector.Enabled = false;
            this.dtpStartDate.Enabled = this.dtpFinishDate.Enabled = false;
            BusinessRuler.Classes objClass = new BusinessRuler.Classes();
            objClass.FillCboByAllClassName(this.cboClassName, 0);
        }

        private void rdoBySubjectName_CheckedChanged(object sender, EventArgs e)
        {
            this.cboClassName.Enabled  = this.rdoByClassName.Checked;
        }

        private void rdoByDirector_CheckedChanged(object sender, EventArgs e)
        {
            this.txtDirector.Enabled = this.chxUseMatchByDirector.Enabled = this.rdoByDirector.Checked;
        }

        private void rdoCreateDate_CheckedChanged(object sender, EventArgs e)
        {
            this.dtpStartDate.Enabled = this.dtpFinishDate.Enabled = this.rdoCreateDate.Checked;
        }

        public bool CheckInput()
        {
            if (this.rdoByClassName.Checked)
            {
                if (this.cboClassName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("��ѡ�������Ҫ���ҵİ༶��!","�༶��",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (this.rdoByDirector.Checked)
            {
                if (this.txtDirector.Text.Trim().Length == 0)
                {
                    MessageBox.Show("���������������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                if (this.dtpStartDate.Value >= this.dtpFinishDate.Value)
                {
                    MessageBox.Show("��ѯ�������󣬿������ڲ��ɴ��ڽ�����ڣ�","����",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            //��ʼ����
            if (this.rdoByClassName.Checked)
            { 
                //���༶������
                BusinessRuler.Classes.FindByClassName(_dgvClass, this.cboClassName.Text.Trim());
            }
            else if (this.rdoByDirector.Checked)
            {
                string director = this.txtDirector.Text.Trim();
                bool useMatch = false;
                if (this.chxUseMatchByDirector.Checked)
                {
                    useMatch = true;
                }
                BusinessRuler.Classes.FindByDirector(_dgvClass, director, useMatch);
            }
            else
            {
                BusinessRuler.Classes.FindByDate(_dgvClass, this.dtpStartDate.Value, this.dtpFinishDate.Value);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}