/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clicker_2
{
    class saveLoad
    {
        public static bool saveData()
        {
            string datetime = DateTime.Now.ToString("MM-dd-yyyy-HHmm");
            var savedialog = new SaveFileDialog
            {
                Title = "Save your progress",
                Filter = "Clicker 2 saves (*.rmc2)|*.rmc2|All files (*.*)|*.*",
                FilterIndex = 1,
                FileName = "progress-" + datetime,
                RestoreDirectory = true
            };

            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                Program.savepath = savedialog.FileName; // user selection

            }
        }

        public static bool loadData()
        {
            var loaddialog = new OpenFileDialog
            {
                Title = "Load your progress",
                Filter = "Clicker 2 saves (*.rmc2)|*.rmc2|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                CheckFileExists = true,
                CheckPathExists = true
            };
        }

        static bool evaluateIntegrity(double[] savedata) // check if the save data is valid (numbers etc)
        {

        }

        static bool evaluateVersion(double version) // check what version the save data is from
        {

        }

        static double[] upgradeVersion(double[] oldsavedata)
        {

        }

        /*static double[] upgradeLegacy(double[] oldsavedata)
        {
            // reserved for future addition
        }*/
    //}
//}
