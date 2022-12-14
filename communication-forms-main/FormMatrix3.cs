using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMessageForms
{
    public partial class FormMatrix3 : Form
    {
        public FormMatrix3(int[,] one, int[,] two)
        {
            InitializeComponent();

            txtOne.Text = one[0, 0] + two[0, 0] + "";
            txtTwo.Text = one[0, 1] + two[0, 1] + "";
            txtThree.Text = one[1, 0] + two[1, 0] + "";
            txtFour.Text = one[1, 1] + two[1, 1] + "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
