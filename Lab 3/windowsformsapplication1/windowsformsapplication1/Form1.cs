using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class NotepadKG : Form
    {
        public NotepadKG()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            this.Text = "Unititled";
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // OpenFileDialog dlg = new OpenFileDialog();
            openFileDialog1.Title = "Open";
            openFileDialog1.ShowDialog();
            string fname = openFileDialog1.FileName;
            StreamReader sr = new StreamReader(fname);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Document (.txt)|*.txt|Rich Text Document (.rtf)|All Files (*.*)|*.*|";
            saveFileDialog1.Title = "Save";
            saveFileDialog1.OverwritePrompt = true;

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = saveFileDialog1.FileName;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem1_Click(sender,e);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem1_Click(sender, e);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem1_Click(sender, e);
        }

        private void fontToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.SelectionFont;
            fontDialog1.Color = richTextBox1.SelectionColor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
  
    }
}
