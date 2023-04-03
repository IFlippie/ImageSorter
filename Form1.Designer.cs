
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ImageSorter
{
    partial class Form1
    {
        private PictureBox onlyPictureBox;
        private FolderBrowserDialog imageFolderDialog, recieveImageDialog;
        private List<Button> folderButtons;
        private string[] allImages, allDirectories;
        private int imageCounter;
        private bool imagesFolderSelected, recievedImageSelected;
        private Button imageFolderBtn;
        private Button recieveFolderBtn;
        private TextBox imageFolderTb;
        private TextBox recieveFolderTb;
        private Button DirImageBtn;
        private Button deleteImageBtn;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.onlyPictureBox = new System.Windows.Forms.PictureBox();
            this.imageFolderBtn = new System.Windows.Forms.Button();
            this.recieveFolderBtn = new System.Windows.Forms.Button();
            this.imageFolderTb = new System.Windows.Forms.TextBox();
            this.recieveFolderTb = new System.Windows.Forms.TextBox();
            this.DirImageBtn = new System.Windows.Forms.Button();
            this.deleteImageBtn = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.onlyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // onlyPictureBox
            // 
            this.onlyPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.onlyPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.onlyPictureBox.Location = new System.Drawing.Point(535, 53);
            this.onlyPictureBox.Name = "onlyPictureBox";
            this.onlyPictureBox.Size = new System.Drawing.Size(74, 56);
            this.onlyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.onlyPictureBox.TabIndex = 0;
            this.onlyPictureBox.TabStop = false;
            // 
            // imageFolderBtn
            // 
            this.imageFolderBtn.Location = new System.Drawing.Point(63, 53);
            this.imageFolderBtn.Name = "imageFolderBtn";
            this.imageFolderBtn.Size = new System.Drawing.Size(146, 62);
            this.imageFolderBtn.TabIndex = 1;
            this.imageFolderBtn.Text = "images folder";
            this.imageFolderBtn.UseVisualStyleBackColor = true;
            this.imageFolderBtn.Click += new System.EventHandler(this.ImageFolderBtn_Click);
            // 
            // recieveFolderBtn
            // 
            this.recieveFolderBtn.Location = new System.Drawing.Point(274, 53);
            this.recieveFolderBtn.Name = "recieveFolderBtn";
            this.recieveFolderBtn.Size = new System.Drawing.Size(146, 62);
            this.recieveFolderBtn.TabIndex = 2;
            this.recieveFolderBtn.Text = "recieve folder";
            this.recieveFolderBtn.UseVisualStyleBackColor = true;
            this.recieveFolderBtn.Click += new System.EventHandler(this.RecieveFolderBtn_Click);
            // 
            // imageFolderTb
            // 
            this.imageFolderTb.Location = new System.Drawing.Point(63, 28);
            this.imageFolderTb.Name = "imageFolderTb";
            this.imageFolderTb.Size = new System.Drawing.Size(146, 20);
            this.imageFolderTb.TabIndex = 3;
            // 
            // recieveFolderTb
            // 
            this.recieveFolderTb.Location = new System.Drawing.Point(274, 28);
            this.recieveFolderTb.Name = "recieveFolderTb";
            this.recieveFolderTb.Size = new System.Drawing.Size(146, 20);
            this.recieveFolderTb.TabIndex = 4;
            // 
            // DirImageBtn
            // 
            this.DirImageBtn.Location = new System.Drawing.Point(63, 153);
            this.DirImageBtn.Name = "DirImageBtn";
            this.DirImageBtn.Size = new System.Drawing.Size(146, 57);
            this.DirImageBtn.TabIndex = 5;
            this.DirImageBtn.Text = "In Directory";
            this.DirImageBtn.UseVisualStyleBackColor = true;
            this.DirImageBtn.Click += new System.EventHandler(this.DirImageBtn_Click);
            // 
            // deleteImageBtn
            // 
            this.deleteImageBtn.Location = new System.Drawing.Point(274, 153);
            this.deleteImageBtn.Name = "deleteImageBtn";
            this.deleteImageBtn.Size = new System.Drawing.Size(146, 57);
            this.deleteImageBtn.TabIndex = 6;
            this.deleteImageBtn.Text = "Delete Image";
            this.deleteImageBtn.UseVisualStyleBackColor = true;
            this.deleteImageBtn.Click += new System.EventHandler(this.DeleteImageBtn_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(630, 28);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(923, 656);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.deleteImageBtn);
            this.Controls.Add(this.DirImageBtn);
            this.Controls.Add(this.recieveFolderTb);
            this.Controls.Add(this.imageFolderTb);
            this.Controls.Add(this.recieveFolderBtn);
            this.Controls.Add(this.imageFolderBtn);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.onlyPictureBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageSorter";
            ((System.ComponentModel.ISupportInitialize)(this.onlyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void InitializeNonDesignComponents()
        {
            imagesFolderSelected = false;
            recievedImageSelected = false;
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }

        private void InitializeDirectoryButtons()
        {
        }

        private void LoadNewImages()
        {
            //get array of all images present in said folder
            if (!String.IsNullOrEmpty(imageFolderDialog.SelectedPath))
            {
                allImages = Directory.GetFiles(imageFolderDialog.SelectedPath);
                Debug.Print(allImages.Length.ToString());
                if (allImages.Length > 0) 
                {
                    //onlyPictureBox.ImageLocation = allImages[imageCounter];
                    axWindowsMediaPlayer1.URL = allImages[imageCounter];
                }    
            }
        }
    }
}

