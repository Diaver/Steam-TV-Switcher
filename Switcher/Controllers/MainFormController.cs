using System.Windows.Forms;
using Switcher.Dto;
using Switcher.Interfaces;
using Switcher.Interfaces.Config;
using Switcher.Interfaces.Controllers;
using Switcher.Interfaces.Views;
using Timer = System.Timers.Timer;

namespace Switcher.Controllers
{
    public class MainFormController : IMainFormController
    {
        private readonly IDevicesProvider _devicesProvider;
        private readonly IConfigProvider _configProvider;
        private readonly IAppStartupManager _appStartupManager;
        private readonly ISwitchService _switchService;
        private readonly IHardwareSwitcher _hardwareSwitcher;
        private IMainForm _mainForm;
        private bool _isMinimazedOnStartUp;

        public MainFormController(IDevicesProvider devicesProvider, IConfigProvider configProvider, IAppStartupManager appStartupManager, ISwitchService switchService, IHardwareSwitcher hardwareSwitcher)
        {
            _devicesProvider = devicesProvider;
            _configProvider = configProvider;
            _appStartupManager = appStartupManager;
            _switchService = switchService;
            _hardwareSwitcher = hardwareSwitcher;
        }

        public void Run(IMainForm mainForm, bool isMinimazedOnStartUp)
        {
            DeviceSettings deviceSettings = _configProvider.GetDeviceSettings();

            _mainForm = mainForm;

            SetAvailableDevices();
            SubscribeViewEvents();
            SetCurrentSettings();
            _isMinimazedOnStartUp = isMinimazedOnStartUp;
            SetActivePanel();
            RunActivePanelTimer();

            StartAutoSwitchService(deviceSettings.AutoBPMode);
        }

        private void RunActivePanelTimer()
        {
            Timer timer = new Timer(2000);
            timer.Elapsed += (sender, e) => ActivePanelTimerTick();
            timer.Start();
        }

        private void ActivePanelTimerTick()
        {
            SetActivePanel();
        }

        private void SetAvailableDevices()
        {
            _mainForm.AudioDevices = _devicesProvider.GetAdudioDevices();
            _mainForm.DisplayDevices = _devicesProvider.GetDispayDevices();
            _mainForm.DeviceSettings = _configProvider.GetDeviceSettings();
        }

        private void SetActivePanel()
        {
            Device activeDisplay = _devicesProvider.GetActiveDisplay();
            DeviceSettings deviceSettings = _configProvider.GetDeviceSettings();
            if (deviceSettings.SteamDisplay.Name == activeDisplay.Name && deviceSettings.DefaultDisplay.Name != activeDisplay.Name)
            {
                _mainForm.SetActiveTVPanel();
            }

            if (deviceSettings.DefaultDisplay.Name == activeDisplay.Name && deviceSettings.SteamDisplay.Name != activeDisplay.Name)
            {
                _mainForm.SetActiveMonitorPanel();
            }
        }

        private void SetCurrentSettings()
        {
            DeviceSettings deviceSettings = _configProvider.GetDeviceSettings();

            _mainForm.DeviceSettings = deviceSettings;
            _mainForm.IsStartupEnabled = _appStartupManager.IsStartupEnabled();
            _mainForm.IsAutoBPChecked = deviceSettings.AutoBPMode;
        }

        private void SubscribeViewEvents()
        {
            _mainForm.OnSaveButonClick += OnSaveButonClick;
            _mainForm.OnFormResize += OnFormResize;
            _mainForm.OnTrayIconDoubleClick += OnTrayIconDoubleClick;
            _mainForm.OnStartupChecked += OnStartupChecked;
            _mainForm.OnViewActivated += OnViewActivated;
            _mainForm.OnSettingsChanged += OnSettingsChangedClick;
            _mainForm.OnAutoBPModeChecked += OnAutoBpModeChecked;
            _mainForm.OnActivateMonitorPanelButtonClick += OnActivateMonitorPanelButtonClick;
            _mainForm.OnActivateTvPanelButtonClick += OnActivateTvPanelButtonClick;

            _mainForm.OnSetTVDisplayButtonClick += OnSetTVDisplayButtonClick;
            _mainForm.OnSetTVAudioButtonClick +=OnSetTVAudioButtonClick;

            _mainForm.OnSetMonitorDisplayButtonClick+=OnSetMonitorDisplayButtonClick;
            _mainForm.OnSetMonitorAudioButtonClick +=OnSetMonitorAudioButtonClick;
            _mainForm.OnExitTrayContextMenuClick +=OnExitTrayContextMenuClick;
            _mainForm.OnShowTrayContextMenuClick +=OnShowTrayContextMenuClick;
        }

        private void OnShowTrayContextMenuClick()
        {
            _mainForm.MaximazeFromTray();
        }

        private void OnExitTrayContextMenuClick()
        {
            Application.Exit();
        }

        private void OnSetMonitorAudioButtonClick()
        {
            DeviceSettings deviceSettings = _configProvider.GetDeviceSettings();
            if (deviceSettings.DefaultAudio.IsEmpty() == false)
            {
                _hardwareSwitcher.SetDefaultPlaybackDevice(deviceSettings.DefaultAudio.Name);
            }
        }

        private void OnSetMonitorDisplayButtonClick()
        {
            DeviceSettings deviceSettings = _configProvider.GetDeviceSettings();
            if (deviceSettings.DefaultDisplay.IsEmpty() == false)
            {
                _hardwareSwitcher.SetPrimaryDisplay(deviceSettings.DefaultDisplay.Name);
            }
        }

        private void OnSetTVAudioButtonClick()
        {
            DeviceSettings deviceSettings = _configProvider.GetDeviceSettings();
            if (deviceSettings.SteamAudio.IsEmpty() == false)
            {
                _hardwareSwitcher.SetDefaultPlaybackDevice(deviceSettings.SteamAudio.Name);
            }
        }

        private void OnSetTVDisplayButtonClick()
        {
            DeviceSettings deviceSettings = _configProvider.GetDeviceSettings();
            if (deviceSettings.SteamDisplay.IsEmpty() == false)
            {
                _hardwareSwitcher.SetPrimaryDisplay(deviceSettings.SteamDisplay.Name);
            }
        }

        private void OnActivateTvPanelButtonClick()
        {
            DeviceSettings deviceSettings = _configProvider.GetDeviceSettings();
            if (deviceSettings.SteamAudio.IsEmpty() == false)
            {
                _hardwareSwitcher.SetDefaultPlaybackDevice(deviceSettings.SteamAudio.Name);
            }
            if (deviceSettings.SteamDisplay.IsEmpty() == false)
            {
                _hardwareSwitcher.SetPrimaryDisplay(deviceSettings.SteamDisplay.Name);
            }

            _mainForm.SetActiveTVPanel();
        }

        private void OnActivateMonitorPanelButtonClick()
        {
            DeviceSettings deviceSettings = _configProvider.GetDeviceSettings();
            if (deviceSettings.DefaultAudio.IsEmpty() == false)
            {
                _hardwareSwitcher.SetDefaultPlaybackDevice(deviceSettings.DefaultAudio.Name);
            }
            if (deviceSettings.DefaultDisplay.IsEmpty() == false)
            {
                _hardwareSwitcher.SetPrimaryDisplay(deviceSettings.DefaultDisplay.Name);
            }
            _mainForm.SetActiveMonitorPanel();
        }

        private void StartAutoSwitchService(bool isEnabled)
        {

            if (isEnabled)
            {
                _switchService.Start();
            }
            else
            {
                _switchService.Stop();
            }
        }

        private void OnAutoBpModeChecked(bool isEnabled)
        {
            StartAutoSwitchService(isEnabled);
            OnSettingsChangedClick();
        }

        private void OnSettingsChangedClick()
        {
            DeviceSettings deviceSettings = _mainForm.DeviceSettings;
            _configProvider.SaveDeviceSettings(deviceSettings);
        }

        private void OnViewActivated()
        {
            if (_isMinimazedOnStartUp)
            {
                _mainForm.MinimazeToTray(false);
                _isMinimazedOnStartUp = false;

            }
            _mainForm.RunEvents();
        }

        private void OnStartupChecked(bool isChecked)
        {
            _appStartupManager.Startup(isChecked);
        }

        private void OnTrayIconDoubleClick()
        {
            _mainForm.MaximazeFromTray();
        }

        private void OnFormResize()
        {
            if (_mainForm.IsViewMinimazed)
            {
                _mainForm.MinimazeToTray(true);
            }
        }

        private void OnSaveButonClick()
        {
            _configProvider.SaveDeviceSettings(_mainForm.DeviceSettings);
        }
    }
}
