using CPUFramework;
using RecipeSystem;
using RecipeWinForm;
using System.Configuration;
using System.Data;
namespace RecipeWinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //string cs = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
            string cs = ConfigurationManager.ConnectionStrings["liveconn"].ConnectionString;

            DBManager.SetConnectionString(cs, false);


            frmMain f = new frmMain();
#if DEBUG
            f.Text = f.Text + " -Dev";
#endif
            Application.Run(f);
        }
    }
}

//DBManager.SetConnectionString("Server = tcp:chanim.database.windows.net,1433; Initial Catalog = RecipeDB; Persist Security Info = False; User ID = ChaniM; Password = Azure2026!; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
//DBManager.SetConnectionString("Server=.\\SQLExpress;Database=RecipeDB;User Id = appadmin; Password = HAPpy372($%;TrustServerCertificate=True;");

