using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grizzlies_Helping_Grizzlies
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Testing Jira again
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GHGForm());
        }
    }
}