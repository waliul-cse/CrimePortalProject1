using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace PoliceCrimePortal.Data.DataGateways
{
    public class clsBase
    {
        /// <summary>
        /// Base class for communication with database for data store and retrive 
        /// </summary>

        #region Member variables

        private DBConnector dbConnectorObject;
        private DataTable dataTableObject;
        private SqlConnection sqlConnectionObject;
        private SqlDataAdapter sqlDataAdepterObject;
        private DataSet dataSetObject;

        #endregion

        #region Methods to Generate IDs
        /// <summary>
        /// generate a new uniqueid
        /// </summary>
        /// <returns></returns>
        static public String GetNewID(string type)
        {
            String newID = type;
            DateTime now = System.DateTime.Now;
            newID += now.Year;
            newID += now.Month.ToString().PadLeft(2, '0');
            newID += now.Day.ToString().PadLeft(2, '0');
            newID += now.Hour.ToString().PadLeft(2, '0');
            newID += now.Minute.ToString().PadLeft(2, '0');
            newID += now.Second.ToString().PadLeft(2, '0');
            newID += now.Millisecond.ToString().PadLeft(3, '0');
            System.Threading.Thread.Sleep(3);
            return newID;
        }

        #endregion

        #region Salect Data
        public DataTable SelectData(string sSqlQuery)
        {
            dbConnectorObject = new DBConnector();
            dataTableObject = new DataTable();
            sqlConnectionObject = new SqlConnection();
            dataSetObject = new DataSet();
            try
            {
                sqlConnectionObject = dbConnectorObject.GetConnection;
                sqlDataAdepterObject = new SqlDataAdapter(sSqlQuery, sqlConnectionObject);

                sqlDataAdepterObject.Fill(dataSetObject);

                dataTableObject = dataSetObject.Tables[0];

                if (dataSetObject.Tables[0].Rows.Count == 0)
                {
                    return null;
                }

                else
                {
                    return dataTableObject;
                }
            }

            catch (Exception ex)
            {
                throw new Exception("DataBase Problem." + ex.Message);
            }

            finally
            {
                if (sqlConnectionObject.State == ConnectionState.Open)
                {
                    sqlConnectionObject.Close();
                }
            }
        }
        
        #endregion

        #region Execute query and insert data

        /// <summary>
        /// Insert data to database
        /// </summary>
        /// <param name="sqlString">Query striing</param>
        /// <returns></returns>
        public bool InsertData(string sqlString)
        {

            dbConnectorObject = new DBConnector();
            sqlConnectionObject = new SqlConnection();
            sqlConnectionObject = dbConnectorObject.GetConnection;

            try
            {
                sqlConnectionObject.Open();
                SqlCommand sqlCommandObject = new SqlCommand(sqlString, sqlConnectionObject);

                int i = sqlCommandObject.ExecuteNonQuery();
                if (i > 0)
                    return true;
                else
                    return false;
            }

            catch (SqlException ex)
            {
                throw new Exception(" Database problem.\n" + ex.Message);
            }

            finally
            {
                if (sqlConnectionObject.State == ConnectionState.Open)
                {
                    sqlConnectionObject.Close();
                }
            }
        }


        #endregion

        #region insert method with parameter
        /// <summary>
        /// this method insert data into database
        /// </summary>
        /// <param name="sqlString">Query string</param>
        /// <param name="parameters">Sql parameter</param>
        /// <returns></returns>
        public bool InsertData(string sqlString, List<SqlParameter> parametersList)
        {
            dbConnectorObject = new DBConnector();
            sqlConnectionObject = new SqlConnection();
            sqlConnectionObject = dbConnectorObject.GetConnection;

            try
            {
                sqlConnectionObject.Open();
                SqlCommand sqlCommandObject = new SqlCommand(sqlString, sqlConnectionObject);

                foreach (SqlParameter pr in parametersList)
                {
                    sqlCommandObject.Parameters.Add(pr);
                }

                int i = sqlCommandObject.ExecuteNonQuery();
                if (i > 0)
                    return true;
                else
                    return false;
            }

            catch (SqlException ex)
            {
                throw new Exception(" Database problem.\n" + ex.Message);
            }
            finally
            {
                if (sqlConnectionObject.State == System.Data.ConnectionState.Open)
                {
                    sqlConnectionObject.Close();
                }
            }
        }


        #endregion
    }
}
