using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Utilidades
{
    public static class Sql
    {
        public static DataSet Ejecutar(string sqlString)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection("Data Source=DBEFIDIA;Initial Catalog=nice_storage_center;Persist Security Info=True;User ID=nicevb;Password=N1c3ct134");
                sqlConn.Open();

                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlString, sqlConn);

                sqlDataAdapter.Fill(dataSet);

                sqlConn.Close();

                return dataSet;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Ha ocurrido un error relacionado con la base de datos o la instancia SQL." + Environment.NewLine +
                    e.Message, "Monitor AHK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error desconocido." + Environment.NewLine +
                    e.Message, "Monitor AHK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new DataSet();
        }
    }
}
