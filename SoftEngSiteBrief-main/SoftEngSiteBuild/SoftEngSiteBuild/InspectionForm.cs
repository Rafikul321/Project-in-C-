using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SOFTWARE
{
    public partial class InspectionForm : Form
    {
        public InspectionForm()
        {
            InitializeComponent();
        }

        private void workAtHeightToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void ssdsddToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void goodBadCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            sfd.FileName = "Password";
            sfd.Title = "Save Text File";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = sfd.FileName;
                StreamWriter bw = new StreamWriter(File.Create(path));
                char randomstring = default;
                bw.Write(randomstring);
                bw.Dispose();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
