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
        internal string CountPurchases()
        {
            int Count_Purchases = 0;
            LLPurchase purchase = new LLPurchase();
            DataTable dataTable = purchase.Select();
            DataRow dataRow;
            int countRows = dataTable.Rows.Count;
            for (int i = 0; i < countRows; i++)
            {
                dataRow = dataTable.Rows[i];
                Count_Purchases += Convert.ToInt32(dataRow["Number"]);
            }
            return Count_Purchases.ToString();
        }
        internal void CheckIs(string ProductName, int PriceProduct)
        {
            DataTable dataTable = Select();
            DataRow dataRow;
            int CountRows = dataTable.Rows.Count;
            for (int i = 0; i < CountRows; i++)
            {
                dataRow = dataTable.Rows[i];
                if (dataRow["Name"].Equals(ProductName))
                {
                    int CountPurchase = Convert.ToInt32(dataRow["Number"]);
                    int TotalPrice = Convert.ToInt32(dataRow["Price"]);
                    CountPurchase++;
                    TotalPrice += PriceProduct;
                    Update(ProductName, TotalPrice, CountPurchase);
                    return;
                }

            }
            Insert(ProductName, PriceProduct);

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
