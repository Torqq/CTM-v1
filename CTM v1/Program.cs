/*
 * Ce code est distribué sous les termes de la Licence Apache 2.0.
 * Vous pouvez obtenir une copie de la licence dans le fichier LICENSE à la racine du projet
 * ou sur le site web de l'Apache Software Foundation : http://www.apache.org/licenses/LICENSE-2.0
 */

namespace CTM_v1
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
            Application.Run(new CTM()); //Version 1.0
        }
    }
}