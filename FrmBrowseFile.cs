using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileExplorer
{
    public partial class FrmBrowseFile : Form
    {
        IVisitor m_visitor = new VisitorOpener();
        IMediator m_mediator;

        public IMediator Mediator
        {
            get => m_mediator;
            set => m_mediator = value;
        }

        Stack<string> m_prevAdd = new Stack<string>();
        Stack<string> m_nextAdd = new Stack<string>();

        public FrmBrowseFile()
        {
            InitializeComponent();
        }

        private void BrowerFile_Load(object sender, EventArgs e)
        {
            var label = new Label()
            {
                Height = 1,
                Dock = DockStyle.Bottom,
                BackColor = Color.Aqua
            };
            txtAddress.Controls.Add(label);
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 2,
                                 Screen.PrimaryScreen.Bounds.Height / 2);
            cbxFileType.SelectedIndex = 0;
            LoadDiskList();
        }

        private void BrowseFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.FrmManager.TxtViewer.Visible || Program.FrmManager.ImgViewer.Visible)
            {
                DialogResult _dr = MessageBox.Show("Đóng tất cả cửa sổ?", "Đóng", 
                                                    MessageBoxButtons.OKCancel,
                                                    MessageBoxIcon.Question);
                switch (_dr)
                {
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        Program.FrmManager.ImgViewer.Hide();
                        Program.FrmManager.TxtViewer.Hide();
                        Close();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            string address;
            try
            {
                address = txtAddress.Text + txtFilename.Text;
                if (File.GetAttributes(address)
                        .HasFlag(FileAttributes.Directory))
                {
                    UpdateAddressBox(address + '\\');
                }
                else
                {
                    IFileType file = Program.TypeOfFile(address);
                    file.Accept(m_visitor);
                }
            }
            catch (IOException _e)
            {
                MessageBox.Show(_e.Message, 
                                "Lỗi", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
            //txtFilename.Clear();
        }

        #region Event handle
        private void lsvFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvFile.SelectedItems.Count == 1)
            {
                txtFilename.Text = lsvFile.SelectedItems[0].Text.Replace("\\","");
                IFileType file = Program.TypeOfFile(txtAddress.Text 
                                                    + lsvFile.SelectedItems[0].Text);
                file.ShowInfo();
            }
            else if (lsvFile.SelectedItems.Count > 1)
            {
                SetRtbFileInfo("Đã chọn " + lsvFile.SelectedItems.Count.ToString() + " tệp");
            }
            else
            {
                SetRtbFileInfo(null);
            }
        }
        private void lsvFile_Resize(object sender, EventArgs e)
        {
            lsvFile.Columns[0].Width = lsvFile.Width - 20;
        }
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            txtAddress.Text = txtAddress.Text.Replace(@"\\", @"\");
        }
        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateListView();
            }
        }
        private void txtFilename_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOpenFile_Click(sender, e);
            }
        }
        private void cbxFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListView();
        }
        #endregion

        #region Navigation
        private void btnDisk_Click(object sender, EventArgs e)
        {
            UpdateAddressBox(((Button)sender).Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (m_prevAdd.Count > 0 && m_prevAdd.Peek() != txtAddress.Text)
            {
                m_nextAdd.Push(txtAddress.Text);
                txtAddress.Text = m_prevAdd.Pop();
                UpdateListView();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (m_nextAdd.Count > 0 && m_nextAdd.Peek() != txtAddress.Text)
            {
                m_prevAdd.Push(txtAddress.Text);
                txtAddress.Text = m_nextAdd.Pop();
                UpdateListView();
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text.EndsWith(@":\"))
            {
                return; // Directory (C:\, D:\,...) then stop
            }
            else
            {
                DirectoryInfo _di = Directory.GetParent(txtAddress.Text
                                             .Substring(0, txtAddress.Text.Length - 1));
                if (_di != null)
                {
                    if (txtAddress.Text != _di.FullName + '\\')
                    {
                        UpdateAddressBox(_di.FullName + '\\');
                    }
                }
            } 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Helper method
        /// <summary>
        /// Tạo các nút để với nhãn là tên các ổ đĩa và gán sự kiện nhấn nút
        /// </summary>
        private void LoadDiskList()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in allDrives)
            {
                Button btnDisk = new Button();
                btnDisk.Click += btnDisk_Click;
                btnDisk.Text = drive.Name;
                btnDisk.FlatStyle = FlatStyle.Flat;
                btnDisk.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
                btnDisk.FlatAppearance.BorderSize = 1;
                btnDisk.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
                btnDisk.Size = new Size(flpDiskList.Width - 25, 50);
                flpDiskList.Controls.Add(btnDisk);
            }
            UpdateAddressBox(allDrives[0].Name);
        }

        /// <summary>
        /// Cập nhật địa chỉ mới cho thanh địa chỉ và thêm lịch sử vào stack
        /// </summary>
        /// <param name="newAddress"></param>
        private void UpdateAddressBox(string newAddress)
        {
            if (newAddress != txtAddress.Text)
            {
                m_prevAdd.Push(txtAddress.Text);
                txtAddress.Text = newAddress;
                if (m_nextAdd.Count > 0)
                {
                    m_nextAdd.Clear();
                }
                if (!UpdateListView())
                {
                    txtAddress.Text = m_prevAdd.Peek();
                };
            }
        }

        /// <summary>
        /// Cập nhật lại danh sách tệp (không hiện thị tệp bị ẩn)
        /// </summary>
        private bool UpdateListView()
        {
            try
            {
                string[] _dirs = Directory.GetDirectories(txtAddress.Text);
                string[] _files = Directory.GetFiles(txtAddress.Text);
                lsvFile.Items.Clear(); 
                foreach (string dir in _dirs)
                {
                    if (!(new DirectoryInfo(dir)).Attributes.HasFlag(FileAttributes.Hidden))
                        lsvFile.Items.Add(dir.Substring(txtAddress.Text.Length));
                }
                foreach (string file in _files)
                {
                    if (!(new DirectoryInfo(file)).Attributes.HasFlag(FileAttributes.Hidden))
                        lsvFile.Items.Add(file.Substring(txtAddress.Text.Length));
                }
                UpdateFilter();
                SetRtbFileInfo(string.Format("Danh sách có {0} item", lsvFile.Items.Count));
                return true;
            }
            catch (DirectoryNotFoundException e) 
            {
                string errorMesssage = e.Message;
                MessageBox.Show("Địa chỉ không hợp lệ", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// Cập nhật lại danh sách tệp theo bộ lọc
        /// (Có thể tạo interfaces để lọc theo loại khác nhau)
        /// </summary>
        private void UpdateFilter()
        {
            List<string> _items = new List<string>();
            foreach (ListViewItem s in lsvFile.Items)
            {
                _items.Add(s.Text);
            }
            switch (cbxFileType.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    lsvFile.Items.Clear();
                    lsvFile.Items.AddRange(_items.Where(i =>
                                                        i.EndsWith(".pdf"))
                                 .Select(c => new ListViewItem(c)).ToArray());
                    break;
                case 2:
                    lsvFile.Items.Clear();
                    lsvFile.Items.AddRange(_items.Where(i => 
                                                        i.EndsWith(".jpg") ||
                                                        i.EndsWith(".png") ||
                                                        i.EndsWith(".jpeg"))
                                 .Select(c => new ListViewItem(c)).ToArray());
                    break;
                case 3:
                    lsvFile.Items.Clear();
                    lsvFile.Items.AddRange(_items.Where(i => 
                                                        i.EndsWith(".doc") ||
                                                        i.EndsWith(".docx"))
                                 .Select(c => new ListViewItem(c)).ToArray());
                    break;
                case 4:
                    lsvFile.Items.Clear();
                    lsvFile.Items.AddRange(_items.Where(i =>
                                                        i.EndsWith(".txt"))
                                 .Select(c => new ListViewItem(c)).ToArray());
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Thay đổi nội dung văn bản trong phần thông tin tệp
        /// </summary>
        /// <param name="info"> Nội dung </param>
        public void SetRtbFileInfo(string info = null)
        {
            if (info != null)
            {
                rtbFileInfo.Text = info;
            }    
            else
            {
                rtbFileInfo.Clear();
            }
        }
        /// <summary>
        /// Tạo đối tượng IFileType từ đường dẫn đến tệp
        /// </summary>
        /// <param name="path"> Đường dẫn đến tệp </param>
        /// <returns> Đối tượng IFileType tương ứng với đuôi tệp </returns>
        #endregion

        #region Menu strip
        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lsvFile.View = View.List;
            listToolStripMenuItem.Checked = true;
            detailToolStripMenuItem.Checked = false;
            tileToolStripMenuItem.Checked = false;
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lsvFile.View = View.Details;
            listToolStripMenuItem.Checked = false;
            detailToolStripMenuItem.Checked = true;
            tileToolStripMenuItem.Checked = false;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lsvFile.View = View.Tile;
            listToolStripMenuItem.Checked = false;
            detailToolStripMenuItem.Checked = false;
            tileToolStripMenuItem.Checked = true;
        }
        #endregion

        #region Mediator
        public void Send(IFileType file)
        {
            m_mediator.Show(file, this);
        }

        public void ReactMediator(FileTypeDirectory dir)
        {
            txtAddress.Text = dir.Filename;
            UpdateListView();
        }
        #endregion
    }
}
