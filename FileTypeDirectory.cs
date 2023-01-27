using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer
{
    public class FileTypeDirectory : IFileType
    {
        string filename;
        public FileTypeDirectory(string filename)
        {
            this.filename = filename;
        }

        #region Thực thi interface IFileType
        public string Filename => filename;

        public void Accept(IVisitor visitor)
        {
            visitor.OpenDirFile(this);
        }

        public void ShowInfo()
        {
            Program.FrmManager.Browser.SetRtbFileInfo("Đây là một thư mục.");
        }
        #endregion
    }
}
