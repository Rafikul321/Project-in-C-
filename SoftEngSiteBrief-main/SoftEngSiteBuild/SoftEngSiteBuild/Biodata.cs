using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace SoftEngSiteBuild
{
    public partial class Biodata : Form
    {
        SqlDataAdapter Sda;
        SqlCommandBuilder scb;
        DataTable Dt;
        public Biodata()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Biodata_Load(object sender, EventArgs e)
        {/*
          // label6.Text = "You Logged in as a: " + this.Controls["label1"].Text;

            if(this.Controls["label1"].Text != "Amdmin")
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(Sda);
            Sda.Update(Dt);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.DBConnectionString);
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nashl\source\repos\SOFTWARE\SOFTWARE\SOFTWARE\Database.mdf;Integrated Security=True");
            Sda = new SqlDataAdapter(@"SELECT Username,Password 
                                       FROM Person",con);
            Dt = new DataTable();
            Sda.Fill(Dt);
            dataGridView1.DataSource = Dt; 

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
