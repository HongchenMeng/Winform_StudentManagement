using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using BusinessRuler;
using System.IO;

namespace Interface
{
    public partial class FrmMain : Form
    {
        private BusinessRuler.DataGridViewPrinter MyDataGridViewPrinter;
        private string _currentUser;
        private string _currentClassName;
        public string CurrentUser
        {
            get
            {
                return _currentUser;
            }
            set
            {
                _currentUser = value;
            }
        }
        public FrmMain(string userName)
        {
            InitializeComponent();
            _currentUser = userName;
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            FrmCopyright frmCopyright = new FrmCopyright();
            frmCopyright.ShowDialog();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("真的要退出系统吗？", "确认退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void tmrSetStatus_Tick(object sender, EventArgs e)
        {
            this.trb2.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.trb4.Text = _currentUser;
            this.trb5.Text = "  感谢你使用本软件！如有任何问题，欢迎你同Ruihua Studio联系! QQ:451626827、Email:ruihua@szswt.cn";
            this.tmrSetStatus.Start();
            FillData_Load();
        }

        public void FillData_Load()
        {
            FillNode(this.tvwMain.Nodes[1]);
            FillNode(this.tvwMain.Nodes[2]);
            FillNode(this.tvwMain.Nodes[4]);
        }
        public void FillNode(TreeNode node)
        {
            node.Nodes.Clear();
            DataTable names = DataAccess.Classes.GetAllClassName();
            foreach (DataRow row in names.Rows)
            {
                node.Nodes.Add(row[0].ToString());
            }
        }

        private void mnuUserManagement_Click(object sender, EventArgs e)
        {
            FrmUser objUser = new FrmUser();
            objUser.ShowDialog();
        }

        private void mnuChangePwd_Click(object sender, EventArgs e)
        {
            FrmChangePwd frmChangePwd = new FrmChangePwd(this._currentUser);
            frmChangePwd.ShowDialog();
        }

        private void mnuCreaClass_Click(object sender, EventArgs e)
        {
            mnuAddClass_Click(sender, e);
        }

        private void mnuBrowseClass_Click(object sender, EventArgs e)
        {
            FrmClass frmClass = new FrmClass();
            frmClass.ShowDialog();
        }
 
        private void mnuUpdateClass_Click(object sender, EventArgs e)
        {
            FrmModifyClass frmModifyClass = new FrmModifyClass(this.dgvDetails);
            frmModifyClass.ShowDialog();
        }

        private void mnuNewClass_Click(object sender, EventArgs e)
        {
            mnuAddClass_Click(sender, e);
        }

        public void SetMnuSystemManageVisible(bool value)
        {
            this.mnuUserManagement.Visible = this.mnuTeacherManagement.Visible = this.mnuOption.Visible = value;
            this.toolStripMenuItem2.Visible = this.toolStripMenuItem4.Visible = value;
        }
        private void tvwMain_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.dgvDetails.Visible = true;
            this.lvwMain.Visible = false;
            if (e.Node.Text.Equals("班级管理"))
            {
                SetDataGirdStyleForClass();
                BusinessRuler.Classes objClass = new Classes(this.dgvDetails);
                objClass.UpdateDataGrid();  
            }
            else if(e.Node.Text.Equals("科目管理"))
            {
                SetDataGridStyleForSubject();
                BusinessRuler.Subject objSubject = new BusinessRuler.Subject(this.dgvDetails);
                objSubject.UpdateDataGrid();
            }
            else if(e.Node.Text.Equals("主界面"))
            {
                tbrReturnMain_Click(sender, e);
            }
            if (e.Node.Parent != null)
            {
                if (e.Node.Parent.Text.Equals("学生管理"))
                {
                    SetDataGridStyleForStudent();
                    BusinessRuler.Student objStudent = new Student(this.dgvDetails, e.Node.Text);
                    objStudent.UpdateDataGrid();
                }
                else if (e.Node.Parent.Text.Equals("课程管理"))
                {
                    SetDataGridStyleForCourse();
                    BusinessRuler.Course objCourse = new Course(this.dgvDetails, e.Node.Text);
                    objCourse.UpdateDataGrid();
                }
                else if (e.Node.Parent.Text.Equals("成绩管理"))
                {
                    SetDataGridStyleForScore();
                    BusinessRuler.Score objScore = new Score(this.dgvDetails, e.Node.Text);
                    objScore.UpdateDataGrid();
                }
                this._currentClassName = e.Node.Text;
            }

        }
        #region setDataGridStyle

        public void SetDataGirdStyleForClass()
        {
            this.dgvDetails.Columns.Clear();
            this.Tag = "Class";
            DataGridViewTextBoxColumn colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn colDirector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn colCurrentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn colEntranceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            colClassName,
            colDirector,
            colCurrentCount,
            colEntranceDate,
            colRemark});

            colClassName.DataPropertyName = "ClassName";
            colClassName.HeaderText = "班级名称";
            colClassName.Name = "colClassName";
            colClassName.ReadOnly = true;
            colClassName.Frozen = false;

            colDirector.DataPropertyName = "Director";
            colDirector.HeaderText = "班主任";
            colDirector.Name = "colDirector";
            colDirector.ReadOnly = true;
            colDirector.Width = 80;
  
            colCurrentCount.DataPropertyName = "CurrentCount";
            colCurrentCount.HeaderText = "学生人数";
            colCurrentCount.Name = "colCurrentCount";
            colCurrentCount.ReadOnly = true;
            colCurrentCount.Width = 80;

            colEntranceDate.DataPropertyName = "EntranceDate";
            colEntranceDate.HeaderText = "建班日期";
            colEntranceDate.Name = "colEntranceDate";
            colEntranceDate.ReadOnly = true;

            colRemark.DataPropertyName = "Remark";
            colRemark.HeaderText = "备注";
            colRemark.Name = "colRemark";
            colRemark.ReadOnly = true;
            colRemark.Width = 450;
        }

        public void SetDataGridStyleForSubject()
        {
            this.dgvDetails.Columns.Clear();
            this.Tag = "Subject";
            DataGridViewTextBoxColumn SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();

            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            SubjectName,
            Period,
            Remark});

            SubjectName.DataPropertyName = "SubjectName";
            SubjectName.HeaderText = "科目名称";
            SubjectName.Name = "SubjectName";
            SubjectName.ReadOnly = true;
            SubjectName.Width = 250;
            SubjectName.Frozen = true;

            Period.DataPropertyName = "Period";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            Period.DefaultCellStyle = dataGridViewCellStyle1;
            Period.HeaderText = "学时数";
            Period.Name = "Period";
            Period.ReadOnly = true;
            Period.Width = 70;
 
            Remark.DataPropertyName = "Remark";
            Remark.HeaderText = "备注";
            Remark.Name = "Remark";
            Remark.ReadOnly = true;
            Remark.Width = 650;
        }

        public void SetDataGridStyleForStudent()
        {
            this.dgvDetails.Columns.Clear();
            this.Tag = "Student";
            DataGridViewTextBoxColumn StudentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Picture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();

            dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            StudentNo,
            StudentName,
            Gender,
            Birthday,
            Picture,
            Remark});

            StudentNo.DataPropertyName = "StudentNo";
            StudentNo.Frozen = true;
            StudentNo.HeaderText = "学号";
            StudentNo.Name = "StudentNo";
            StudentNo.ReadOnly = true;
        
            StudentName.DataPropertyName = "StudentName";
            StudentName.FillWeight = 80F;
            StudentName.Frozen = true;
            StudentName.HeaderText = "姓名";
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            StudentName.Width = 80;
 
            Gender.DataPropertyName = "Gender";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            Gender.DefaultCellStyle = dataGridViewCellStyle1;
            Gender.FillWeight = 60F;
            Gender.HeaderText = "性别";
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.Width = 70;
  
            Birthday.DataPropertyName = "Birthday";
            Birthday.HeaderText = "出生日期";
            Birthday.Name = "Birthday";
            Birthday.ReadOnly = true;
 
            Picture.DataPropertyName = "Picture";
            Picture.HeaderText = "相片";
            Picture.Name = "Picture";
            Picture.ReadOnly = true;
            Picture.ToolTipText = "单击单元格查看相片";
  
            Remark.DataPropertyName = "Remark";
            Remark.FillWeight = 300F;
            Remark.HeaderText = "备注";
            Remark.Name = "Remark";
            Remark.ReadOnly = true;
            Remark.Width = 300;
        }

        public void SetDataGridStyleForCourse()
        {
            this.dgvDetails.Columns.Clear();
            this.Tag = "Course";
            DataGridViewTextBoxColumn SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn BeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn FinishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();

            dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            SubjectName,
            Teacher,
            BeginDate,
            FinishDate,
            Remark});

            SubjectName.DataPropertyName = "SubjectName";
            SubjectName.Frozen = true;
            SubjectName.HeaderText = "科目名称";
            SubjectName.Name = "SubjectName";
            SubjectName.ReadOnly = true;
            SubjectName.Width = 200;
             
            Teacher.DataPropertyName = "Teacher";
            Teacher.HeaderText = "授课老师";
            Teacher.Name = "Teacher";
            Teacher.ReadOnly = true;
 
            BeginDate.DataPropertyName = "BeginDate";
            BeginDate.HeaderText = "开课日期";
            BeginDate.Name = "BeginDate";
            BeginDate.ReadOnly = true;
            BeginDate.Width = 150;
     
            FinishDate.DataPropertyName = "FinishDate";
            FinishDate.HeaderText = "结课日期";
            FinishDate.Name = "FinishDate";
            FinishDate.ReadOnly = true;
            FinishDate.Width = 150;
  
            Remark.DataPropertyName = "Remark";
            Remark.HeaderText = "备注";
            Remark.Name = "Remark";
            Remark.ReadOnly = true;
            Remark.Width = 500;
        }

        public void SetDataGridStyleForScore()
        {
            this.dgvDetails.Columns.Clear();
            this.Tag = "Score";
            DataGridViewTextBoxColumn StudentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Score = new System.Windows.Forms.DataGridViewTextBoxColumn();

            dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            StudentNo,
            StudentName,
            SubjectName,
            Score});
            StudentNo.DataPropertyName = "StudentNo";
            StudentNo.Frozen = true;
            StudentNo.HeaderText = "学号";
            StudentNo.Name = "StudentNo";
            StudentNo.ReadOnly = true;
            StudentNo.Width = 120;
 
            StudentName.DataPropertyName = "StudentName";
            StudentName.Frozen = true;
            StudentName.HeaderText = "姓名";
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            StudentName.Width = 120;
 
            SubjectName.DataPropertyName = "SubjectName";
            SubjectName.HeaderText = "课程名称";
            SubjectName.Name = "SubjectName";
            SubjectName.ReadOnly = true;
            SubjectName.Width = 350;
  
            Score.DataPropertyName = "Score";
            Score.HeaderText = "成绩";
            Score.Name = "Score";
            Score.ReadOnly = true;
            Score.Width = 100;
        }

        #endregion
        
        private void mnuLogOut_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.8;
            DialogResult result = MessageBox.Show("确认要注销系统吗?","注销",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                this.Hide();
				FrmLogin frmLogin = new FrmLogin();
				frmLogin.ShowDialog();
				this.Close();
            }
            else
            {
                this.Opacity = 1.0;
            }
        }

        private void mnuAddClass_Click(object sender, EventArgs e)
        {
            FrmAddClass frm = new FrmAddClass(this.dgvDetails);
            frm.ShowDialog(this);
        }

        private void FrmMain_Activated(object sender, EventArgs e)
        {
            FillData_Load();
        }

        private void mnuBrowseStudent_Click(object sender, EventArgs e)
        {
            if (BusinessRuler.Classes.IsClassExists())
            {
                FrmChooseClass frmChoose = new FrmChooseClass("学生管理");
                frmChoose.ShowDialog();
            }
        }

        private void mnuBrowseCourse_Click(object sender, EventArgs e)
        {
            if (BusinessRuler.Classes.IsClassExists())
            {
                FrmChooseClass frmChoose = new FrmChooseClass("课程管理");
                frmChoose.ShowDialog();
            }
        }

        private void mnuBrowseSubject_Click(object sender, EventArgs e)
        {
            FrmSubject frmSubject = new FrmSubject();
            frmSubject.ShowDialog();
        }

        private void mnuBrowseScore_Click(object sender, EventArgs e)
        {
            if (BusinessRuler.Classes.IsClassExists())
            {
                FrmChooseClass frmChoose = new FrmChooseClass("成绩管理");
                frmChoose.ShowDialog();
            }
        }

        private void mnuTeacherManagement_Click(object sender, EventArgs e)
        {
            FrmTeacher frmTeacher = new FrmTeacher();
            frmTeacher.ShowDialog();
        }

        private void cmuAdd_Click(object sender, EventArgs e)
        {
            if (this.Tag.Equals("Class"))
            {
                FrmAddClass frmAddClass = new FrmAddClass(dgvDetails);
                frmAddClass.ShowDialog();
            }
            else if (this.Tag.Equals("Student"))
            {
                if (BusinessRuler.Classes.isInCapacity(_currentClassName))
                {
                    FrmAddStudent frmAddStudent = new FrmAddStudent(dgvDetails, _currentClassName);
                    frmAddStudent.ShowDialog();
                }
            }
            else if (this.Tag.Equals("Subject"))
            {
                FrmAddSubject frmAddSubject = new FrmAddSubject(this.dgvDetails);
                frmAddSubject.ShowDialog();
            }
            else if (this.Tag.Equals("Course"))
            {
                FrmAddCourse frmAddCourse = new FrmAddCourse(dgvDetails, _currentClassName);
                frmAddCourse.ShowDialog();
            }
            else if (this.Tag.Equals("Score"))
            {
                BusinessRuler.Classes objClass = new BusinessRuler.Classes();
                if (objClass.IsStudentExists(_currentClassName)&&objClass.IsCourseExist(_currentClassName))
                {
                    FrmAddScore frmAddScore = new FrmAddScore(dgvDetails, _currentClassName);
                    frmAddScore.ShowDialog();
                }                
            }
        }

        public bool CheckCondition()
        {
            if ((dgvDetails.Rows.Count == 0) || (dgvDetails.Visible == false))
            {
                MessageBox.Show("当前无任何数据,操作无法执行!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void cmuModify_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            if (this.Tag.Equals("Class"))
            {
                FrmModifyClass frmModifyClass = new FrmModifyClass(dgvDetails);
                frmModifyClass.ShowDialog();
            }
            else if (this.Tag.Equals("Student"))
            {
                FrmModifyStudent frmModifyStudent = new FrmModifyStudent(this.dgvDetails, _currentClassName);
                frmModifyStudent.ShowDialog();
            }
            else if (this.Tag.Equals("Subject"))
            {
                FrmModifySubject frmModifySubject = new FrmModifySubject(dgvDetails);
                frmModifySubject.ShowDialog();
            }
            else if (this.Tag.Equals("Course"))
            {
                FrmModifyCourse frmModifyCourse = new FrmModifyCourse(dgvDetails, _currentClassName);
                frmModifyCourse.ShowDialog();
            }
            else if (this.Tag.Equals("Score"))
            {
                FrmModifyScore frmModifyScore = new FrmModifyScore(dgvDetails, _currentClassName);
                frmModifyScore.ShowDialog();
            }
        }

        private void cmuDelete_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            if (this.Tag.Equals("Class"))
            {
                BusinessRuler.Classes objClass = new BusinessRuler.Classes(this.dgvDetails);
                objClass.DeleteClass(this.dgvDetails.CurrentRow.Cells[0].Value.ToString());  
            }
            else if (this.Tag.Equals("Student"))
            {
                int studentNo = (Int32.Parse(this.dgvDetails.CurrentRow.Cells[0].Value.ToString()));
                string studentName = this.dgvDetails.CurrentRow.Cells[1].Value.ToString();
                BusinessRuler.Student objStudent = new BusinessRuler.Student(this.dgvDetails, _currentClassName);
                objStudent.Delete(studentNo, studentName, _currentClassName);
            }
            else if (this.Tag.Equals("Subject"))
            {
                BusinessRuler.Subject objSubject = new BusinessRuler.Subject(this.dgvDetails);
                objSubject.Delete();
            }
            else if (this.Tag.Equals("Course"))
            {
                BusinessRuler.Course objCourse = new BusinessRuler.Course(this.dgvDetails, _currentClassName);
                objCourse.Delete();
            }
            else if (this.Tag.Equals("Score"))
            {
                BusinessRuler.Score objScore = new BusinessRuler.Score(this.dgvDetails, _currentClassName);
                objScore.Delete();
            }
        }

        private void mnuNewStudent_Click(object sender, EventArgs e)
        {
            if (BusinessRuler.Classes.IsClassExists())
            {
                FrmChooseClass frmChoose = new FrmChooseClass("学生管理");
                frmChoose.ShowDialog();
            }
        }

        private void mnuNewCourse_Click(object sender, EventArgs e)
        {
            if (BusinessRuler.Classes.IsClassExists())
            {
                FrmChooseClass frmChoose = new FrmChooseClass("课程管理");
                frmChoose.ShowDialog();
            }
        }

        private void mnuNewSubject_Click(object sender, EventArgs e)
        {
            FrmAddSubject frmAddSubject = new FrmAddSubject(this.dgvDetails);
            frmAddSubject.ShowDialog();
        }

        private void mnuNewScore_Click(object sender, EventArgs e)
        {
            if (BusinessRuler.Classes.IsClassExists())
            {
                FrmChooseClass frmChoose = new FrmChooseClass("成绩管理");
                frmChoose.ShowDialog();
            }
        }

        private void mnuAddSubject_Click(object sender, EventArgs e)
        {
            FrmAddSubject frmAddSubject = new FrmAddSubject(dgvDetails);
            frmAddSubject.ShowDialog();
        }

        private void mnuUpdateSubject_Click(object sender, EventArgs e)
        {
            FrmModifySubject frmModifySubject = new FrmModifySubject(dgvDetails);
            frmModifySubject.ShowDialog();
        }

        private void dgvDetails_DataSourceChanged(object sender, EventArgs e)
        {
            int recordCount = this.dgvDetails.Rows.Count;
            this.trb5.Text = " 当前共有记录： " + recordCount.ToString() + " 条。";
        }
 
        private void cmiBig_Click(object sender, EventArgs e)
        {
            this.lvwMain.View = View.LargeIcon;
        }

        private void cmiSmall_Click(object sender, EventArgs e)
        {
            this.lvwMain.View = View.SmallIcon;
        }

        private void cmiTitle_Click(object sender, EventArgs e)
        {
            this.lvwMain.View = View.Tile;
        }

        private void cmiList_Click(object sender, EventArgs e)
        {
            this.lvwMain.View = View.List;
        }

        private void lvwMain_DoubleClick(object sender, EventArgs e)
        {
            string name = lvwMain.SelectedItems[0].Text;
            if (name.Equals("班级管理"))
            {
                mnuBrowseClass_Click(sender, e);
            }
            else if (name.Equals("学生管理"))
            {
                mnuBrowseStudent_Click(sender, e);
            }
            else if (name.Equals("课程管理"))
            {
                mnuNewCourse_Click(sender, e);
            }
            else if (name.Equals("科目管理"))
            {
                mnuBrowseSubject_Click(sender, e);
            }
            else if (name.Equals("成绩管理"))
            {
                mnuBrowseScore_Click(sender, e);
            }
            else if (name.Equals("更改密码"))
            {
                mnuChangePwd_Click(sender, e);
            }
            else if (name.Equals("系统数据"))
            {

            }
            else if (name.Equals("注销"))
            {
                mnuLogOut_Click(sender, e);
            }
            else if (name.Equals("退出"))
            {
                mnuExit_Click(sender, e);
            }
        }

        private void tbrReturnMain_Click(object sender, EventArgs e)
        {
            this.dgvDetails.Visible = false;
            this.lvwMain.Visible = true;
            this.trb5.Text = "  感谢你使用本软件！如有任何问题，欢迎你同Ruihua Studio联系! QQ:451626827、Email:ruihua@szswt.cn";
        }

        private void mnuOption_Click(object sender, EventArgs e)
        {
            FrmOptions frmOptions = new FrmOptions();
            frmOptions.ShowDialog();
        }

        private void dgvDetails_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Tag.Equals("Student") && (e.ColumnIndex == 4))
            {
                this.Cursor = System.Windows.Forms.Cursors.Hand;
            }
        }

        private void dgvDetails_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
             this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Tag.Equals("Student"))
            {
                if (e.ColumnIndex != 4)
                {
                    return;
                }
                string fileName = this.dgvDetails.CurrentCell.Value.ToString();
                if (fileName.Trim().Length > 0)
                {
                    Image img = BusinessRuler.ImageManage.GetImageFromServer(fileName);
                    FrmViewImage frmViewImage = new FrmViewImage(img);
                    frmViewImage.Show();
                }
            }
        }

        public string GetTitle()
        {
            string title = null;
            if (this.Tag.Equals("Class"))
            {
                title = "班级信息";
            }
            else if (this.Tag.Equals("Student"))
            {
                title = _currentClassName + "班 学生档案信息";
            }
            else if (this.Tag.Equals("Subject"))
            {
                title = "科目信息";
            }
            else if (this.Tag.Equals("Course"))
            {
                title = _currentClassName + "班 课程信息";
            }
            else if (this.Tag.Equals("Score"))
            {
                title = _currentClassName + "班 学生成绩信息";
            }
            return title;
        }
        private void trbExportReport_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            FrmExportReport frmExportReport = new FrmExportReport(dgvDetails, GetTitle());
            frmExportReport.ShowDialog();
        }

        private void tbrFind_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            dgvDetails.Tag = 0;
            if (this.Tag.Equals("Class"))
            {
                FrmFindClass frmFindClass = new FrmFindClass(dgvDetails);
                frmFindClass.Show();
            }
            else if (this.Tag.Equals("Student"))
            {
                FrmFindStudent frmFindStudent = new FrmFindStudent(dgvDetails);
                frmFindStudent.Show();
            }
            else if (this.Tag.Equals("Subject"))
            {
                FrmFindSubject frmFindSubject = new FrmFindSubject(dgvDetails);
                frmFindSubject.Show();
            }
            else if (this.Tag.Equals("Course"))
            {
                FrmFindCourse frmFindCourse = new FrmFindCourse(dgvDetails, _currentClassName);
                frmFindCourse.Show();
            }
            else if (this.Tag.Equals("Score"))
            {
                FrmFindScore frmFindScore = new FrmFindScore(dgvDetails);
                frmFindScore.Show();
            }
        }

        private void cmuBigiest_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel1Collapsed = true;
            this.cmuBigiest.Visible = false;
            this.cmuNormal.Visible = true;
        }

        private void cmuNormal_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel1Collapsed = false;
            this.cmuBigiest.Visible = true;
            this.cmuNormal.Visible = false;
        }

        #region printing

        private void MyPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool more = MyDataGridViewPrinter.DrawDataGridView(e.Graphics);
            if (more == true)
            {
                e.HasMorePages = true;
            }
        }

        private bool SetupThePrinting()
        {
            string title = GetTitle();
            PrintDialog MyPrintDialog = new PrintDialog();
            MyPrintDialog.AllowCurrentPage = false;
            MyPrintDialog.AllowPrintToFile = false;
            MyPrintDialog.AllowSelection = false;
            MyPrintDialog.AllowSomePages = false;
            MyPrintDialog.PrintToFile = false;
            MyPrintDialog.ShowHelp = false;
            MyPrintDialog.ShowNetwork = false;
            if (MyPrintDialog.ShowDialog() != DialogResult.OK)
            {
                return false;
            }
            MyPrintDocument.DocumentName = title;
            MyPrintDocument.PrinterSettings = MyPrintDialog.PrinterSettings;
            MyPrintDocument.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            MyPrintDocument.DefaultPageSettings.Margins = new Margins(40, 40, 40, 40);

            if (MessageBox.Show("你希望居中打印吗？", "打印居中", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MyDataGridViewPrinter = new DataGridViewPrinter(this.dgvDetails, MyPrintDocument, true, true, title, new Font("Tahoma", 15, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
            }
            else
            {
                MyDataGridViewPrinter = new DataGridViewPrinter(this.dgvDetails, MyPrintDocument, false, true, title, new Font("Tahoma", 15, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
            }
            return true;
        }

        private void trbPrintPreview_Click(object sender, EventArgs e)
        {
            if (!CheckCondition())
            {
                return;
            }
            if (SetupThePrinting())
            {
                PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
                MyPrintPreviewDialog.Document = MyPrintDocument;
                MyPrintPreviewDialog.ShowDialog();
            }
        }

        #endregion

        
    }
}