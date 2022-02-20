using Axie_Scholarship.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axie_Scholarship.DataAccess
{
    public class DataAccessLayer
    {
        string ConnectionString = GetConnection.Connection();
        public DataAccessLayer()
        {
        }

        // Create SQL Command WITH parameters
        public SqlCommand CreateSqlCommand(SqlConnection mySqlConnection, string StoredProcedure, params SqlParameter[] arrParams)
        {
            SqlCommand sqlCmd;

            sqlCmd = new SqlCommand(StoredProcedure, mySqlConnection);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter parameterItem in arrParams)
                sqlCmd.Parameters.Add(parameterItem);

            return sqlCmd;
        }

        // Create SQL Command WITHOUT parameters
        public SqlCommand CreateSqlCommand(SqlConnection mySqlConnection, string StoredProcedure)
        {
            SqlCommand sqlCmd;

            sqlCmd = new SqlCommand(StoredProcedure, mySqlConnection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            return sqlCmd;
        }

        // Execute Stored Procedures WITH Parameters
        public void ExecuteSQLProcedure(ref string StoredProcedure, params SqlParameter[] ArrParams)
        {
            SqlCommand sqlCmd;
            SqlConnection mySqlConnection = new SqlConnection(ConnectionString);

            try
            {
                mySqlConnection.Open();
                sqlCmd = CreateSqlCommand(mySqlConnection, StoredProcedure, ArrParams);
                sqlCmd.CommandTimeout = 0;
                sqlCmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error executing procedure : " + StoredProcedure + " || " + ex.Message, ex.InnerException);
            }
            finally
            {
                if (mySqlConnection.State != ConnectionState.Closed)
                    mySqlConnection.Close();

                if (mySqlConnection != null)
                {
                    mySqlConnection.Dispose();
                    mySqlConnection = null/* TODO Change to default(_) if this is not a reference type */;
                }
            }
        }

        // Execute Stored Procedures WITHOUT Parameters
        public void ExecuteSQLProcedure(ref string StoredProcedure)
        {
            SqlCommand sqlCmd;
            SqlConnection mySqlConnection = new SqlConnection(ConnectionString);

            try
            {
                mySqlConnection.Open();
                sqlCmd = CreateSqlCommand(mySqlConnection, StoredProcedure);
                sqlCmd.CommandTimeout = 0;
                sqlCmd.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                throw new Exception("Error executing procedure : " + StoredProcedure + " || " + ex.Message, ex.InnerException);
            }

            finally
            {
                if (mySqlConnection.State != ConnectionState.Closed)
                    mySqlConnection.Close();

                if (mySqlConnection != null)
                {
                    mySqlConnection.Dispose();
                    mySqlConnection = null/* TODO Change to default(_) if this is not a reference type */;
                }
            }
        }

        // Make Inpunt Parameters
        public SqlParameter MakeInputParameters(string ParameterName, object objParameterValue)
        {
            SqlParameter parameters;

            parameters = new SqlParameter(ParameterName, objParameterValue);
            parameters.Direction = ParameterDirection.Input;

            return parameters;
        }

        // Execute Data Tables WITH Parameters
        public DataTable ExecuteDataTable(string StoredProcedure, params SqlParameter[] ArrParams)
        {
            SqlCommand mySqlCommmand;
            SqlConnection mySqlConnection = new SqlConnection(ConnectionString);
            DataTable myDataTable = new DataTable();
            SqlDataReader myDataReader;


            try
            {
                mySqlConnection.Open();
                mySqlCommmand = CreateSqlCommand(mySqlConnection, StoredProcedure, ArrParams);
                mySqlCommmand.CommandTimeout = 0;
                myDataReader = mySqlCommmand.ExecuteReader();

                myDataTable.Load(myDataReader);

                if (myDataTable.Rows.Count > 0)
                    return myDataTable;
                else
                    return null/* TODO Change to default(_) if this is not a reference type */;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error executing procedure : " + StoredProcedure + " || " + ex.Message, ex.InnerException);
            }

            finally
            {
                if (mySqlConnection.State != ConnectionState.Closed)
                    mySqlConnection.Close();

                if (mySqlConnection != null)
                {
                    mySqlConnection.Dispose();
                    mySqlConnection = null/* TODO Change to default(_) if this is not a reference type */;
                }
            }

            //return null/* TODO Change to default(_) if this is not a reference type */;
        }

        // Execute Data Tables WITHOUT Parameters
        public DataTable ExecuteDataTable(string StoredProcedure)
        {
            SqlCommand mySqlCommmand;
            SqlConnection mySqlConnection = new SqlConnection(ConnectionString);
            DataTable myDataTable = new DataTable();
            SqlDataReader myDataReader;

            try
            {
                mySqlConnection.Open();
                mySqlCommmand = CreateSqlCommand(mySqlConnection, StoredProcedure);
                mySqlCommmand.CommandTimeout = 0;
                myDataReader = mySqlCommmand.ExecuteReader();

                myDataTable.Load(myDataReader);

                if (myDataTable.Rows.Count > 0)
                    return myDataTable;
                else
                    return null/* TODO Change to default(_) if this is not a reference type */;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error executing procedure : " + StoredProcedure + " || " + ex.Message, ex.InnerException);
            }

            finally
            {
                if (mySqlConnection.State != ConnectionState.Closed)
                    mySqlConnection.Close();

                if (mySqlConnection != null)
                {
                    mySqlConnection.Dispose();
                    mySqlConnection = null/* TODO Change to default(_) if this is not a reference type */;
                }
            }

            //return null/* TODO Change to default(_) if this is not a reference type */;
        }

        // Execute Stored Procedures WITH Parameters
        public string ExecuteSQLProcedureReturn(ref string StoredProcedure, params SqlParameter[] ArrParams)
        {
            SqlCommand sqlCmd;
            SqlConnection mySqlConnection = new SqlConnection(ConnectionString);
            string result = null;

            try
            {
                mySqlConnection.Open();
                sqlCmd = CreateSqlCommand(mySqlConnection, StoredProcedure, ArrParams);
                sqlCmd.CommandTimeout = 0;
                //result = sqlCmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error executing procedure : " + StoredProcedure + " || " + ex.Message, ex.InnerException);
            }

            finally
            {
                if (mySqlConnection.State != ConnectionState.Closed)
                    mySqlConnection.Close();

                if (mySqlConnection != null)
                {
                    mySqlConnection.Dispose();
                    mySqlConnection = null/* TODO Change to default(_) if this is not a reference type */;
                }
            }
            return result;
        }

        public void ExecuteString(string SQLString)
        {
            SqlConnection mySqlConnection = new SqlConnection(ConnectionString);
            try
            {
                mySqlConnection.Open();
                SqlCommand sqlCmd = new SqlCommand(SQLString, mySqlConnection);
                sqlCmd.CommandTimeout = 0;
                sqlCmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("SQL Script Done");
            }
        }

        public DataTable ExecuteQuery(string SQLString)
        {
            SqlConnection mySqlConnection = new SqlConnection(ConnectionString);
            DataTable myDataTable = new DataTable();
            SqlDataReader myDataReader;

            try
            {
                mySqlConnection.Open();
                SqlCommand sqlCmd = new SqlCommand(SQLString, mySqlConnection);
                sqlCmd.CommandTimeout = 0;
                myDataReader = sqlCmd.ExecuteReader();
                myDataTable.Load(myDataReader);

                if (myDataTable.Rows.Count > 0)
                    return myDataTable;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing SQL script : " + ex.Message, ex.InnerException);
            }
            finally
            {
                if (mySqlConnection.State != ConnectionState.Closed)
                    mySqlConnection.Close();

                if (mySqlConnection != null)
                {
                    mySqlConnection.Dispose();
                    mySqlConnection = null/* TODO Change to default(_) if this is not a reference type */;
                }
            }
        }

        // Execute Stored Procedures WITH Parameters
        public int ExecuteSQLProcedureWithReturn(ref string StoredProcedure, params SqlParameter[] ArrParams)
        {
            SqlCommand sqlCmd;
            SqlConnection mySqlConnection = new SqlConnection(ConnectionString);
            int ctr;

            try
            {
                mySqlConnection.Open();
                sqlCmd = CreateSqlCommand(mySqlConnection, StoredProcedure, ArrParams);
                ctr = sqlCmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error executing procedure : " + StoredProcedure + " || " + ex.Message, ex.InnerException);
            }
            finally
            {
                if (mySqlConnection.State != ConnectionState.Closed)
                    mySqlConnection.Close();

                if (mySqlConnection != null)
                {
                    mySqlConnection.Dispose();
                    mySqlConnection = null/* TODO Change to default(_) if this is not a reference type */;
                }
            }
            return ctr;
        }


    }
}

