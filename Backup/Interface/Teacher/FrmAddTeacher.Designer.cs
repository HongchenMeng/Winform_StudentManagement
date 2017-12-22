namespace Interface
{
    partial class FrmAddTeacher
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddTeacher));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.txtIdCard = new System.Windows.Forms.MaskedTextBox();
            this.txtSpecialfield = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDiploma = new System.Windows.Forms.ComboBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.picTeacher = new System.Windows.Forms.PictureBox();
            this.lblDiploma = new System.Windows.Forms.Label();
            this.lblIDCard = new System.Windows.Forms.Label();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtUniversity = new System.Windows.Forms.TextBox();
            this.lblUniversity = new System.Windows.Forms.Label();
            this.txtTeachertName = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(382, 399);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "关闭(&X)";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(166, 399);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 25);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "清除(&C)";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.txtIdCard);
            this.grpInfo.Controls.Add(this.txtSpecialfield);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.cboDiploma);
            this.grpInfo.Controls.Add(this.dtpBirthday);
            this.grpInfo.Controls.Add(this.lblBirthday);
            this.grpInfo.Controls.Add(this.btnChooseImage);
            this.grpInfo.Controls.Add(this.picTeacher);
            this.grpInfo.Controls.Add(this.lblDiploma);
            this.grpInfo.Controls.Add(this.lblIDCard);
            this.grpInfo.Controls.Add(this.rdoFemale);
            this.grpInfo.Controls.Add(this.rdoMale);
            this.grpInfo.Controls.Add(this.lblSex);
            this.grpInfo.Controls.Add(this.txtUniversity);
            this.grpInfo.Controls.Add(this.lblUniversity);
            this.grpInfo.Controls.Add(this.txtTeachertName);
            this.grpInfo.Controls.Add(this.lblRemark);
            this.grpInfo.Controls.Add(this.lblTeacherName);
            this.grpInfo.Controls.Add(this.txtRemark);
            this.grpInfo.Location = new System.Drawing.Point(6, 8);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(488, 376);
            this.grpInfo.TabIndex = 14;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "输入信息：";
            // 
            // txtIdCard
            // 
            this.txtIdCard.Location = new System.Drawing.Point(112, 114);
            this.txtIdCard.Mask = "000000-00000000-000A";
            this.txtIdCard.Name = "txtIdCard";
            this.txtIdCard.Size = new System.Drawing.Size(137, 21);
            this.txtIdCard.TabIndex = 4;
            // 
            // txtSpecialfield
            // 
            this.txtSpecialfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecialfield.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtSpecialfield.Location = new System.Drawing.Point(112, 177);
            this.txtSpecialfield.MaxLength = 20;
            this.txtSpecialfield.Name = "txtSpecialfield";
            this.txtSpecialfield.Size = new System.Drawing.Size(211, 21);
            this.txtSpecialfield.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "专业：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboDiploma
            // 
            this.cboDiploma.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cboDiploma.Location = new System.Drawing.Point(112, 213);
            this.cboDiploma.Name = "cboDiploma";
            this.cboDiploma.Size = new System.Drawing.Size(144, 20);
            this.cboDiploma.TabIndex = 8;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(112, 80);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(136, 21);
            this.dtpBirthday.TabIndex = 3;
            this.dtpBirthday.Value = new System.DateTime(2007, 2, 9, 0, 0, 0, 0);
            // 
            // lblBirthday
            // 
            this.lblBirthday.Location = new System.Drawing.Point(16, 80);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(80, 23);
            this.lblBirthday.TabIndex = 19;
            this.lblBirthday.Text = "出生日期：";
            this.lblBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseImage.Location = new System.Drawing.Point(370, 174);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(81, 25);
            this.btnChooseImage.TabIndex = 7;
            this.btnChooseImage.Text = "照片(&P)...";
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // picTeacher
            // 
            this.picTeacher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTeacher.Location = new System.Drawing.Point(367, 39);
            this.picTeacher.Name = "picTeacher";
            this.picTeacher.Size = new System.Drawing.Size(90, 120);
            this.picTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTeacher.TabIndex = 18;
            this.picTeacher.TabStop = false;
            this.picTeacher.Tag = "  ";
            // 
            // lblDiploma
            // 
            this.lblDiploma.Location = new System.Drawing.Point(16, 213);
            this.lblDiploma.Name = "lblDiploma";
            this.lblDiploma.Size = new System.Drawing.Size(72, 23);
            this.lblDiploma.TabIndex = 15;
            this.lblDiploma.Text = "学历：";
            this.lblDiploma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIDCard
            // 
            this.lblIDCard.Location = new System.Drawing.Point(16, 112);
            this.lblIDCard.Name = "lblIDCard";
            this.lblIDCard.Size = new System.Drawing.Size(80, 23);
            this.lblIDCard.TabIndex = 13;
            this.lblIDCard.Text = "身份证号码：";
            this.lblIDCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoFemale
            // 
            this.rdoFemale.Location = new System.Drawing.Point(175, 52);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(46, 24);
            this.rdoFemale.TabIndex = 2;
            this.rdoFemale.Text = "女";
            // 
            // rdoMale
            // 
            this.rdoMale.Checked = true;
            this.rdoMale.Location = new System.Drawing.Point(112, 52);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(46, 24);
            this.rdoMale.TabIndex = 1;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            // 
            // lblSex
            // 
            this.lblSex.Location = new System.Drawing.Point(16, 52);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(56, 23);
            this.lblSex.TabIndex = 12;
            this.lblSex.Text = "性别：";
            this.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUniversity
            // 
            this.txtUniversity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUniversity.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtUniversity.Location = new System.Drawing.Point(112, 144);
            this.txtUniversity.MaxLength = 20;
            this.txtUniversity.Name = "txtUniversity";
            this.txtUniversity.Size = new System.Drawing.Size(211, 21);
            this.txtUniversity.TabIndex = 5;
            // 
            // lblUniversity
            // 
            this.lblUniversity.Location = new System.Drawing.Point(16, 144);
            this.lblUniversity.Name = "lblUniversity";
            this.lblUniversity.Size = new System.Drawing.Size(72, 23);
            this.lblUniversity.TabIndex = 8;
            this.lblUniversity.Text = "毕业院校：";
            this.lblUniversity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTeachertName
            // 
            this.txtTeachertName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTeachertName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtTeachertName.Location = new System.Drawing.Point(112, 24);
            this.txtTeachertName.MaxLength = 20;
            this.txtTeachertName.Name = "txtTeachertName";
            this.txtTeachertName.Size = new System.Drawing.Size(211, 21);
            this.txtTeachertName.TabIndex = 0;
            // 
            // lblRemark
            // 
            this.lblRemark.Location = new System.Drawing.Point(16, 245);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(64, 23);
            this.lblRemark.TabIndex = 4;
            this.lblRemark.Text = "备注：";
            this.lblRemark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.Location = new System.Drawing.Point(16, 24);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(72, 23);
            this.lblTeacherName.TabIndex = 0;
            this.lblTeacherName.Text = "教师姓名：";
            this.lblTeacherName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtRemark.Location = new System.Drawing.Point(112, 245);
            this.txtRemark.MaxLength = 0;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(352, 112);
            this.txtRemark.TabIndex = 9;
            // 
            // btnApply
            // 
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Location = new System.Drawing.Point(78, 399);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(89, 25);
            this.btnApply.TabIndex = 10;
            this.btnApply.Text = "添加(&A)";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // FrmAddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 435);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddTeacher";
            this.Text = "增加教师";
            this.Load += new System.EventHandler(this.FrmAddTeacher_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TextBox txtSpecialfield;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDiploma;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.PictureBox picTeacher;
        private System.Windows.Forms.Label lblDiploma;
        private System.Windows.Forms.Label lblIDCard;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtUniversity;
        private System.Windows.Forms.Label lblUniversity;
        private System.Windows.Forms.TextBox txtTeachertName;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.MaskedTextBox txtIdCard;
    }
}