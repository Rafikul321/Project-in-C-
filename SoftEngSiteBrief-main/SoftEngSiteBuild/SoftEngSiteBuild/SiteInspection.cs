using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftEngSiteBuild
{
    public partial class SiteInspection : Form
    {

        
        public SiteInspection()
        {
            InitializeComponent();
            
        }
        InspectionClass dbConn = InspectionClass.GetInstanceofInspectionClass();
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string site = textBox1.Text;
            string workarea = textBox2.Text;
            string Supervisor = textBox3.Text;
            string CompletedBy = textBox4.Text;
            string JobDescription = textBox5.Text;
            string Inspector = textBox6.Text;
            string Date = textBox7.Text;
            string Type = textBox8.Text;


            dbConn.savetoSiteInspection("INSERT INTO SiteInspection(Site, WorkArea, Supervisor, CompletedBy, JobDescription, Inspector, Date, Type) VALUES (@Site, @WorkArea, @Supervisor, @CompletedBy, @JobDescription, @Inspector, @Date, @Type)", site, workarea, Supervisor, CompletedBy, JobDescription, Inspector, Date, Type); // sends value as parameters 

            MessageBox.Show("Thank You for submitting your details.");

        }

        private void SiteInspection_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
      

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void BtLoadData_Click(object sender, EventArgs e)
        {
            // gets dataset from 'siteinspection' and uses select query to show all data inside the table
            DataSet datasetSiteInspection = dbConn.getDataSet("Select * FROM SiteInspection");
            // once data is recieved this allows data to be displayed to the datagrid
            dgv1.DataSource =datasetSiteInspection.Tables[0];
        }
    }
}
