using System;
using System.Windows.Forms;

namespace SendMessageForms
{
    public partial class FormMatrix1 : Form
    {
        public FormMatrix1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var arr = new int[2,2];
            arr[0, 0] = Convert.ToInt32(txtOne.Text);
            arr[0, 1] = Convert.ToInt32(txtTwo.Text);
            arr[1, 0] = Convert.ToInt32(txtThree.Text);
            arr[1, 1] = Convert.ToInt32(txtFour.Text);

            var form = new FormMatrix2(arr);
            Hide();
            form.ShowDialog();
        }

        private void txtOne_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFour_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThree_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
