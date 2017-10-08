using System;
using System.Collections.Generic;
using Switcher.Dto;

namespace Switcher.Interfaces.Views
{
    public interface IMainForm
    {
        List<Device> AudioDevices {  set; }
        List<Device> DisplayDevices {  set; }

        DeviceSettings DeviceSettings { get; set; }

        Action OnSaveButonClick { get; set; }

        Action OnViewActivated { get; set; }

        Action OnActivateTvPanelButtonClick { get; set; }

        Action OnActivateMonitorPanelButtonClick { get; set; }

        Action OnShowTrayContextMenuClick { get; set; }

        Action OnExitTrayContextMenuClick { get; set; }

        bool IsStartupEnabled { get; set; }

        bool IsAutoBPChecked { get; set; }

        bool IsViewMinimazed { get; }

        Action OnFormResize { get; set; }

        Action OnTrayIconDoubleClick { get; set; }

        Action OnSetTVDisplayButtonClick { get; set; }

        Action OnSetTVAudioButtonClick { get; set; }

        Action OnSetMonitorDisplayButtonClick { get; set; }

        Action OnSetMonitorAudioButtonClick { get; set; }

        Action OnSettingsChanged { get; set; }

        Action<bool> OnStartupChecked { get; set; }

        Action<bool> OnAutoBPModeChecked { get; set; }

        void MinimazeToTray(bool showBaloon);

        void SetActiveTVPanel();

        void SetActiveMonitorPanel();

        void MaximazeFromTray();

        void RunEvents();
    }
}