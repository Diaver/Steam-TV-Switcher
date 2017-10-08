using System.Runtime.InteropServices;

namespace Switcher.Interop.Audio
{
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("0BD7A1BE-7A1A-44DB-8397-CC5392387B5E")]
// ReSharper disable InconsistentNaming
    internal interface IMMDeviceCollection
// ReSharper restore InconsistentNaming
    {
        int GetCount();

        IMMDevice Item(int deviceNumber);
    }
}