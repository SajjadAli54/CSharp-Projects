using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    public partial class FormTextEditor : Form
    {
        public FormTextEditor()
        {
            InitializeComponent();
            textBoxArea.Width = Width - 30;
            textBoxArea.Height = Height - 150;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string text = textBoxSearch.Text.Trim();
            if (text == null) return;

            int i = textBoxArea.Text.IndexOf(text);
            if (i != -1)
            {
                textBoxArea.SelectionStart = i;
                textBoxArea.SelectionLength = text.Length;
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                string lines = File.ReadAllText(file);
                textBoxArea.Text = lines;
            }
        }

        private void FormTextEditor_Resize(object sender, EventArgs e)
        {
            textBoxArea.Width = Width - 30;
            textBoxArea.Height = Height - 150;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxArea.ForeColor = colorDialog.Color;
            }
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxArea.Font = fontDialog.Font;
                textBoxArea.ForeColor = fontDialog.Color;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = saveFileDialog.FileName;
                File.WriteAllText(file, textBoxArea.Text);
            }
        }
    }
}
