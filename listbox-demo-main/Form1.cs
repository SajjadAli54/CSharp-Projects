using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListboxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox.Items.AddRange(new object[] { 1, 2, 3, 4 });
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection values = listBox.SelectedItems;
            string info = "";
            foreach (var item in values)
                info += item.ToString() + "\n";
            
        }
    }
}
