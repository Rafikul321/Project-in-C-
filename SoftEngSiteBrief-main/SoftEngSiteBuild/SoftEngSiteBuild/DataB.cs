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
    public partial class DataB : Form
    {
        public DataB()
        {
            InitializeComponent();
        }

        private void dgvPerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DataBaseConnection dbConn = DataBaseConnection.GetInstanceofDataBaseConnection();

        private void btLoadData_Click(object sender, EventArgs e)
        {
            // returns the object of the class 
            // 
            DataSet datasetPerson = dbConn.getDataSet("Select * FROM Person");
            dgvPerson.DataSource = datasetPerson.Tables[0];

        }

        private void btInsert_Click(object sender, EventArgs e)
        {
     
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelName_Click(object sender, EventArgs e)
        {

        }

        private void LabelAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
