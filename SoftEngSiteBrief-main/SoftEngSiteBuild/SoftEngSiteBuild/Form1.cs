using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftEngSiteBuild
{
    public partial class Form1 : Form
    {
        private AuditFormData auditFormData;
        public Form1()
        {
            InitializeComponent();
            auditFormData = new AuditFormData();
        }


        private void toolStripMenuItem113_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            (new DataB()).ShowDialog();
        }

        private void TbWorkAtHeightIntervention_TextChanged(object sender, EventArgs e)
        {
            auditFormData.WorkAtHeightIntervention = tbWorkAtHeightIntervention.Text;
        }

        private void TbWorkAtHeightComment_TextChanged(object sender, EventArgs e)
        {
            auditFormData.WorkAtHeightComment = tbWorkAtHeightComment.Text;
        }

        private void TbWorkatHeightCompleted_TextChanged(object sender, EventArgs e)
        {
            // auditFormData.WorkAtHeightCompleted = tbWorkatHeightCompleted.text;
        }
    }
}
