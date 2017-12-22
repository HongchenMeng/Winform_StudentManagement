using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace BusinessRuler
{
    public class ImageManage
    {
        public static bool CheckImageSize(string fileName)
        {
            int imageCapacity = Int32.Parse(BusinessRuler.ReaderWirteConfig.GetValueByKey("imageSize"));
            //检查图片大小是否符合要求
            FileInfo f = new FileInfo(fileName);
            if (f.Length > imageCapacity * 1024)
            {
                MessageBox.Show("相片文件大小不可超过" + imageCapacity.ToString() + "K!", "图片太大", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static Image GetImageFromServer(string fileName)
        {
            Image img = null;
            string filePath = Application.StartupPath + "\\Image\\" + fileName;
            try
            {
                FileStream fs = File.OpenRead(filePath);
                img = Image.FromStream(fs);
                fs.Close();
            }
            catch (IOException ie)
            {
                MessageBox.Show(ie.Message);
            }
            return img;
        }

        public static Image GetImageFromLocal(string fileName)
        {
            Image img = null;
            try
            {
                FileStream fs = File.OpenRead(fileName);
                img = Image.FromStream(fs);
                fs.Close();
            }
            catch (IOException ie)
            {
                MessageBox.Show(ie.Message);
            }
            return img;
        }

        //将图片放在服务器上
        public static void CopyImageFileToServer(string originalFile, string newFile)
        {
            if (originalFile.Equals(""))
            {
                return;
            }
            else
            {
                string filePath = Application.StartupPath + "\\Image\\" + newFile;
                int sizeBuffer = 1024;
                byte[] buffer = new byte[sizeBuffer];
                FileStream fsReader = new FileStream(originalFile, FileMode.Open, FileAccess.Read);
                FileStream fsWriter = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                BufferedStream bsReader = new BufferedStream(fsReader);
                BufferedStream bsWriter = new BufferedStream(fsWriter);
                try
                {
                    while (bsReader.Read(buffer, 0, buffer.Length) > 0)
                    {
                        bsWriter.Write(buffer, 0, buffer.Length);
                    }
                }
                catch (IOException ie)
                {
                    MessageBox.Show(ie.Message);
                }
                finally
                {
                    bsReader.Close();
                    bsWriter.Close();
                }
            }
        }

        public static void UpdateImageFile(string originalFile, string newFile)
        {
            CopyImageFileToServer(originalFile, newFile);
        }

    }
}
