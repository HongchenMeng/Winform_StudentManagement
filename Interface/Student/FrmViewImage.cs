using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmViewImage : Form
    {
        //记录鼠标左键按下状态
        private bool _isMouseLeftDown = false;
        private Point _frmOrignalPos = new Point(0, 0);

        public FrmViewImage(Image img)
        {
            InitializeComponent();
            this.picStudentImage.Image = img;
        }

        private void picStudentImage_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.Close();
            }
        }

        private void picStudentImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this._isMouseLeftDown = true;
                this._frmOrignalPos.X = e.X;
                this._frmOrignalPos.Y = e.Y;
            }
        }

        private void picStudentImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (this._isMouseLeftDown == true)
            {
                this.Top += e.Y - this._frmOrignalPos.Y;
                this.Left += e.X - this._frmOrignalPos.X;
            }
        }

        private void picStudentImage_MouseUp(object sender, MouseEventArgs e)
        {
            this._isMouseLeftDown = false;
        }



    }
}