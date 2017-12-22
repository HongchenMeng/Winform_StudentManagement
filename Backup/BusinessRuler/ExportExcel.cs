using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
namespace BusinessRuler
{
    public class ExportExcel
    {
        public static void DoForExcel(DataGridView dgv, string reportTitle)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
            if (xlApp == null)
            {
                MessageBox.Show("Excel�޷�����", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int rowIndex = 2;
            int colIndex = 0;
            Microsoft.Office.Interop.Excel.Workbook xlBook = xlApp.Workbooks.Add(true);
            Microsoft.Office.Interop.Excel.Range range = xlApp.get_Range(xlApp.Cells[1, 1], xlApp.Cells[1, dgv.ColumnCount]);
            range.MergeCells = true;
            xlApp.ActiveCell.FormulaR1C1 = reportTitle;
            xlApp.ActiveCell.Font.Size = 18;
            xlApp.ActiveCell.Font.Bold = true;

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                colIndex = colIndex + 1;
                xlApp.Cells[2, colIndex] = column.HeaderText;
            }

            for (int row = 0; row < dgv.Rows.Count; row++)
            {
                rowIndex = rowIndex + 1;
                for (int col = 0; col < dgv.Columns.Count; col++)
                {
                    xlApp.Cells[rowIndex, col + 1] = dgv.Rows[row].Cells[col].Value.ToString();
                }
            }

            xlApp.get_Range(xlApp.Cells[2, 1], xlApp.Cells[2, dgv.Columns.Count]).Font.Bold = true;
            xlApp.get_Range(xlApp.Cells[2, 1], xlApp.Cells[rowIndex, colIndex]).Borders.LineStyle = 1;
            xlApp.Cells.EntireColumn.AutoFit();
            xlApp.Cells.VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            xlApp.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            try
            {
                xlApp.Save(System.DateTime.Now.Millisecond.ToString());
            }
            catch
            {

            }
            finally
            {
                xlApp.Quit();
            }
        }

        public static void DoForText(DataGridView dgv,string reportTitle)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "�������";
            dlg.Filter = "�ı��ļ�(*.txt)|*.txt";
            if (DialogResult.OK == dlg.ShowDialog())
            {
                //��������������ݵ���󳤶ȣ��Ա㰴��ʽ����
                int[] colContentLength = new int[dgv.ColumnCount];
                for (int row = 0; row < dgv.Rows.Count; row++)
                {
                    for (int col = 0; col < dgv.ColumnCount; col++)
                    {  
                        if (dgv.Rows[row].Cells[col].Value.ToString().Length > colContentLength[col])
                        {
                            colContentLength[col] = dgv.Rows[row].Cells[col].Value.ToString().Length;
                        }
                    }
                }

                string fileName = dlg.FileName;
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                //ͨ������д�ļ�
                try
                {
                    sw.WriteLine(reportTitle);
                    sw.WriteLine();
                    sw.WriteLine("----------------------------------------------------------");
                    //д����
                    int position = 0;
                    foreach (DataGridViewColumn column in dgv.Columns)
                    {
                        sw.Write(column.HeaderText.PadRight(colContentLength[position++] + 4));
                    }
                    //д����
                    for (int row = 0; row < dgv.Rows.Count; row++)
                    {
                        sw.WriteLine();
                        for (int col = 0; col < dgv.ColumnCount; col++)
                        {
                            sw.Write(dgv.Rows[row].Cells[col].Value.ToString().PadRight(colContentLength[col] + 8));
                        }
                    }
                    sw.WriteLine();
                    sw.WriteLine("----------------------------------------------------------");
                    sw.Flush();
                }
                catch
                {
                    MessageBox.Show("�����ļ����������ԣ�", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                { 
                   sw.Close();
                   fs.Close();  
                }
               
            }
        }


    }
}
