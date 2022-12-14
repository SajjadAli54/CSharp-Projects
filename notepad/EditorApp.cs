using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Notepad
{
    public partial class FormShadesEditor : Form
    {
        string file;
        public FormShadesEditor()
        {
            InitializeComponent();
                        
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFirst();
            richTextBox.Clear();
            richTextBox.ClearUndo();
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFirst();
                file = openFileDialog.FileName;
                richTextBox.LoadFile(openFileDialog.FileName);
                autocompleteMenu.SetAutocompleteItems(Regex.Split(richTextBox.Text, " +"));

                this.Text = "Shades Editor \t" + file;
            }
        }

        private void saveFirst()
        {
            if (this.Text.EndsWith("*"))
            {
                if (MessageBox.Show("Do you want to save this file?",
                    "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    saveToolStripMenuItem.PerformClick();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (file == null)
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    file = saveFileDialog.FileName;
                else return;
            richTextBox.SaveFile(file);
            this.Text = "Shades Editor \t" + file;
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Text = "Shades Editor \t" + file + "*";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox.SelectedText.Length == 0)
                    richTextBox.Font = fontDialog.Font;
                else
                    richTextBox.SelectionFont = fontDialog.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox.SelectedText.Length == 0)
                    richTextBox.ForeColor = colorDialog.Color;
                else
                    richTextBox.SelectionColor = colorDialog.Color;
            }
        }

        private void FormShadesEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveFirst();
        }
    }
}