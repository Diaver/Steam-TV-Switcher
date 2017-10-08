using System.Runtime.InteropServices;

namespace Switcher.Interop.Common
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PropertyVariantCommon
    {
        public ushort vt;
        public ushort wReserved1;
        public ushort wReserved2;
        public ushort wReserved3;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PropertyVariantString
    {
        public PropertyVariantCommon propertyVariantCommon;
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszVal;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PropertyVariantInt
    {
        public PropertyVariantCommon propertyVariantCommon;
        public int lVal;
    }
}
