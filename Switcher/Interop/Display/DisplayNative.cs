using System.Runtime.InteropServices;

namespace Switcher.Interop.Display
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [BestFitMapping(false, ThrowOnUnmappableChar = true)]
    public class DISPLAY_DEVICEW
    {
        internal uint cb = (uint)Marshal.SizeOf(typeof(DISPLAY_DEVICEW));
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceString;
        public uint StateFlags;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceKey;
    }

    public static class NativeMethods
    {
        public const uint EDD_GET_DEVICE_INTERFACE_NAME = 0x00000001;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplayDevices(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDevice,
            uint iDevNum,
            [In, Out] DISPLAY_DEVICEW lpDisplayDevice,
            uint dwFlags);
    }
}
