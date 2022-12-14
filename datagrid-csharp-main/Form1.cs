using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grid_Array_Task_5
{
    public partial class Form1 : Form
    {
        Person[] person;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            person = new Person[5];
            person[0] = new Person("Rizwan", "Ahmed", "Ranipur");
            person[1] = new Person("Zeeshan", "Ahmed", "Larkano");
            person[2] = new Person("Noman", "Aijaz", "Karachi");
            person[3] = new Person("Hans", "Raj", "Hyderabad");
            person[4] = new Person("Nadir", "Hussain", "Khairpur");

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = person;
        }
    }
}
