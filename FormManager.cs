using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace FileExplorer
{

    class FormManager : IMediator
    {
        FrmImageViewer m_imgViewer;
        FrmTextViewer m_txtViewer;
        FrmBrowseFile m_browser;

        public FrmImageViewer ImgViewer { 
            get => m_imgViewer;
            set => m_imgViewer = value; 
        }

        public FrmTextViewer TxtViewer {
            get => m_txtViewer;
            set => m_txtViewer = value; 
        }

        public FrmBrowseFile Browser
        {
            get => m_browser;
            set => m_browser = value;
        }

        public FormManager()
        {
            m_browser = new FrmBrowseFile();
            m_txtViewer = new FrmTextViewer();
            m_imgViewer = new FrmImageViewer();

            m_browser.Mediator = this;
            m_txtViewer.Mediator = this;
            m_imgViewer.Mediator = this;
        }

        public void Show(IFileType file, Form form)
        {
            if (form == m_txtViewer)
            {
                m_txtViewer.ReactMediator((FileTypeText)file);
            }
            else if (form == m_imgViewer)
            {
                m_imgViewer.ReactMediator((FileTypeImage)file);
            }
            else if (form == m_browser)
            {
                m_browser.ReactMediator((FileTypeDirectory)file);
            }
        }
    }
}
