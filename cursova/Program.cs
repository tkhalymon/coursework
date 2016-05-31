using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace cursova
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //CultureInfo.DefaultThreadCurrentCulture = ;
            //CultureInfo.CurrentCulture = new CultureInfo("uk-UA");
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("uk-UA");
            MessageBox.Show(CultureTypes.InstalledWin32Cultures.ToString());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
