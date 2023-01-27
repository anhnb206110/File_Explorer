using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public interface IMediator
    {
        void Show(IFileType file, Form form);
    }
}
