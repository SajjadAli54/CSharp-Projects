using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignupForm
{
    public partial class Form1 : Form
    {
        int countNoOfContacts = 1;
        Button btnRemove = new Button();
        public Form1()
        {
            InitializeComponent();
            btnRemove.Text = "Remove";
            btnRemove.Left = btnAddMore.Right + 5;
            btnRemove.Height = btnAddMore.Height;
            btnRemove.Width = btnAddMore.Width;
            btnRemove.Click += new EventHandler(this.btnRemove_Click);
        }

        private void btnAddMore_Click(object sender, EventArgs e)
        {
            var space = 15;
            var previousLabel = this.Controls["lblContact_" + countNoOfContacts];
            var previousText = this.Controls["txtContact_" + countNoOfContacts];
            countNoOfContacts++;

            Label lblContact2 = new Label();
            lblContact2.Text = "Contact # " + countNoOfContacts;
            lblContact2.Name = "lblContact_" + countNoOfContacts;
            lblContact2.Left = previousLabel.Left;
            lblContact2.Top = previousLabel.Top + previousLabel.Height + space;

            TextBox txtContact2 = new TextBox();
            txtContact2.Name = "txtContact_" + countNoOfContacts;
            txtContact2.Left = previousText.Left;
            txtContact2.Top = previousText.Top + previousText.Height + space;
            txtContact2.Width = previousText.Width;
            txtContact2.Height = previousText.Height;

            btnAddMore.Top = txtContact2.Top;
            btnRemove.Top = btnAddMore.Top;
            btnClear.Top = btnClear.Top + space + txtContact2.Height;
            btnSubmit.Top = btnClear.Top;

            this.Controls.Add(lblContact2);
            this.Controls.Add(txtContact2);
            this.Controls.Add(btnRemove);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            string str = "txtContact_";
            for (int i = 1; i <= countNoOfContacts; i++)
                this.Controls[str + i].Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = "User name : " + txtUsername.Text +
                "\nPassword : " + txtPassword.Text +
                "\nContacts\n\t";
            for (int i = 1; i <= countNoOfContacts; i++)
                message += this.Controls["txtContact_" + i].Text + "\n\t";
            MessageBox.Show(message);
        }
 
        private void btnRemove_Click(object sender, EventArgs e)
        {
            var previousLabel = this.Controls["lblContact_" + countNoOfContacts];
            var previousContact = this.Controls["txtContact_" + countNoOfContacts];
            countNoOfContacts--;

            btnClear.Top = previousContact.Top;
            btnSubmit.Top = btnClear.Top;
            btnAddMore.Top = this.Controls["txtContact_" + countNoOfContacts].Top;
            btnRemove.Top = btnAddMore.Top;

            this.Controls.Remove(previousLabel);
            this.Controls.Remove(previousContact);

            if (countNoOfContacts == 1)
                this.Controls.Remove(btnRemove);
        }
    }
}
