using GestMegots.Formulaires;

namespace GestMegots
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
            //C'est ici que l'on définit le formulaire qui sera chargé au lancement de l'application
            Application.Run(new FmLogin());
        }
    }
}