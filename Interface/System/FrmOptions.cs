using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmOptions : Form
    {
        public FrmOptions()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //写配置文件
            int newImageSize = Int32.Parse(this.nupImageCapacity.Value.ToString());
            int newStudentCapacity = Int32.Parse(this.nupStudentCapacity.Value.ToString());
            BusinessRuler.ReaderWirteConfig.WriteToAppConfig("imageSize", newImageSize.ToString());
            BusinessRuler.ReaderWirteConfig.WriteToAppConfig("studentCapaticyInClass", newStudentCapacity.ToString());
            this.Close();
        }

        private void nupImageCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }

        private void FrmOptions_Load(object sender, EventArgs e)
        {
            //取得默认配置
            string originImageSize = BusinessRuler.ReaderWirteConfig.GetValueByKey("imageSize");
            string originStudentCapacity = BusinessRuler.ReaderWirteConfig.GetValueByKey("studentCapaticyInClass");
            this.nupImageCapacity.Value = Decimal.Parse(originImageSize);
            this.nupStudentCapacity.Value = Decimal.Parse(originStudentCapacity);
        }
    }
}