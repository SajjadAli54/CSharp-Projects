using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class frmSplashScreen : Form
    {
        frmSplash splash = new frmSplash();
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            this.progressBar.Minimum = 1;
            this.progressBar.Maximum = 100;
            this.progressBar.Value = 25;
            lblMessage.Text = "Loaded successfully";
            progressBar.Value = 100;
            Hide();
            splash.ShowDialog();
        }
    }
}
