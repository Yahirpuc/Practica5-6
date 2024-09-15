using System;
using System.Windows.Forms;
using TorresDeHanoiApp;

namespace Tarea6
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Establece la configuración de la aplicación, como DPI alto o fuente predeterminada.
            ApplicationConfiguration.Initialize();

            // Ejecuta el formulario principal de la aplicación.
            Application.Run(new Form1());
        }
    }
}
