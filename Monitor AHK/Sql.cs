using System.Data;
using System.Data.SqlClient;

namespace Utilidades
{
    public static class Sql
    {
        public static DataSet ObtenerDataSet(string sqlQuery, string connectionString)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();

                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlConnection);

                sqlDataAdapter.Fill(dataSet);
                sqlConnection.Close();

                return dataSet;
            }
            catch (SqlException)
            {
                if (sqlConnection.State == ConnectionState.Open ||
                    sqlConnection.State == ConnectionState.Broken)
                    sqlConnection.Close();
                throw;
            }
            catch { throw; }
        }
    }
}
