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
            // Establece la configuraci�n de la aplicaci�n, como DPI alto o fuente predeterminada.
            ApplicationConfiguration.Initialize();

            // Ejecuta el formulario principal de la aplicaci�n.
            Application.Run(new Form1());
        }
    }
}
