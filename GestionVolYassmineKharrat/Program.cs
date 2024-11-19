using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVolYassmineKharrat
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Avion av1 = new Avion("X85100", "Airbus", 200, true);
            Avion av2 = new Avion("X85100", "Boeing", 150, true);
            Avion av3 = new Avion("X85100", "Concorde", 70, true);
            Avion.LesAvions.Add(av1);
            Avion.LesAvions.Add(av2);
            Avion.LesAvions.Add(av3);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuPrincipal());
        }
    }
}
