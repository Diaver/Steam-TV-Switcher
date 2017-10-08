using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Switcher.Interfaces;

namespace Switcher
{
    public class HardwareSwitcher : IHardwareSwitcher
    {

        private const string NirCmdFolder = "nircmd";
        private const string NirCmdExecutable = "nircmd.exe";

        private const string NirCmdDefaultSoundDeviceArgTemplate = "setdefaultsounddevice \"{0}\"";
        private const string NirCmdPrimaryDisplayArgTemplate = "setprimarydisplay \"{0}\"";


        public void SetPrimaryDisplay(string tv)
        {
            StartProcessAndWaitForExit(GetNirCmdPath(), string.Format(CultureInfo.InvariantCulture, NirCmdPrimaryDisplayArgTemplate, tv));
        }

        public void SetDefaultPlaybackDevice(string deviceName)
        {
            StartProcessAndWaitForExit(GetNirCmdPath(), string.Format(CultureInfo.InvariantCulture, NirCmdDefaultSoundDeviceArgTemplate, deviceName));
        }

        private void StartProcessAndWaitForExit(string executable, string arguments)
        {
            var process = Process.Start(new ProcessStartInfo(executable, arguments)
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = GetNirCmdWorkingDirectory(),
            });


            process.WaitForExit();
        }

        private string GetNirCmdPath()
        {
            string currentFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            return Path.Combine(currentFolder, NirCmdFolder, NirCmdExecutable);
        }

        private string GetNirCmdWorkingDirectory()
        {
            string currentFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            return Path.Combine(currentFolder, NirCmdFolder);
        }
    }
}
