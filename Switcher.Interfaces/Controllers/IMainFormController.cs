using Switcher.Interfaces.Views;

namespace Switcher.Interfaces.Controllers
{
    public interface IMainFormController
    {
        void Run(IMainForm mainForm,  bool isMinimazed);
    }
}