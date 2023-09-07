using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.DataAccess
{
    internal class SqlServerWorker
    {
        internal static string STR_CONNECTION_STRING = "Server=.;Database=CoffeeeShop;Trusted_Connection=True;";

        internal static DataTable Select(string strCmdText)
        {
            try
            {
                SqlConnection connection = new SqlConnection(STR_CONNECTION_STRING);
                connection.Open();
                SqlCommand command = new SqlCommand(strCmdText, connection);
                SqlDataReader sdr = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(sdr);

                sdr.Close();
                connection.Close();

                return dataTable;
            }
            catch
            {
                return null;
            }
        }
    }
}
