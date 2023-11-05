using GerenciamentoMateriaPrima.Controller;

namespace GerenciamentoMateriaPrima
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
            var home = new formHome();
            var controller = new HomeController(home);
            home.SetControlador(controller);
            Application.Run(home);
        }
    }
}