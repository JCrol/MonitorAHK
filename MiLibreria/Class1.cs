using System.Data;
using System.Data.SqlClient;

namespace MiLibreria
{
    public static class Utilidades
    {
        public static DataSet Ejecutar(string sqlString)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=DBEFIDIA;Initial Catalog=nice_storage_center;Persist Security Info=True;User ID=nicevb;Password=N1c3ct134");
            sqlConn.Open();

            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlString, sqlConn);

            sqlDataAdapter.Fill(dataSet);

            sqlConn.Close();

            return dataSet;
        }
    }
}
