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
        internal bool Insert(string FirstName, string FamilyName, string Email, string Phone)
        {
            return SqlServerWorker.Execute
                (
                "Insert Into Information(FirstName, FamilyName , Email , Phone , User_Id)" +
                "Values(" + $"N'{FirstName}'," + $"N'{FamilyName}'," + $"N'{Email}'," + $"N'{Phone}' ," +$"N'{0}');"
                );
        }
        internal bool Update(string FirstName, string FamilyName, string Email, string Phone)
        {
            return SqlServerWorker.Execute
                (
                "UPDATE Information Set " +
                "FirstName = " + $"N'{FirstName}',FamilyName = " + $"N'{FamilyName}', Email = " + $"N'{Email}', Phone = " + $"N'{Phone}'" + 
                "WHERE User_Id = "+$"N'{0}'"
                );
        }
        internal bool Delete()
        {
            return SqlServerWorker.Execute($"DELETE FROM INFORMATION WHERE User_ID={0};");
        }

    }
}
