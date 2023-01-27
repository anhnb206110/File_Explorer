using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer
{
    public interface IVisitor
    {
        void OpenTxtFile(FileTypeText file);
        void OpenPdfFile(FileTypePDF pdf);
        void OpenDirFile(FileTypeDirectory dir);
        void OpenImageFile(FileTypeImage img);
        void OpenOtherFile(FileTypeOther file);
    }
}
