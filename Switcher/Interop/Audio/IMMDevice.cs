using System.Runtime.InteropServices;

namespace Switcher.Interop.Audio
{
    internal enum StorageAccessMode
    {
        Read,
        Write,
        ReadWrite,
    }

    [Guid("D666063F-1587-4E43-81F1-B948E807363F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMMDevice
    {
        void ActivatePlaceHolder();

        IPropertyStore OpenPropertyStore(StorageAccessMode stgmAccess);

        [return: MarshalAs(UnmanagedType.LPWStr)]
        string GetId();
    }
}