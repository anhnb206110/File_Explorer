using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer
{
    public class FileTypeText : IFileType
    {
        string filename;
        public FileTypeText(string filename)
        {
            this.filename = filename;
        }

        #region Thực thi interface IFileType
        public string Filename => filename;
        public void Accept(IVisitor visitor)
        {
            visitor.OpenTxtFile(this);
        }
        public void ShowInfo()
        {
            Program.FrmManager.Browser.SetRtbFileInfo(string.Format(
                "Đây là một tệp văn bản '{0}'. Để mở nó hãy nhấn nút 'Mở'.", filename));
        }
        #endregion
    }
}
