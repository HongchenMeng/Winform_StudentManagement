using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmModifyClass : Form
    {
        private DataGridView _dgvClass;
        public FrmModifyClass(DataGridView dgv)
        {
            InitializeComponent();
            _dgvClass = dgv;
        }

        private void FrmModifyClass_Load(object sender, EventArgs e)
        {
            ////将要编辑的记录的内容显示在窗体中
            string editName = this._dgvClass.CurrentRow.Cells[0].Value.ToString();
            BusinessRuler.Classes objClass = new BusinessRuler.Classes();
            objClass.FillCboByAllClassName(this.cboClassName, editName);
            cboClassName_SelectedIndexChanged(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.cboClassName.SelectedIndex = -1;
            this.dtpCreateDate.Value = System.DateTime.Today;
            this.txtDirector.Clear();
            this.txtRemark.Clear();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            BusinessRuler.Classes objClass = new BusinessRuler.Classes(this._dgvClass);
            objClass.ModifyClass(this.cboClassName.Text,this.txtDirector.Text.Trim(),this.dtpCreateDate.Value, this.txtRemark.Text.Trim());
            this.Close();
        }

        public bool CheckInput()
        {
          if (this.txtDirector.Text.Trim().Length == 0 )
            {
                MessageBox.Show("班主任名称不可为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDirector.Focus();
                return false;
            }
            return true;
        }

        private void cboClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccess.Classes objClass = DataAccess.Classes.CreateInstance(this.cboClassName.SelectedItem.ToString());
            if (objClass != null)
            {
                this.txtDirector.Text = objClass.Director;
                this.dtpCreateDate.Value = objClass.EntranceDate;
                this.txtRemark.Text = objClass.Remark;
            }
        }

    }
}