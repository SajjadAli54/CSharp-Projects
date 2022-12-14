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
    public partial class FormMatrix2 : Form
    {
        int[,] arr = new int[2, 2];
        public FormMatrix2(int[,] arr)
        {
            InitializeComponent();
            this.arr = arr;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var arr = new int[2, 2];
            arr[0, 0] = Convert.ToInt32(txtOne.Text);
            arr[0, 1] = Convert.ToInt32(txtTwo.Text);
            arr[1, 0] = Convert.ToInt32(txtThree.Text);
            arr[1, 1] = Convert.ToInt32(txtFour.Text);

            var form = new FormMatrix3(arr, this.arr);
            Hide();
            form.ShowDialog();
        }
    }
}
