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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            Password.PasswordChar = '*'; // this ensures that when user is entering the password it cannot be seen on screen... this improves strength and security of system.
            confirmPassword.PasswordChar = '*'; // this ensures that when user is entering the password it cannot be seen on screen... this improves strength and security of system.

        }
        DataBaseConnection dbConn = DataBaseConnection.GetInstanceofDataBaseConnection();

        private void RegisterUser_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || Password.Text == "" || confirmPassword.Text == "" || TableName.Text == "" || TableDOB.Text == "" ) // '||' sign is the logic operator for OR...
                                                                                                                                         //  ensures that user does not leave required fields empty
                                                                                                                                         // ensures name is less than 50 characters as database can hold max 50
                                                                                                                                        
            {
                MessageBox.Show("These fields CAN NOT be empty!, Please Try Again");  // this means if any of these are empty a message box will prompt user to enter something
            }
            else if (Password.Text == confirmPassword.Text && Password.Text.Length > 7 && Password.Text.Length < 51 && Username.Text.Length <50) // validation to ensure both 'password' and 'confirmPassword' are the same text
                                                                                                                     // validaiton to ensure password is above 7 characters, so that it cannot be guessed easily
                                                                                                                     // validation to ensure username and password is below 51 characters as database can only store a max of 50 characters
            {
                // here I am giving the textbox created a variable name so data can be manipulated
                string username = Username.Text; 
                string password = Password.Text; 
                string name = TableName.Text;

                // try and catch is used to prevent any exceptions... e.g when user enters letters in 'DOB' it will catch the exception and notify user what has occured 
                try
                {
                    //class 'Convert.ToInt32' converts the datatype'
                    int dob = Convert.ToInt32(TableDOB.Text);
                    

                    dbConn.saveToDB("INSERT INTO Person (Name, DOB, Username, Password) VALUES (@Name, @DOB, @Username, @Password)", name, dob, username, password); // sends value as parameters to method
                                                                                                                                                                     // 'saveToDB' in 'dbConn' class

                    MessageBox.Show("Your Account has sucessfully been created, Thank You!");
                }
                catch
                {
                    MessageBox.Show("Please only enter numbers in 'DOB'");
                }

            }
            else // this else statement is displayed when user does not enter appropiate credentials
            {
                MessageBox.Show("Username and Password do NOT meet requirements, Please Try Again");

                Password.Text = "";
                confirmPassword.Text = "";
                // this empties the text 
                Username.Focus(); // brings keyboard to Username so user can type instantly

            }

        }


        private void GobackToLogInPage_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

       
        private void Register_Load(object sender, EventArgs e)
        {

        }


        private void showPassword_CheckedChanged(object sender, EventArgs e)
            // this allows user to display password to check if it is intended input
        {
            if (showPassword.Checked) 
            {
                Password.PasswordChar = '\0';
                confirmPassword.PasswordChar = '\0';
                // if user clicks the check box it will show what they have entered
            }
            else
            {
                Password.PasswordChar = '*';
                confirmPassword.PasswordChar = '*';
                //  if they uncheck it will be covered by '*' so password cannot be seen 
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TableName.Text = "";
            TableDOB.Text = "";
            Username.Text = "";
            Password.Text = "";
            confirmPassword.Text = "";
            // this clears the text 

        }

    }
}
