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
            frmMain f = new frmMain();
#if DEBUG
            f.Text = f.Text + " -Dev";
#endif
            Application.Run(f);
        }
    }
}

