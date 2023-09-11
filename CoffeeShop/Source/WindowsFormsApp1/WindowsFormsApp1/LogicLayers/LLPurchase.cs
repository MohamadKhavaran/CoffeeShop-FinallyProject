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
    internal class LLPurchase
    {
        internal DataTable Select()
        {
            return SqlServerWorker.Select("Select * From Purchases");

        }
        internal bool Insert(string Name, int Price)
        {
            return SqlServerWorker.Execute
                (
                "Insert Into Purchases(Name, Price, Number)" +
                "Values(" + $"N'{Name}'," + $"N'{Price}'," + $"N'{1}');"
                );
        }
        internal bool Update(string Name, int Price, int Number)
        {
            return SqlServerWorker.Execute
                (
                "UPDATE Purchases Set Name = " + $"N'{Name}',Price = " + $"N'{Price}', Number = " + $"N'{Number}'" +
                $" WHERE Name = " + $"N'{Name}'");
        }
        internal bool Delete(string Name)
        {
            return SqlServerWorker.Execute($"DELETE FROM Purchases WHERE Name = '{Name}';");
        }

    }
}
