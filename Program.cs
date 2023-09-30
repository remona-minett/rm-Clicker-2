using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace clicker_2
{
    internal static class Program
    {
        public static string savepath; // user chosen location to save/load
        public static double[] savedata; // data loaded into here
        // The main entry point for the application.
        [STAThread]
        static void Main()
        {
            // Application.EnableVisualStyles(); // disables aero
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainMenu());
        }
    }
}
