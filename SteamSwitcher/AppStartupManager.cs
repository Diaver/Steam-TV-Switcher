using System.Windows.Forms;
using Microsoft.Win32;
using Switcher.Interfaces;

namespace SteamSwitcher
{
    public class AppStartupManager : IAppStartupManager
    {
        public static string MinimazedArg = "minimazed";
        readonly RegistryKey _rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public void Startup(bool isEnable)
        {
            if (isEnable)
            {
                EnableStartup();
            }
            else
            {
                DisableStartup();
            }
        }

        public bool IsStartupEnabled()
        {
            return _rkApp.GetValue(Application.ProductName) != null;
        }

        private void EnableStartup()
        {
            if (IsStartupEnabled() == false)
                _rkApp.SetValue(Application.ProductName, Application.ExecutablePath + " " + MinimazedArg);
        }

        private void DisableStartup()
        {
            if (IsStartupEnabled())
                _rkApp.DeleteValue(Application.ProductName, false);
        }
    }
}
