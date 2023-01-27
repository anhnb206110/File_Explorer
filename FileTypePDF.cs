using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer
{
    public class FileTypePDF : IFileType
    {
        string filename;
        public FileTypePDF(string filename)
        {
            this.filename = filename;
        }

        #region Thực thi interface IFileType
        public string Filename => filename;
        public void Accept(IVisitor visitor)
        {
            visitor.OpenPdfFile(this);
        }

        public void ShowInfo()
        {
            Program.FrmManager.Browser.SetRtbFileInfo(string.Format(
                "Đây là file PDF có tên '{0}'. Bạn có thể mở nó bằng Microsoft Edge!"
                , filename));
        }
        #endregion

        public void Send()
        {

        }
    }
}
