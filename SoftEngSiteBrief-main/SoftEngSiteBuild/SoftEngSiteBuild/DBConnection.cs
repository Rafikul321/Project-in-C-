using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftEngSiteBuild
{
    //this class was taken from canvas lecture videos and was modifed to suit our project
    class DataBaseConnection
    {
        //attributes 
        //private object of the class itself
        private static DataBaseConnection x;

        // the connection string 
        private string dataBaseConnectionString;

        //constructor 
        private DataBaseConnection()
        {
            //initiaialse the DataBaseconnectionstring
            dataBaseConnectionString = Properties.Settings.Default.DBConnectionString;

        }

        //methods
        public static DataBaseConnection GetInstanceofDataBaseConnection()
        {
            if (x == null)
                x = new DataBaseConnection();
            return x;
        }


        public DataSet getDataSet(string sqlQuery)
            //this methods allow me to check whether the login details the user has entered matches what is inside the database
        {
            // create the dataset object
            DataSet dataset = new DataSet();

            using (SqlConnection connectionToDB = new SqlConnection(dataBaseConnectionString))
            {
                //opens the connection
                connectionToDB.Open();

                // sends the query to the database
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionToDB);

                // fill dataset 
                adapter.Fill(dataset);
            
            }

            return dataset;

        }

        // this method allows the parameters (name and dob) to be saved in the database 

        public void saveToDB(string sqlquery, string name, int dob, string username, string password)
        {
            using (SqlConnection connToDB = new SqlConnection(dataBaseConnectionString))
            {

                //opens the connection

                connToDB.Open();

                //created object 'SqlCommand' this was created to send querires through connection to database
                SqlCommand sqlCommand = new SqlCommand(sqlquery, connToDB);

                // gives properties to SQLcommand
                sqlCommand.CommandType = CommandType.Text;

                //'Name' and "dob" was used as that is the expected paramter that was created from 'DataB.cs"
                sqlCommand.Parameters.Add(new SqlParameter("Name", name));
                sqlCommand.Parameters.Add(new SqlParameter("DOB", dob));
                sqlCommand.Parameters.Add(new SqlParameter("Username", username));
                sqlCommand.Parameters.Add(new SqlParameter("Password", password));


                //execute command 
                sqlCommand.ExecuteNonQuery();




            }
        }
    }
}
