namespace Switcher.Interfaces
{
    public interface IHardwareSwitcher
    {
        void SetPrimaryDisplay(string tv);
        void SetDefaultPlaybackDevice(string deviceName);
    }
}