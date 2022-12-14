using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check(bool value)
        {
            checkBoxFruit.Checked = value;
            checkBoxKarahi.Checked = value;
            checkBoxSamosa.Checked = value;
        }

        private void select_all(object sender, EventArgs e)
        {
            if (checkBoxFruit.Checked && checkBoxKarahi.Checked && checkBoxSamosa.Checked)
                checkBoxSelect.CheckState = CheckState.Checked;
            else if (!checkBoxFruit.Checked && !checkBoxKarahi.Checked && !checkBoxSamosa.Checked)
                checkBoxSelect.CheckState = CheckState.Unchecked;
            else
                checkBoxSelect.CheckState = CheckState.Indeterminate;
        }

        private void checkBoxSelect_Click(object sender, EventArgs e)
        {
            switch (checkBoxSelect.CheckState)
            {
                case CheckState.Checked:
                    check(true);
                    break;
                case CheckState.Unchecked:
                    check(false);
                    break;
            }
        }
    }
}
