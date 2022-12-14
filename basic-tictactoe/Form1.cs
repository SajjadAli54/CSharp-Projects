using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic
{
    public partial class frmTictactoe : Form
    {
        ClassTictactoe obj = new ClassTictactoe();
        public frmTictactoe()
        {
            InitializeComponent();
        }

        private void btnOne_to_btnNine_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (obj.getToggle())
            {
                button.Text = obj.getUserOne();
               
                button.BackColor = Color.Green;
                obj.setToggle(false);
            }
            else
            {
                button.BackColor = Color.Yellow;
                button.Text = obj.getUserTwo();
                obj.setToggle(true);
            }
            button.Enabled = false;
            checkWinner();
        }

        private void checkWinner()
        {
            if(winner("X"))
            {
                lblInfo.Text = "Winner is : X";
                EnableButton(false);
            }
            else if (winner("O"))
            {
                lblInfo.Text = "Winner is : O";
                EnableButton(false);
            }
            else if (checkDraw())
            {
                lblInfo.Text = "Match is drawn";
            }

        }

        private bool winner(String user)
        {
            return (btnOne.Text == user && btnTwo.Text == user && btnThree.Text == user) ||
                (btnFour.Text == user && btnFive.Text == user && btnSix.Text == user) ||
                (btnSeven.Text == user && btnEight.Text == user && btnNine.Text == user) ||
                (btnOne.Text == user && btnFive.Text == user && btnNine.Text == user)   ||
                (btnThree.Text == user && btnFive.Text == user && btnSeven.Text == user) ||
                (btnOne.Text == user && btnFour.Text == user && btnSeven.Text == user) ||
                (btnTwo.Text == user && btnFive.Text == user && btnEight.Text == user) ||
                (btnThree.Text == user && btnSix.Text == user && btnNine.Text == user)
                ;
        }

        private void EnableButton(bool value)
        {
            btnOne.Enabled = value;
            btnTwo.Enabled = value;
            btnThree.Enabled = value;
            btnFour.Enabled = value;
            btnFive.Enabled = value;
            btnSix.Enabled = value;
            btnSeven.Enabled = value;
            btnEight.Enabled = value;
            btnNine.Enabled = value;
        }

        private bool checkDraw()
        {
            return !(btnOne.Enabled || btnTwo.Enabled || btnThree.Enabled || btnFour.Enabled || btnFive.Enabled || btnSix.Enabled || btnSeven.Enabled || btnEight.Enabled || btnNine.Enabled);
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            EnableButton(true);
            lblInfo.Text = "Winner is : Still Playing";
            obj = new ClassTictactoe();

            btnOne.Text = "";
            btnTwo.Text = "";
            btnThree.Text = "";
            btnFour.Text = "";
            btnFive.Text = "";
            btnSix.Text = "";
            btnSeven.Text = "";
            btnEight.Text = "";
            btnNine.Text = "";

            btnOne.BackColor = Color.Empty;
            btnTwo.BackColor = Color.Empty;
            btnThree.BackColor = Color.Empty;
            btnFour.BackColor = Color.Empty;
            btnFive.BackColor = Color.Empty;
            btnSix.BackColor = Color.Empty;
            btnSeven.BackColor = Color.Empty;
            btnEight.BackColor = Color.Empty;
            btnNine.BackColor = Color.Empty;
        }
    }
}
