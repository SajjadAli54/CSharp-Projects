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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            this.progressBar.Minimum = 1;
            this.progressBar.Maximum = 100;
            this.progressBar.Value = 1;
            for (int i = 1; i < 90; i++)
                this.progressBar.Value++;
        }
    }
}
