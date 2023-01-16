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
            /////This is for a different version
            folderButtons.Clear();
            allDirectories = Directory.GetDirectories(recieveImageDialog.SelectedPath);
            folderButtons = new List<Button>(allDirectories.Length);
            for (int i = 0; i < allDirectories.Length; i++)
            {

            }
        }

        private void DeleteImageBtn_Click(object sender, EventArgs e)
        {
            if (imagesFolderSelected && recievedImageSelected)
            {
                //System.IO.File.Delete(allImages[imageCounter]);
                imageCounter++;
                onlyPictureBox.ImageLocation = allImages[imageCounter];
            }
        }

        private void NextImageBtn_Click(object sender, EventArgs e)
        {
            if (imagesFolderSelected && recievedImageSelected)
            {
                //not meant for here
                //File.Copy(allImages[imageCounter], recieveImageDialog.SelectedPath);
                imageCounter++;
                onlyPictureBox.ImageLocation = allImages[imageCounter];
            }
        }
    }
}
