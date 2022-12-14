using System;
using System.Windows.Forms;
using System.IO;

namespace PracticeMid2
{
    public partial class FormSlideShow : Form
    {
        FileInfo[] images;
        int index = 0;
        bool slideDefault = true;
        public FormSlideShow()
        {
            InitializeComponent();
        }

        private void FormSlideShow_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo d in drives)
                if (d.IsReady)
                    comboBoxDrives.Items.Add(d);
            comboBoxDrives.SelectedIndex = 0;
        }

        private void comboBoxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            DriveInfo drive = comboBoxDrives.SelectedItem as DriveInfo;
            DirectoryInfo directory = new DirectoryInfo(drive.Name);
            DirectoryInfo[] directories = directory.GetDirectories();
            listBox.Items.AddRange(directories);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo directory = listBox.SelectedItem as DirectoryInfo;
            images = directory.GetFiles("*.jpg");
            if(images != null && images.Length != 0)
            {
                pictureBox.ImageLocation = images[0].FullName;
            }
            
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (images == null || images.Length == 0) return;
            Next();
            slideDefault = true;
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (images == null || images.Length == 0) return;
            Previous();
            slideDefault = false;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (images == null || images.Length == 0) return;
            timer.Start();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (images == null || images.Length == 0) return;
            timer.Stop();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            if (images == null || images.Length == 0) return;
            index = -1;
            Next();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            if (images == null || images.Length == 0) return;
            index = 0;
            Previous();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (slideDefault)
                Next();
            else
                Previous();
        }
        private void Next()
        {

            index = (index + 1) % images.Length;
            pictureBox.ImageLocation = images[index].FullName;
        }

        private void Previous()
        {
            if (index == 0)
                index = images.Length;
            pictureBox.ImageLocation = images[--index].FullName;
        }

        
    }
}
