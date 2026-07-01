using RecipeSystem;
using RecipeWinForm;
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
            //DBManager.SetConnectionString("Server = tcp:chanim.database.windows.net,1433; Initial Catalog = RecipeDB; Persist Security Info = False; User ID = ChaniM; Password = Azure2026!; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=RecipeDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
            Application.Run(new frmDashboard());
        }
    }
}