using System;
using System.Drawing;
using System.Windows.Forms;

namespace Puzzle_Game
{
    public partial class FormPuzzle : Form
    {
        string winImage;
        Random random;

        int right = 0, limit = 3;
        public FormPuzzle()
        {
            InitializeComponent();
            random = new Random();
            winImage = @".\pics\candy" + random.Next(1,18) +".jpg";


        }

        private void FormPuzzle_Load(object sender, EventArgs e)
        {
            btnPic.Image = Image.FromFile(winImage);

            #region THREE_IMAGE_BUTTONS_FOR_WINNER
            int firstIndex = random.Next(1, 17);
            this.Controls["button" + firstIndex].Tag = winImage;
            int secondIndex = firstIndex;

            int count = 2;
            while(count != 0)
            {
                int thirdIndex = random.Next(1, 17);
                if (thirdIndex == firstIndex || thirdIndex == secondIndex) 
                    continue;
                this.Controls["button" + thirdIndex].Tag = winImage;
                secondIndex = thirdIndex;
                count--;
            }
            #endregion

            #region THIRTEEN_OTHER_IMAGE_BUTTONS
            count = 1;
            while(count != 17)
            {
                var image = @".\pics\candy" + random.Next(1, 18) + ".jpg";
                if (image == winImage)
                    continue;
                if (this.Controls["button" + count].Tag == null)
                    this.Controls["button" + count].Tag = image;
                count++;
            }
            #endregion
        }

        private void button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            string image = button.Tag as string;

            if (button.Image != null) return;

            button.Image = Image.FromFile(image as string);

            if (image == winImage)
                right++;
            else
                limit--;
            btnInfo.Text = "GUESS PICTURE FROM PUZZLE (WRONG ATTEMPTS ALLOWED = " + limit + ")";

            if (limit == 0)
            {
                MessageBox.Show("You lost");
                this.Close();
            }

            if(right == 3)
            {
                MessageBox.Show("You won");
                this.Close();
            }
        }
    }
}
