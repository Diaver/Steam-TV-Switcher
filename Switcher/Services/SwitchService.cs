using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Timers;
using Switcher.Dto;
using Switcher.Interfaces;
using Switcher.Interfaces.Config;

namespace Switcher
{
    public class SwitchService : ISwitchService
    {
        private readonly IConfigProvider _configProvider;
        private readonly IHardwareSwitcher _hardwareSwitcher;

        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        private static extern int FindWindow(string sClass, string sWindow);

        private bool _isSteamWorking;

        private Timer _timer;

        public SwitchService(IConfigProvider configProvider, IHardwareSwitcher hardwareSwitcher)
        {
            _configProvider = configProvider;
            _hardwareSwitcher = hardwareSwitcher;
            InitTimer();
        }

        private void InitTimer()
        {
            _timer = new Timer(1000);
            TaskFactory taskFactory = new TaskFactory();
            _timer.Elapsed += (sender, e) => taskFactory.StartNew(HandleTimer);
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        private void HandleTimer()
        {
            DeviceSettings deviceSettings = _configProvider.GetDeviceSettings();

            int steamWorking = FindWindow("CUIEngineWin32", "Steam");
            if (steamWorking != 0 && _isSteamWorking == false)
            {
                if (deviceSettings.SteamAudio.IsEmpty() == false)
                {
                    _hardwareSwitcher.SetDefaultPlaybackDevice(deviceSettings.SteamAudio.Name);
                }
                if (deviceSettings.SteamDisplay.IsEmpty() == false)
                {
                    _hardwareSwitcher.SetPrimaryDisplay(deviceSettings.SteamDisplay.Name);
                }
                _isSteamWorking = true;
            }
            else if (steamWorking == 0 && _isSteamWorking)
            {
                if (deviceSettings.DefaultAudio.IsEmpty() == false)
                {
                    _hardwareSwitcher.SetDefaultPlaybackDevice(deviceSettings.DefaultAudio.Name);
                }
                if (deviceSettings.DefaultDisplay.IsEmpty() == false)
                {
                    _hardwareSwitcher.SetPrimaryDisplay(deviceSettings.DefaultDisplay.Name);
                }
                _isSteamWorking = false;
            }
        }
    }
}
