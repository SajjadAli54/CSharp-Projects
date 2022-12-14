using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_08
{
    public partial class FormTrexGame : Form
    {
        Random random = new Random();
        int score = 0;
        bool up;
        public FormTrexGame()
        {
            InitializeComponent();
        }

        private void tmGame_Tick(object sender, EventArgs e)
        {
            if (pbObstacle1.Left < 0)
                pbObstacle1.Left = Width / 2 + random.Next(Width/2);
            if (pbObstacle2.Left < 0)
                pbObstacle2.Left = Width / 2 + random.Next(Width / 2);
            pbObstacle1.Left -= 10;
            pbObstacle2.Left -= 10;

            if(pbTrex.Bounds.IntersectsWith(pbObstacle1.Bounds) || pbTrex.Bounds.IntersectsWith(pbObstacle2.Bounds))
            {
                tmGame.Stop();
                tmScore.Stop();
                tmUpDown.Stop();
                pbTrex.ImageLocation = @"D:\BS V\Visual Programming\Lab\Labs\Lab-08\trexImages\dead.png";
            }
        }

        private void tmScore_Tick(object sender, EventArgs e)
        {
            lblScore.Text = "Score : " + (++score);
        }

        private void FormTrexGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                tmUpDown.Start();
                up = true;

            }
        }

        void moveUp()
        {
            pbTrex.Top -= 5;
        }

        void moveDown()
        {
            pbTrex.Top += 5;
        }

        private void tmUpDown_Tick(object sender, EventArgs e)
        {
            if (up)
                moveUp();
            else if (pbTrex.Bottom < pbGround.Top)
                moveDown();
            else
                tmUpDown.Stop();
        }

        private void FormTrexGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                up = false;
        }
    }
}
