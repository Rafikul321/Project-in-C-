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
            if (username.Text == "User" & password.Text == "password") // this if statements checks whether the username and password the user has entered matches "User" and "password" '&' symbol is used as AND logic operator.


            {
                // if user has entered the correct password a messagebox will appear firstly stating that they have entered correct password
                MessageBox.Show("You have entered the correct details", " Welcome!");

                // once user has entered correct password they will be able to access the system, this takes them to 'Form1'
                this.Hide(); // this improves user experience as the log in form will be hiden once they access main system
                new DashBoard().Show();
                 

            }

            else
                // this displays error message and notifies user that they have entered wrong log in details
            {
                MessageBox.Show("Incorrect details, please try again", " Warning!");
                
                
            }


           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close(); // this allows user to close the log in page 
        }
    }
}
