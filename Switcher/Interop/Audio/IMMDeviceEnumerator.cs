using System;
using System.Runtime.InteropServices;

namespace Switcher.Interop.Audio
{
    public enum DataFlow
    {
        Render,
        Capture,
        All,
    }

    [Flags]
    public enum DeviceStates
    {
        Active = 1,
        Disabled = 2,
        NotPresent = 4,
        Unplugged = 8,
        All = Unplugged | NotPresent | Disabled | Active,
    }

    [ComImport, Guid("A95664D2-9614-4F35-A746-DE8DB63617E6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMMDeviceEnumerator
    {
        IMMDeviceCollection EnumAudioEndpoints(DataFlow dataFlow, DeviceStates dwStateMask);
    }
}