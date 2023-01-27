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
    public partial class FrmImageViewer : Form
    {
        IMediator m_mediator;

        public IMediator Mediator
        {
            get => m_mediator;
            set => m_mediator = value;
        }

        public FrmImageViewer()
        {
            InitializeComponent();
        }
        private void ImageViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        /// <summary>
        /// Đặt hình ảnh cho picture box
        /// </summary>
        /// <param name="img"> Đối tượng hình ảnh </param>
        public void SetImage(FileTypeImage img)
        {
            this.Text = img.Filename;
            pbxImageViewer.Image = Image.FromFile(img.Filename);
            float _ratio = (float)((float)pbxImageViewer.Image.Height /
                        (Screen.PrimaryScreen.Bounds.Height * 0.7));
            this.Size = new Size((int)(pbxImageViewer.Image.Width / _ratio),
                                 (int)(pbxImageViewer.Image.Height / _ratio));
        }

        #region Mediator
        public void Send(FileTypeImage img)
        {
            m_mediator.Show(img, this);
        }

        public void ReactMediator(FileTypeImage img)
        {
            this.SetImage(img);
            this.Show();
        }
        #endregion

    }
}
