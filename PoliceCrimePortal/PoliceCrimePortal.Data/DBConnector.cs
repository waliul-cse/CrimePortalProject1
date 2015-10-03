using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;


namespace PoliceCrimePortal.Data
{

    public class DBConnector
    {
        private string connectionString = null;
        private SqlConnection sqlConn = null;

        public DBConnector()
        {
            connectionString = ConfigurationManager.ConnectionStrings["PCPDBConnection"].ToString();

            sqlConn = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Return sqlConnection 
        /// </summary>
        public SqlConnection GetConnection
        {
            get
            {
                return sqlConn;
            }

        }
    }
}
