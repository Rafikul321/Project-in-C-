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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            password.PasswordChar = '*'; // this ensures that when user is entering the password it cannot be seen on screen... this improves strength and security of system.

        }

        DataBaseConnection dbConn = DataBaseConnection.GetInstanceofDataBaseConnection();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btClose_TextChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {

        }

        private void btClose_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            new Register().Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string Username = username.Text;
            string Password = password.Text;
            string sqlQuery = "Select * FROM Person WHERE Username = '" + Username + "' AND Password = '" + Password + "'";


            DataSet datasetPerson = dbConn.getDataSet(sqlQuery);




            if (datasetPerson.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Your have succesfully logged in!");
                new SiteInspection().Show();

            }
            else
            {

                MessageBox.Show("Incorrect log in details, please try again!");

            }



        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close(); // this allows user to close the log in page 
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                password.PasswordChar = '\0';
                
                // if user clicks the check box it will show what they have entered
            }
            else
            {
                password.PasswordChar = '*';
            
                //  if they uncheck it will be covered by '*' so password cannot be seen 
            }
        }
    }
}
