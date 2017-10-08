using Switcher.Dto;
using Switcher.Interfaces.Config;

namespace Switcher.Config
{
    public class ConfigProvider : IConfigProvider
    {
        public DeviceSettings GetDeviceSettings()
        {
            return new DeviceSettings
            {
                SteamDisplay = new Device
                {
                    Name = Properties.Settings.Default.SteamDisplayName,
                    Title = Properties.Settings.Default.SteamDisplayTitle,
                },
                SteamAudio = new Device
                {
                    Name = Properties.Settings.Default.SteamAudioName,
                    Title = Properties.Settings.Default.SteamAudioTitle,
                },
                DefaultDisplay = new Device
                {
                    Name = Properties.Settings.Default.DefaultDisplayName,
                    Title = Properties.Settings.Default.DefaultDisplayTitle,
                },
                DefaultAudio = new Device
                {
                    Name = Properties.Settings.Default.DefaultAudioName,
                    Title = Properties.Settings.Default.DefaultAudioTitle,
                },
                AutoBPMode = Properties.Settings.Default.AutoBPMode
            };
        }

        public void SaveDeviceSettings(DeviceSettings deviceSettings)
        {
            Properties.Settings.Default.SteamDisplayName = deviceSettings.SteamDisplay.Name;
            Properties.Settings.Default.SteamDisplayTitle = deviceSettings.SteamDisplay.Title;
            Properties.Settings.Default.SteamAudioName = deviceSettings.SteamAudio.Name;
            Properties.Settings.Default.SteamAudioTitle = deviceSettings.SteamAudio.Title;
            Properties.Settings.Default.DefaultDisplayName = deviceSettings.DefaultDisplay.Name;
            Properties.Settings.Default.DefaultDisplayTitle = deviceSettings.DefaultDisplay.Title;
            Properties.Settings.Default.DefaultAudioName = deviceSettings.DefaultAudio.Name;
            Properties.Settings.Default.DefaultAudioTitle = deviceSettings.DefaultAudio.Title;
            Properties.Settings.Default.AutoBPMode = deviceSettings.AutoBPMode;

            Properties.Settings.Default.Save();
        }
    }
}
