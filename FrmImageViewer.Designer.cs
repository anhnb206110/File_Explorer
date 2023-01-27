
namespace FileExplorer
{
    partial class FrmImageViewer
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
            this.pbxImageViewer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImageViewer
            // 
            this.pbxImageViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxImageViewer.Location = new System.Drawing.Point(12, 35);
            this.pbxImageViewer.Name = "pbxImageViewer";
            this.pbxImageViewer.Size = new System.Drawing.Size(776, 403);
            this.pbxImageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImageViewer.TabIndex = 0;
            this.pbxImageViewer.TabStop = false;
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxImageViewer);
            this.Name = "ImageViewer";
            this.Text = "ImageViewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImageViewer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImageViewer;
    }
}