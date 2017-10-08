using System;
using System.Runtime.InteropServices;
using Switcher.Interop.Common;

namespace Switcher.Interop.Audio
{
    [Guid("886d8eeb-8cf2-4446-8d02-cdba1dbdcf99"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IPropertyStore
    {
        void GetCountPlaceHolder();

        void GetAtPlaceHolder();

        PropertyVariantString GetValue(PropertyKey key);
    }

    [StructLayout(LayoutKind.Sequential)]
    public class PropertyKey
    {
        public static readonly PropertyKey PKEY_DeviceInterface_FriendlyName = new PropertyKey(new Guid(0x026e516e, 0xb814, 0x414b, 0x83, 0xcd, 0x85, 0x6d, 0x6f, 0xef, 0x48, 0x22), 2);
        public static readonly PropertyKey PKEY_Device_DeviceDesc = new PropertyKey(new Guid(0xa45c254e, 0xdf1c, 0x4efd, 0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0), 2);
        public static readonly PropertyKey PKEY_Device_FriendlyName = new PropertyKey(new Guid(0xa45c254e, 0xdf1c, 0x4efd, 0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0), 14);

        public Guid formatId;
        public uint propertyId;

        public PropertyKey(Guid formatId, uint propertyId)
        {
            this.formatId = formatId;
            this.propertyId = propertyId;
        }
    }
}
