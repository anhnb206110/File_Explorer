using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer
{
    /// <summary>
    /// Thực thi của interface IVisitor
    /// </summary>
    class VisitorOpener : IVisitor
    {
        public void OpenDirFile(FileTypeDirectory dir)
        {
            //Program.FrmManager.Browser.ReactMediator(dir);
            Program.FrmManager.Browser.Send(dir);
        }

        public void OpenPdfFile(FileTypePDF pdf)
        {
            System.Diagnostics.Process.Start(pdf.Filename);
        }

        public void OpenTxtFile(FileTypeText txt)
        {
            //Program.FrmManager.TxtViewer.ReactMediator(txt);
            Program.FrmManager.TxtViewer.Send(txt);
        }

        public void OpenImageFile(FileTypeImage img)
        {
            //Program.FrmManager.ImgViewer.ReactMediator(img);
            Program.FrmManager.ImgViewer.Send(img);
        }

        public void OpenOtherFile(FileTypeOther other)
        {
            Program.FrmManager.TxtViewer.ShowAsText(other);
        }
    }
}
