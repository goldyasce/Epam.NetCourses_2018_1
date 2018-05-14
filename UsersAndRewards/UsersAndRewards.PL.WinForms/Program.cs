using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersAndRewards.BL.Logic;
using UsersAndRewards.Shared;

namespace UsersAndRewards.PL.WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ILogic logic = new Logic();
            Application.Run(new MainForm(logic));
        }
    }
}
