using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travels.Master
{
    static class Program
    {
        public static Dictionary<string, Form> formContainer = new Dictionary<string, Form>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RegisterMenus();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        private static void RegisterMenus() {
            formContainer.Add("TravelsMaster", new Vehicle());
        }
    }
}
