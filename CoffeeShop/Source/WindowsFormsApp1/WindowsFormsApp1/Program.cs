using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.LogicLayers;
using WindowsFormsApp1.UserInterFaces;
namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LLUsers lLUser = new LLUsers();
            DataRow dataRow = lLUser.IsNullLogin();
            if (dataRow == null)
                Application.Run(new FormEntry());
            else
                Application.Run(new FormMain());

        }
    }
}
