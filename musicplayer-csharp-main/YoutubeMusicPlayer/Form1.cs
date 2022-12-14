using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace YoutubeMusicPlayer
{
    public partial class FormPlayer : Form
    {
        List<string> listPaths = new List<string>();
        public FormPlayer()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                listPaths.AddRange(openFileDialog.FileNames);
                listBoxSongs.Items.AddRange(openFileDialog.SafeFileNames);
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL = listPaths[listBoxSongs.SelectedIndex];
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
