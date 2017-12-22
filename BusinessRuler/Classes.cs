using System;
using System.Windows.Forms;
using DataAccess;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace BusinessRuler
{ 
	public class Classes
	{ 
        private DataGridView _dgvClass;

        public Classes(DataGridView dgv)
        {
            _dgvClass = dgv;
        }

        public Classes()
        { 
        
        }

        //验证系统是否有班级
        public static bool IsClassExists()
        {
            if (DataAccess.Classes.IsClassExists().HasRows)
            {
                return true;
            }
            else
            {
                MessageBox.Show("目前还没有班级，请首先创建班级", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        //验证该班是否有学生
        public bool IsStudentExists(string className)
        {
            DataAccess.Classes objClass = DataAccess.Classes.CreateInstance(className);
            if (objClass.CurrentCount > 0 )
            { 
                return true;
            }
            else
            {
                MessageBox.Show("该班目前还没有学生，无法进行成绩管理，请首先添加学生！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        //验证该班学生人数是否已超过额定
        public static bool isInCapacity(string className)
        {
            int studentCapacity = Int32.Parse(BusinessRuler.ReaderWirteConfig.GetValueByKey("studentCapaticyInClass"));
            DataAccess.Classes objClass = DataAccess.Classes.CreateInstance(className);
            if (objClass.CurrentCount == studentCapacity )
            {
                MessageBox.Show("该班学生人数已满！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //验证班级名是否已存在
        public static bool CheckExists(string className)
        {
            return DataAccess.Classes.CheckExists(className).HasRows;
        }

        //检查该班是否已开课
        public bool IsCourseExist(string className)
        {
            DataAccess.Classes objClass = new DataAccess.Classes(className);
            if (objClass.FillByAllSubjectName().Tables[0].Rows.Count > 0 )
            {
                return true;
            }
            else
            {
                MessageBox.Show(className+ " 班尚无课程，无法进行成绩管理，请先添加课程！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }

        //更新数据网格的显示
        public void UpdateDataGrid()
        {
            if (this._dgvClass != null)
            {
                DataSet objDataSet = DataAccess.Classes.FillByAllClass();
                this._dgvClass.DataSource = objDataSet.Tables[0];
            }
        }

        //添加班级
        public void AddClass(string className, string director, DateTime entranceDate, string remark)
        {
            //首先判断班级名称是否已存在
            if (CheckExists(className))
            {
                MessageBox.Show("班级名" + className + "已存在，请重新输入班级名！", "班级名已存在", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DataAccess.Classes.CreateClass(className, director, entranceDate, remark) > 0)
                {
                    UpdateDataGrid();
                    MessageBox.Show("成功添加班级！", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //修改班级
        public void ModifyClass(string className, string director,DateTime entranceDate, string remark)
        {
            DataAccess.Classes objClass = new DataAccess.Classes(className);
            objClass.Director = director;
            objClass.EntranceDate = entranceDate;
            objClass.Remark = remark;
            if (objClass.Update() > 0)
            {
                UpdateDataGrid();
                MessageBox.Show("修改班级资料成功！", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //删除班级
        public void DeleteClass(string className)
        {
            if (!CheckExists(className))
            {
                MessageBox.Show("班级名" + className + "不存在，请重新输入班级名！", "班级名不存在", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("真的要删除班级' " + className + " '吗?\n 删除该班时，将同时删除该班所有学生的档案及相关课程、成绩的记录，确定要继续吗？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    DataAccess.Classes objClass = new DataAccess.Classes(className);
                    if (objClass.Delete() > 0)
                    {
                        UpdateDataGrid();
                        MessageBox.Show("成功删除班级' " + className + " '!", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        public void FillCboByAllClassName(ComboBox cbo, int position)
        {
            cbo.Items.Clear();
            DataTable classNames = DataAccess.Classes.GetAllClassName();
            foreach (DataRow row in classNames.Rows)
            {
                cbo.Items.Add(row[0].ToString());
            }
            cbo.SelectedIndex = position;
        }

        public void FillCboByAllClassName(ComboBox cbo, string theClassName)
        {
            cbo.Items.Clear();
            int position = 0;
            int i = 0;
            DataTable classNames = DataAccess.Classes.GetAllClassName();
            foreach(DataRow row in classNames.Rows)
            {
                cbo.Items.Add(row[0].ToString());
                if (row[0].ToString().Equals(theClassName))
                {
                    position = i;
                }
                i++;
            }
            cbo.SelectedIndex = position;
        }

        //查找班级
        public static void FindByClassName(DataGridView dgv, string className)
        {
            for (int row = 0; row < dgv.Rows.Count; row++)
            {
                
                if (dgv.Rows[row].Cells["colClassName"].Value.ToString().Equals(className))
                {  
                    dgv.Rows[row].Selected = true;
                    return ;
                }
            }
            MessageBox.Show("已到记录末尾！", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //按班主任查找
        public static void FindByDirector(DataGridView dgv, string director,bool useMatch)
        {
            for (int row = Int32.Parse(dgv.Tag.ToString()); row < dgv.Rows.Count; row++)
            {
                bool condition = dgv.Rows[row].Cells["colDirector"].Value.ToString().Equals(director);
                if (useMatch)
                {
                    condition = dgv.Rows[row].Cells["colDirector"].Value.ToString().Contains(director);
                }
                if (condition)
                {
                    dgv.Rows[row].Selected = true;
                    dgv.Tag = (row+1).ToString();
                    return ;
                }
            }
            MessageBox.Show("已到记录末尾！", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv.Tag = 0;
        }

        //按建班日期查找
        public static void FindByDate(DataGridView dgv, DateTime startDate, DateTime finishDate)
        {
            for (int row = Int32.Parse(dgv.Tag.ToString()); row < dgv.Rows.Count; row++)
            {
                DateTime dateValue = DateTime.Parse(dgv.Rows[row].Cells["colEntranceDate"].Value.ToString());
                if (dateValue >= startDate && dateValue <= finishDate)
                {
                    dgv.Rows[row].Selected = true;
                    dgv.Tag = (row + 1).ToString();
                    return;
                }
            }
            MessageBox.Show("已到记录末尾！", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv.Tag = 0;
        }




	}
}
