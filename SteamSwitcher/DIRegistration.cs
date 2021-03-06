﻿using Microsoft.Practices.Unity;
using Switcher;
using Switcher.Config;
using Switcher.Controllers;
using Switcher.HotKeys;
using Switcher.Interfaces;
using Switcher.Interfaces.Config;
using Switcher.Interfaces.Controllers;
using Switcher.Interfaces.HotKeys;

namespace SteamSwitcher
{
    public class DIRegistration
    {
        readonly UnityContainer _container = new UnityContainer();

        public void Register()
        {
            _container.RegisterType<IMainFormController, MainFormController>();
            _container.RegisterType<IDevicesProvider, DevicesProvider>();
            _container.RegisterType<IHardwareSwitcher, HardwareSwitcher>();
            _container.RegisterType<IConfigProvider, ConfigProvider>();
            _container.RegisterType<IAppStartupManager, AppStartupManager>();
            _container.RegisterType<ISwitchService, SwitchService>();
            _container.RegisterType<IKeyboardHook, KeyboardHook>();
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
