namespace Switcher.Interfaces
{
    public interface IAppStartupManager
    {
        void Startup(bool isEnable);

        bool IsStartupEnabled();
    }
}