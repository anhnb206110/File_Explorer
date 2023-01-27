using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileExplorer
{
    static class Program
    {
        static FormManager _manager = null;
 
        public static FormManager FrmManager { get => _manager; }
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _manager = new FormManager();
            Application.Run(_manager.Browser);
        }

        /// <summary>
        /// Tạo ra lớp tệp ứng với đuôi tệp
        /// </summary>
        /// <param name="path">Đường dẫn đến tệp</param>
        /// <returns></returns>
        public static IFileType TypeOfFile(string path)
        {
            if (File.GetAttributes(path)
                    .HasFlag(FileAttributes.Directory))
            {
                return new FileTypeDirectory(path);
            }
            else if (path.EndsWith(".pdf"))
            {
                return new FileTypePDF(path);
            }
            else if (path.EndsWith(".txt"))
            {
                return new FileTypeText(path);
            }
            else if (path.EndsWith(".jpg")
                    || path.EndsWith(".png")
                    || path.EndsWith(".jpeg"))
            {
                return new FileTypeImage(path);
            }
            else
            {
                return new FileTypeOther(path);                
            }
        }
    }
}
