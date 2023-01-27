using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer
{
    public class FileTypeImage : IFileType
    {
        string filename;
        public FileTypeImage(string filename)
        {
            this.filename = filename;
        }

        #region Thực thi interface IFileType
        public string Filename => filename;

        public void Accept(IVisitor visitor)
        {
            visitor.OpenImageFile(this);
        }

        public void ShowInfo()
        {
            Program.FrmManager.Browser
                   .SetRtbFileInfo("Đây là một bức ảnh. Nhấn vào 'Mở' để xem.");
        }
        #endregion
    }
}
