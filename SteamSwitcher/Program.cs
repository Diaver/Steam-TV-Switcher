using System;
using System.Linq;
using System.Windows.Forms;
using SteamSwitcher.Views;
using Switcher.Interfaces.Controllers;

namespace SteamSwitcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RunApp(args);
        }

        private static void RunApp(string[] args)
        {
            DIRegistration diRegistration = new DIRegistration();
            diRegistration.Register();
            IMainFormController mainFormController = diRegistration.Resolve<IMainFormController>();

            bool isMinimazed = args != null && args.Any() && args[0] == AppStartupManager.MinimazedArg;

            MainForm mainForm = new MainForm();
          
            mainFormController.Run(mainForm, isMinimazed);

            Application.Run(mainForm);
        }
    }
}
