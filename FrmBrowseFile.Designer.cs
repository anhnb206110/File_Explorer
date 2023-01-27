
namespace FileExplorer
{
    partial class FrmBrowseFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rtbFileInfo = new System.Windows.Forms.RichTextBox();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxFileType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvFile = new System.Windows.Forms.ListView();
            this.clnFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsOpenWith = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.describeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpDiskList = new System.Windows.Forms.FlowLayoutPanel();
            this.tltNavigationButton = new System.Windows.Forms.ToolTip(this.components);
            this.cmsOpenWith.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOpenFile.FlatAppearance.BorderSize = 2;
            this.btnOpenFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOpenFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(632, 506);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(122, 49);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Mở";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(760, 506);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 49);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rtbFileInfo
            // 
            this.rtbFileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbFileInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbFileInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbFileInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFileInfo.Location = new System.Drawing.Point(632, 80);
            this.rtbFileInfo.Name = "rtbFileInfo";
            this.rtbFileInfo.ReadOnly = true;
            this.rtbFileInfo.Size = new System.Drawing.Size(247, 411);
            this.rtbFileInfo.TabIndex = 2;
            this.rtbFileInfo.Text = "";
            // 
            // txtFilename
            // 
            this.txtFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilename.Location = new System.Drawing.Point(118, 497);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(508, 27);
            this.txtFilename.TabIndex = 3;
            this.txtFilename.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilename_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên tệp";
            // 
            // cbxFileType
            // 
            this.cbxFileType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFileType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxFileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFileType.FormattingEnabled = true;
            this.cbxFileType.Items.AddRange(new object[] {
            "Tất cả",
            "PDF (.pdf)",
            "Hình ảnh (.jpg, .png, .jpeg)",
            "Văn bản Word (.doc, .docx)",
            "Văn bản thuần túy (.txt)"});
            this.cbxFileType.Location = new System.Drawing.Point(118, 527);
            this.cbxFileType.Name = "cbxFileType";
            this.cbxFileType.Size = new System.Drawing.Size(508, 28);
            this.cbxFileType.TabIndex = 5;
            this.cbxFileType.SelectedIndexChanged += new System.EventHandler(this.cbxFileType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dạng tệp";
            // 
            // lsvFile
            // 
            this.lsvFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lsvFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnFileName});
            this.lsvFile.ContextMenuStrip = this.cmsOpenWith;
            this.lsvFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvFile.GridLines = true;
            this.lsvFile.HideSelection = false;
            this.lsvFile.Location = new System.Drawing.Point(118, 80);
            this.lsvFile.Name = "lsvFile";
            this.lsvFile.Size = new System.Drawing.Size(508, 411);
            this.lsvFile.TabIndex = 10;
            this.lsvFile.UseCompatibleStateImageBehavior = false;
            this.lsvFile.View = System.Windows.Forms.View.Details;
            this.lsvFile.SelectedIndexChanged += new System.EventHandler(this.lsvFile_SelectedIndexChanged);
            this.lsvFile.DoubleClick += new System.EventHandler(this.btnOpenFile_Click);
            this.lsvFile.Resize += new System.EventHandler(this.lsvFile_Resize);
            // 
            // clnFileName
            // 
            this.clnFileName.Text = "Tên";
            this.clnFileName.Width = 350;
            // 
            // cmsOpenWith
            // 
            this.cmsOpenWith.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOpenWith.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openContextToolStripMenuItem});
            this.cmsOpenWith.Name = "cmsOpenWith";
            this.cmsOpenWith.Size = new System.Drawing.Size(101, 28);
            // 
            // openContextToolStripMenuItem
            // 
            this.openContextToolStripMenuItem.Name = "openContextToolStripMenuItem";
            this.openContextToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.openContextToolStripMenuItem.Text = "Mở";
            this.openContextToolStripMenuItem.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(177, 46);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(702, 23);
            this.txtAddress.TabIndex = 11;
            this.txtAddress.Text = "C:\\";
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::FileExplorer.Properties.Resources.picLeftArrow;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(15, 38);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 38);
            this.btnBack.TabIndex = 7;
            this.tltNavigationButton.SetToolTip(this.btnBack, "Quay trở lại thư mục trước");
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::FileExplorer.Properties.Resources.picRightArrow;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(64, 38);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 38);
            this.btnNext.TabIndex = 8;
            this.tltNavigationButton.SetToolTip(this.btnNext, "Thư mục kế tiếp");
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUp.BackgroundImage = global::FileExplorer.Properties.Resources.picUpArrow;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Location = new System.Drawing.Point(111, 38);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(40, 38);
            this.btnUp.TabIndex = 0;
            this.tltNavigationButton.SetToolTip(this.btnUp, "Thư mục cha");
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.fileToolStripMenuItem.Text = "Tùy chọn";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.openToolStripMenuItem.Text = "Mở";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.exitToolStripMenuItem.Text = "Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem,
            this.detailToolStripMenuItem,
            this.tileToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.viewToolStripMenuItem.Text = "Dạng xem";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.listToolStripMenuItem.Text = "Danh sách";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Checked = true;
            this.detailToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.detailToolStripMenuItem.Text = "Chi tiết";
            this.detailToolStripMenuItem.Click += new System.EventHandler(this.detailToolStripMenuItem_Click);
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.tileToolStripMenuItem.Text = "Ngói";
            this.tileToolStripMenuItem.Click += new System.EventHandler(this.tileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.describeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.helpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // describeToolStripMenuItem
            // 
            this.describeToolStripMenuItem.Name = "describeToolStripMenuItem";
            this.describeToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.describeToolStripMenuItem.Text = "Ứng dụng duyệt và mở một số loại tệp";
            // 
            // flpDiskList
            // 
            this.flpDiskList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpDiskList.AutoScroll = true;
            this.flpDiskList.Location = new System.Drawing.Point(12, 80);
            this.flpDiskList.Name = "flpDiskList";
            this.flpDiskList.Size = new System.Drawing.Size(100, 411);
            this.flpDiskList.TabIndex = 16;
            // 
            // FrmBrowseFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(891, 567);
            this.Controls.Add(this.flpDiskList);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lsvFile);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxFileType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.rtbFileInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "FrmBrowseFile";
            this.Text = "File Explorer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BrowseFile_FormClosing);
            this.Load += new System.EventHandler(this.BrowerFile_Load);
            this.cmsOpenWith.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtbFileInfo;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFileType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvFile;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ColumnHeader clnFileName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem describeToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpDiskList;
        private System.Windows.Forms.ToolTip tltNavigationButton;
        private System.Windows.Forms.ContextMenuStrip cmsOpenWith;
        private System.Windows.Forms.ToolStripMenuItem openContextToolStripMenuItem;
    }
}

