using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.DataAccess;

namespace WindowsFormsApp1.LogicLayers
{
    internal class LLUsers
    {
        internal DataRow IsNullLogin()
        {
            DataTable dataTable = SqlServerWorker.Select("Select * From Information");
            if (dataTable != null && dataTable.Rows.Count == 1)
            {
                return dataTable.Rows[0];   
            }
                return null;
        }
    }
}
