using System.Runtime.InteropServices;

namespace Switcher.Interop.Audio
{
    internal enum ERole
    {
        eConsole,
        eMultimedia,
        eCommunications,
        ERole_enum_count
    }

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("568b9108-44bf-40b4-9006-86afe5b5a620")]
    internal interface IPolicyConfigVista
    {
        void PlaceHolder1();
        void PlaceHolder2();
        void PlaceHolder3();
        void PlaceHolder4();
        void PlaceHolder5();
        void PlaceHolder6();
        void PlaceHolder7();
        void PlaceHolder8();
        void PlaceHolder9();
        void SetDefaultEndpoint(string wszDeviceId, ERole eRole);
    };
}
