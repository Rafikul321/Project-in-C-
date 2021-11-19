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

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TableAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterUser_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || Password.Text == "" || confirmPassword.Text == "" || TableName.Text == "" || TableAge.Text == "") // '||' sign is the logic operator for OR,
                                                                                                                                        
            {
                MessageBox.Show("These fields CAN NOT be empty!, Please Try Again");  // this means if any of these are empty a message box will prompt user to enter something
            }
            else if (Password.Text == confirmPassword.Text) // validation to ensure both passwords are the same 
            {
                // here I am giving the textbox created a variable name so data can be manipulated
                string username = Username.Text;
                string password = Password.Text;
                // here I am giving the textbox created a variable name so data can be manipulated
                string name = TableName.Text;

                int age = Convert.ToInt32(TableAge.Text);

                //class 'Convert.ToInt32' converts the datatype'
                dbConn.saveToDB("INSERT INTO Person (Name, Age, Username, Password) VALUES (@Name, @Age, @Username, @Password)", name, age, username, password); // sends value as parameters 

                MessageBox.Show("Your Account has sucessfully been created, Thank You!");

            }
            else
            {
                MessageBox.Show("Passwords do NOT match!, Please Try Again");

                Password.Text = "";
                confirmPassword.Text = "";
                // this empties the text 
                Password.Focus();



            }
     


        }


  //  }

        private void GobackToLogInPage_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void TableAge_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void TableName_TextChanged(object sender, EventArgs e)
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
            TableAge.Text = "";
            Username.Text = "";
            Password.Text = "";
            confirmPassword.Text = "";
            // this clears the text 

        }
    }
}
