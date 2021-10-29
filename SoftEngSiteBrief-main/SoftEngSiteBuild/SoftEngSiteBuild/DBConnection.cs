using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftEngSiteBuild
{
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
    }
}
