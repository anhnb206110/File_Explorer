using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class FrmTextViewer : Form
    {
        IMediator m_mediator;
        public IMediator Mediator
        {
            get => m_mediator;
            set => m_mediator = value;
        }

        public FrmTextViewer()
        {
            InitializeComponent();
        }

        private void TextViewer_Load(object sender, EventArgs e)
        {

        }

        private void TextViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void SetContent(FileTypeText txt)
        {
            this.Text = txt.Filename;
            rtbText.Text = System.IO.File.ReadAllText(txt.Filename);
        }

        public void ShowAsText(IFileType file)
        {
            DialogResult result = MessageBox.Show("Mở dưới dạng văn bản?",
                                                  "Mở tệp",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    Program.FrmManager.TxtViewer.ReactMediator(new FileTypeText(file.Filename));
                    break;
                case DialogResult.No:
                    FileTypeOther.OpenByWindows(file);
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }
        }

        #region Mediator
        public void Send(FileTypeText txt)
        {
            m_mediator.Show(txt, this);
        }

        public void ReactMediator(FileTypeText txt)
        {
            this.SetContent(txt);
            this.Show();
        }
        #endregion
    }
}
