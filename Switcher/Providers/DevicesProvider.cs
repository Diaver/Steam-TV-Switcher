using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Switcher.Dto;
using Switcher.Interfaces;
using Switcher.Interop.Audio;
using Switcher.Interop.Display;

namespace Switcher
{
    public class DevicesProvider : IDevicesProvider
    {

        public Device GetActiveDisplay()
        {
            return GetDispayDevices().FirstOrDefault(c => c.IsPrimary);
        }

        public List<Device> GetAdudioDevices()
        {
            var devices = new List<Device>();
            devices.Add(new Device());

            AudioEndpoint[] audioEndpoints = AudioUtil.GetAudioEndpoints();
            foreach (var audioEndpoint in audioEndpoints)
            {
                devices.Add(new Device
                {
                    Title = audioEndpoint.FriendlyName,
                    Name = audioEndpoint.Description
                });
            }

            return devices;
        }

        public List<Device> GetDispayDevices()
        {
            var devices = new List<Device>();

            devices.Add(new Device());

            foreach (var screen in Screen.AllScreens)
            {
                devices.Add(new Device
                {
                    Name = screen.DeviceName,
                    Title = GetDisplayName(screen),
                    IsPrimary = screen.Primary
                    
                });
            }
            return devices;
        }

        private string GetDisplayName(Screen screen)
        {
            return string.Format("({0}x{1}) {2}", screen.Bounds.Width, screen.Bounds.Height,
                DisplayUtil.GetDeviceString(screen.DeviceName));
        }
    }
}
