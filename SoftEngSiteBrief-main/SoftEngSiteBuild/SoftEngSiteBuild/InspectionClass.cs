using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SoftEngSiteBuild
{
    class InspectionClass
    {
        //attributes 
        //private object of the class itself
        private static InspectionClass y;

        // the connection string 
        private string dbconnConnectionString;

        //constructor 
        private InspectionClass()
        {
            //initiaialse the DataBaseconnectionstring
            dbconnConnectionString = Properties.Settings.Default.DBConnectionString;

        }

        //methods
        public static InspectionClass GetInstanceofInspectionClass()
        {
            if (y == null)
                y = new InspectionClass();
            return y;
        }


        public DataSet getDataSet(string sqlQuery)

        {
            // create the dataset object
            DataSet dt = new DataSet();

            using (SqlConnection connectionToSiteInspection = new SqlConnection(dbconnConnectionString))
            {
                //opens the connection
                connectionToSiteInspection.Open();

                // sends the query to the database
                SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, connectionToSiteInspection);

                // fill dataset 
                sda.Fill(dt);

            }

            return dt;

        }

        // this method allows the parameters (name and age) to be saved in the database 
        public void savetoSiteInspection(string sqlQuery, string site, string workarea, string Supervisor, string CompletedBy, string JobDescription, string Inspector, string Date, string Type)
        {
            using (SqlConnection connToSiteInspection = new SqlConnection(dbconnConnectionString))
            {

                //opens the connection

                connToSiteInspection.Open();

                //created object 'SqlCommand' this was created to send querires through connection to database
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToSiteInspection);

                // gives properties to SQLcommand
                sqlCommand.CommandType = CommandType.Text;

                //'Name' and "age" was used as that is the expected paramter that was created from 'DataB.cs"
                sqlCommand.Parameters.Add(new SqlParameter("Site", site));
                sqlCommand.Parameters.Add(new SqlParameter("WorkArea", workarea));
                sqlCommand.Parameters.Add(new SqlParameter("Supervisor", Supervisor));
                sqlCommand.Parameters.Add(new SqlParameter("CompletedBy", CompletedBy));
                sqlCommand.Parameters.Add(new SqlParameter("JobDescription", JobDescription));
                sqlCommand.Parameters.Add(new SqlParameter("Inspector", Inspector));
                sqlCommand.Parameters.Add(new SqlParameter("Date", Date));
                sqlCommand.Parameters.Add(new SqlParameter("Type", Type));


                //execute command 
                sqlCommand.ExecuteNonQuery();








            }
        }
    }
}
