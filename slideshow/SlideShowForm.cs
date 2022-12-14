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

namespace SlideShow
{
    public partial class SlideShowForm : Form
    {
        FileInfo[] images;
        int index = 0;
        bool slide;
        public SlideShowForm()
        {
            InitializeComponent();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
                if (drive.IsReady)
                    comboBox.Items.Add(drive);
            comboBox.SelectedIndex = 0;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            DriveInfo drive = comboBox.SelectedItem as DriveInfo;
            DirectoryInfo[] directories = new DirectoryInfo(drive.Name).GetDirectories();
            foreach (DirectoryInfo directory in directories)
            {
                TreeNode tree = new TreeNode(directory.Name);
                tree.Tag = directory.FullName;
                treeView.Nodes.Add(tree);
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                TreeNode tree = treeView.SelectedNode;
                DirectoryInfo directory = new DirectoryInfo(tree.Tag as string);
                foreach(var dir in directory.GetDirectories())
                {
                    TreeNode node = new TreeNode(dir.Name);
                    node.Tag = dir.FullName;
                    tree.Nodes.Add(node);
                }

                images = directory.GetFiles("*.jpg");
                index = 0;
                if (images == null || images.Length == 0) return;

                pictureBox.ImageLocation = images[0].FullName;
            }catch(Exception exc)
            {

            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (images == null || images.Length == 0) return;
            timer.Start();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (images == null || images.Length == 0) return;
            if (index == 0)
                index = images.Length;
            pictureBox.ImageLocation = images[--index].FullName;
            slide = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (images == null || images.Length == 0) return;
            index = (index + 1) % images.Length;
            pictureBox.ImageLocation = images[index].FullName;
            slide = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (images == null || images.Length == 0) return;
            pictureBox.ImageLocation = images[0].FullName;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (images == null || images.Length == 0) return;
            pictureBox.ImageLocation = images[images.Length - 1].FullName;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (slide)
                index = (index + 1) % images.Length;
            else
            {
                if (index == 0)
                    index = images.Length;
                index--;
            }
            pictureBox.ImageLocation = images[index].FullName;
        }
    }
}
