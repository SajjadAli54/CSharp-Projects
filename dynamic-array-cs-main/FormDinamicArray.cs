using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Array
{
    public partial class FormDinamicArray : Form
    {
        Student[] students = new Student[1];
        int index = 0;
        public FormDinamicArray()
        {
            InitializeComponent();
        }

        private void txtStudent_Enter(object sender, EventArgs e)
        {
            if (txtStudent.Text == "Enter Name")
                txtStudent.Text = "";
            else
            {
                txtStudent.SelectionStart = 0;
                txtStudent.SelectionLength = txtStudent.Text.Length;
            }
        }

        private void txtStudent_Leave(object sender, EventArgs e)
        {
            if (txtStudent.Text == "")
                txtStudent.Text = "Enter Name";
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (txtStudent.Text == null || txtStudent.Text == "Enter Name")
            {
                MessageBox.Show("Please enter the data");
                return;
            }

            #region INCREASE_ARRAY_SIZE_IF_INDEX_GETS_OUT_OF_BOUND
            if (index >= students.Length)
            {
                var array = new Student[10 + students.Length];
                for (int i = 0; i < students.Length; i++)
                    array[i] = students[i];
                students = array;
            }
            #endregion

            students[index++] = new Student(txtStudent.Text);

            lblStudents.Text += txtStudent.Text + "\n"; 
        }
    }
}
