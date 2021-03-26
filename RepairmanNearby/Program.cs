using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairmanNearby
{
    static class Data
    {
        public static string ValueEmail { get; set; }
        public static string ValuePassword { get; set; }
        public static int ValueIDMaster { get; set; }
        public static int ValueIDUser { get; set; }
        public static int ValueIDMasterOnAurization { get; set; }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAutorization());
        }
    }
}
