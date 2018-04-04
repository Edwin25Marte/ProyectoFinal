using ProyectoFinal.Login;
using ProyectoFinal.Registros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LogInForm main = new LogInForm();
            main.Show();
            Application.Run();

            //Application.Run(new RegUsuariosForm());
        }
    }
}
