using System.Collections.Generic;
using Switcher.Dto;

namespace Switcher.Interfaces
{
    public interface IDevicesProvider
    {
        Device GetActiveDisplay();
        List<Device> GetAdudioDevices();
        List<Device> GetDispayDevices();
    }
}