using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public class FileTypeOther : IFileType
    {
        string filename;
        public FileTypeOther(string filename)
        {
            this.filename = filename;
        }

        #region Thực thi interface IFileType
        public string Filename => filename;
        public void Accept(IVisitor visitor)
        {
            visitor.OpenOtherFile(this);
        }
        public void ShowInfo()
        {
            Program.FrmManager.Browser.SetRtbFileInfo("Tôi chưa biết dạng tệp này :(");
        }
        #endregion


        public static void OpenByWindows(IFileType file)
        {
            DialogResult result = MessageBox.Show("Mở dưới dạng mặc định của Windows?",
                                                  "Mở tệp",
                                                  MessageBoxButtons.YesNo, 
                                                  MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    System.Diagnostics.Process.Start(file.Filename);
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }
    }
}
