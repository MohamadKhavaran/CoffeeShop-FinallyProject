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
    internal class LLProducts
    {
        internal DataTable Select()
        {
            return SqlServerWorker.Select("Select * From Products");

        }

        private bool CheckExistProduct(int ProductCode, ref int ProductNumber)
        {
            DataTable dataTable = Select();
            DataRow dataRow;
            int CountRows = dataTable.Rows.Count;
            for (int i = 0; i < CountRows; i++)
            {
                dataRow = dataTable.Rows[i];
                if (Convert.ToInt32(dataRow["ProductCode"]) == ProductCode && Convert.ToInt32(dataRow["ProductNumber"]) > 0)
                {
                    ProductNumber = Convert.ToInt32(dataRow["ProductNumber"]);
                    return true;
                }
            }
            return false;
        }
        internal bool Update(int ProductCode, int ProductNumber, int ProductPrice)
        {
            return SqlServerWorker.Execute
                (
                "UPDATE Products Set ProductNumber = " + $"N{ProductNumber},ProductPrice = " + $"N{ProductPrice}" +
                $" WHERE ProductCode = " + $"N{ProductCode}");
        }

        internal bool UpdateSell(int ProductCode)
        {
            int ProductNumber = 0;
            if (CheckExistProduct(ProductCode, ref ProductNumber))
            {
                ProductNumber--;
                return SqlServerWorker.Execute
               (
               "UPDATE Products Set ProductNumber = " + $"N'{ProductNumber}'" +
               $" WHERE ProductCode = " + $"N'{ProductCode}'");
            }
            else
                return false;
        }

        internal bool UpdateWithProductName(string ProductName) //For Add Removed Products In Shopping List
        {
            DataTable dataTable = Select();
            DataRow dataRow;
            int CountRows = dataTable.Rows.Count;
            int ProductNumber = 0;
            for (int i = 0; i < CountRows; i++)
            {
                dataRow = dataTable.Rows[i];
                if ((dataRow["ProductName"]).ToString().Equals(ProductName))
                {
                    ProductNumber = Convert.ToInt32(dataRow["ProductNumber"]);
                    ProductNumber++;
                    break;
                }
            }
            return SqlServerWorker.Execute
              (
              "UPDATE Products Set ProductNumber = " + $"N'{ProductNumber}'" +
              $" WHERE ProductName = " + $"N'{ProductName}'");
        }

        internal bool Delete(int ProductCode)
        {
            return SqlServerWorker.Execute($"DELETE FROM Products WHERE Name = {ProductCode};");
        }

    }
}


