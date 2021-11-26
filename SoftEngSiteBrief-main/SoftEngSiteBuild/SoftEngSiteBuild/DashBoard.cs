using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SoftEngSiteBuild
{
    public partial class DashBoard : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public DashBoard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btDashboard.Height;
            pnlNav.Top = btDashboard.Top;
            pnlNav.Left = btDashboard.Left;
            btDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btSettings.Height;
            pnlNav.Top = btSettings.Top;
            pnlNav.Left = btSettings.Left;
            btSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btDashboard.Height;
            pnlNav.Top = btDashboard.Top;
            pnlNav.Left = btDashboard.Left;
            btDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void btAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btAnalytics.Height;
            pnlNav.Top = btAnalytics.Top;
            pnlNav.Left = btAnalytics.Left;
            btAnalytics.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btCalender_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btCalender.Height;
            pnlNav.Top = btCalender.Top;
            pnlNav.Left = btCalender.Left;
            btCalender.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btContactUs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btContactUs.Height;
            pnlNav.Top = btContactUs.Top;
            pnlNav.Left = btContactUs.Left;
            btContactUs.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btDashboard_Leave(object sender, EventArgs e)
        {
            btDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btAnalytics_Leave(object sender, EventArgs e)
        {
            btAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btCalender_Leave(object sender, EventArgs e)
        {
            btCalender.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btContactUs_Leave(object sender, EventArgs e)
        {
            btContactUs.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btSettings_Leave(object sender, EventArgs e)
        {
            btSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Biodata bioData = new Biodata();
            //ss.MdiParent = this;
            bioData.Show();
        }
    }
}
