namespace Switcher.Dto
{
    public class DeviceSettings
    {
        public Device SteamDisplay { get; set; }
        public Device SteamAudio { get; set; }
        public Device DefaultDisplay { get; set; }
        public Device DefaultAudio { get; set; }
        public bool AutoBPMode { get; set; }

        public bool IsEmpty()
        {
            return 
                   DefaultDisplay == null
                   || DefaultAudio == null
                   || SteamDisplay == null
                   || SteamAudio == null

                   || DefaultDisplay.IsEmpty()
                   || DefaultAudio.IsEmpty()
                   || SteamDisplay.IsEmpty()
                   || SteamAudio.IsEmpty();
        }


    }
}
