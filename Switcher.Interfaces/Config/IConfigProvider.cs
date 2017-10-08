using Switcher.Dto;

namespace Switcher.Interfaces.Config
{
    public interface IConfigProvider
    {
        DeviceSettings GetDeviceSettings();
        void SaveDeviceSettings(DeviceSettings deviceSettings);
    }
}