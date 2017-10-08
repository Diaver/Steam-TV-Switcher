using Switcher.Interop.Common;

namespace Switcher.Interop.Audio
{
    public class AudioEndpoint
    {
        public string Id { get; private set; }
        public string InterfaceFriendlyName { get; private set; }
        public string Description { get; private set; }
        public string FriendlyName { get; private set; }

        public AudioEndpoint(string id, string interfaceFriendlyName, string description, string friendlyName)
        {
            Description = description;
            InterfaceFriendlyName = interfaceFriendlyName;
            FriendlyName = friendlyName;
            Id = id;
        }
    }

    public static class AudioUtil
    {

        public static AudioEndpoint[] GetAudioEndpoints()
        {
            var enumerator = (IMMDeviceEnumerator)new MMDeviceEnumerator();
            var endpoints = enumerator.EnumAudioEndpoints(DataFlow.Render, DeviceStates.Active);

            var endpointArray = new AudioEndpoint[endpoints.GetCount()];
            for (int i = 0; i < endpointArray.Length; i++)
            {
                var propertyStore = endpoints.Item(i).OpenPropertyStore(Constants.STGM_READ);
                endpointArray[i] = new AudioEndpoint(
                    endpoints.Item(i).GetId(),
                    propertyStore.GetValue(PropertyKey.PKEY_DeviceInterface_FriendlyName).pwszVal,
                    propertyStore.GetValue(PropertyKey.PKEY_Device_DeviceDesc).pwszVal,
                    propertyStore.GetValue(PropertyKey.PKEY_Device_FriendlyName).pwszVal);
            }

            return endpointArray;
        }
    }
}
