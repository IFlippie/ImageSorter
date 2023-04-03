using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeNonDesignComponents();
            InitializeDirectoryButtons();
        }


        private void ImageFolderBtn_Click(object sender, EventArgs e)
        {
            imageFolderDialog = new FolderBrowserDialog();
            imageFolderDialog.ShowDialog();
            imageFolderTb.Text = imageFolderDialog.SelectedPath;
            imageCounter = 0;
            imagesFolderSelected = true;
            LoadNewImages();
        }

        private void RecieveFolderBtn_Click(object sender, EventArgs e)
        {
            recieveImageDialog = new FolderBrowserDialog();
            recieveImageDialog.ShowDialog();
            recieveFolderTb.Text = recieveImageDialog.SelectedPath;
            recievedImageSelected = true;

            allDirectories = Directory.GetDirectories(recieveImageDialog.SelectedPath);
            folderButtons = new List<Button>();
            //folderButtons.Clear();
            Console.WriteLine(allDirectories.Length);
            for (int i = 0; i < allDirectories.Length; i++)
            {
                var tempButton = new Button();
                folderButtons.Add(tempButton);
            }
            for (int i = 0; i < allDirectories.Length; i++)
            {
                var dir = new DirectoryInfo(allDirectories[i]);
                var dirName = dir.Name;
                folderButtons[i].Location = new Point(100 * i, 800);
                folderButtons[i].Name = allDirectories[i];
                folderButtons[i].Size = new Size(100, 50);
                folderButtons[i].TabIndex = 20;
                folderButtons[i].Text = dirName;
                folderButtons[i].UseVisualStyleBackColor = true;
                folderButtons[i].Click += new EventHandler(FolderButton_Click);
                Controls.Add(folderButtons[i]);
            }
        }

        private void DeleteImageBtn_Click(object sender, EventArgs e)
        {
            if (imagesFolderSelected && recievedImageSelected)
            {
                //System.IO.File.Delete(allImages[imageCounter]);
                LoadNewImages();
            }
        }

        private void DirImageBtn_Click(object sender, EventArgs e)
        {
            if (imagesFolderSelected && recievedImageSelected)
            {
                var result = Path.GetFileName(allImages[imageCounter]);
                try
                {
                    File.Move(allImages[imageCounter], $@"{recieveImageDialog.SelectedPath}\{result}");
                }
                catch (IOException)
                {
                    FileInfo tempInfo = new FileInfo(allImages[imageCounter]);
                    File.Move(allImages[imageCounter], $@"{recieveImageDialog.SelectedPath}\{Path.GetRandomFileName()}{tempInfo.Extension}");
                }               
                LoadNewImages();
            }
        }

        private void FolderButton_Click(object sender, EventArgs e) 
        {
            Button myB = (Button)sender;
            var result = Path.GetFileName(allImages[imageCounter]);
            try
            {
                File.Move(allImages[imageCounter], $@"{myB.Name}\{result}");
            }
            catch (IOException)
            {
                FileInfo tempInfo = new FileInfo(allImages[imageCounter]);
                File.Move(allImages[imageCounter], $@"{myB.Name}\{Path.GetRandomFileName()}{tempInfo.Extension}");
            }
            LoadNewImages();
        }
    }
}
