using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Switcher.Dto;
using Switcher.Interfaces.Views;

namespace SteamSwitcher.Views
{
    public partial class MainForm : Form, IMainForm
    {
        public List<Device> AudioDevices
        {
            set
            {
                steamAudioBindingSource.DataSource = value;
                defaultAudioBindingSource.DataSource = value;
            }
        }

        public List<Device> DisplayDevices
        {
            set
            {
                steamDisplayBindingSource.DataSource = value;
                defaultDisplayBindingSource.DataSource = value;
            }
        }

        public DeviceSettings DeviceSettings
        {
            get
            {
                return 
                    new DeviceSettings
                    {
                        SteamDisplay = steamDisplayBindingSource.Current as Device,
                        SteamAudio = steamAudioBindingSource.Current as Device,
                        DefaultDisplay = defaultDisplayBindingSource.Current as Device,
                        DefaultAudio = defaultAudioBindingSource.Current as Device,
                        AutoBPMode = IsAutoBPChecked
                    };
            }
            set
            {
                settingsBindingSource.DataSource = value;
            }
        }

        public Action OnSaveButonClick { get; set; }
        public Action OnViewActivated { get; set; }
        public Action OnActivateTvPanelButtonClick { get; set; }
        public Action OnActivateMonitorPanelButtonClick { get; set; }
        public Action OnShowTrayContextMenuClick { get; set; }
        public Action OnExitTrayContextMenuClick { get; set; }

        public bool IsStartupEnabled
        {
            get { return startUpCheckBox.Checked; }
            set { startUpCheckBox.Checked = value; }
        }

        public bool IsAutoBPChecked
        {
            get { return autoBPModeCheckBox.Checked; }
            set { autoBPModeCheckBox.Checked = value; }
        }

        public bool IsViewMinimazed => WindowState == FormWindowState.Minimized;

        public Action OnFormResize { get; set; }
        public Action OnTrayIconDoubleClick { get; set; }
        public Action OnSetTVDisplayButtonClick { get; set; }
        public Action OnSetTVAudioButtonClick { get; set; }
        public Action OnSetMonitorDisplayButtonClick { get; set; }
        public Action OnSetMonitorAudioButtonClick { get; set; }
        public Action OnSettingsChanged { get; set; }
        public Action<bool> OnStartupChecked { get; set; }
        public Action<bool> OnAutoBPModeChecked { get; set; }

        public void MinimazeToTray(bool showBaloon)
        {
            if(showBaloon)
                notifyIcon.ShowBalloonTip(1000);

            Hide();
            notifyIcon.Visible = true;
        }

        public void SetActiveTVPanel()
        {
            tvGroupBox.Text = @"TV - Active";
            monitorGroupBox.Text = @"Monitor";
        }

        public void SetActiveMonitorPanel()
        {
            tvGroupBox.Text = @"TV";
            monitorGroupBox.Text = @"Monitor - Active";
        }

        public void MaximazeFromTray()
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        public void RunEvents()
        {
            SubscribeEvents();
        }

        public MainForm()
        {
            InitializeComponent();
            Activated += (s, e) => OnViewActivated();
        }

        private void SubscribeEvents()
        {
            setTVDispalyButton.Click += (s, e) => OnSetTVDisplayButtonClick();
            setTVAudioButton.Click += (s, e) => OnSetTVAudioButtonClick();
            setMonitorDispalyButton.Click += (s, e) => OnSetMonitorDisplayButtonClick();
            setMonitorAudioButton.Click += (s, e) => OnSetMonitorAudioButtonClick();

            steamDisplayBindingSource.CurrentItemChanged += (s, e) => OnSettingsChanged();
            steamAudioBindingSource.CurrentItemChanged += (s, e) => OnSettingsChanged();
            defaultDisplayBindingSource.CurrentItemChanged += (s, e) => OnSettingsChanged();
            defaultAudioBindingSource.CurrentItemChanged += (s, e) => OnSettingsChanged();

            activateTvPanelButton.Click += (s, e) => OnActivateTvPanelButtonClick();
            activateMonitorPanelButton.Click += (s, e) => OnActivateMonitorPanelButtonClick();
            Resize += (s, e) => OnFormResize();
            notifyIcon.MouseDoubleClick += (s, e) => OnTrayIconDoubleClick();
            startUpCheckBox.CheckStateChanged += (s, e) => OnStartupChecked(startUpCheckBox.Checked);
            autoBPModeCheckBox.CheckStateChanged += (s, e) => OnAutoBPModeChecked(autoBPModeCheckBox.Checked);

            showTrayContextMenu.Click += (s, e) => OnShowTrayContextMenuClick();
            exitTrayContextMenu.Click += (s, e) => OnExitTrayContextMenuClick();

            FormClosed += MainForm_FormClosed;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon.Dispose();
        }
    }
}
