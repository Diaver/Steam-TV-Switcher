namespace Switcher.Interop.Display
{
    public  static class DisplayUtil
    {
        public static string GetDeviceString(string deviceName)
        {
            var deviceInfo = new DISPLAY_DEVICEW();
            NativeMethods.EnumDisplayDevices(deviceName, 0, deviceInfo, NativeMethods.EDD_GET_DEVICE_INTERFACE_NAME);
            return deviceInfo.DeviceString;
        }
    }
}
