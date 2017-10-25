using System;
using Switcher.HotKeys;
using System.Windows.Forms;
using Switcher.Dto;

namespace Switcher.Interfaces.HotKeys
{
    public interface IKeyboardHook
    {
        /// <summary>
        /// Registers a hot key in the system.
        /// </summary>
        /// <param name="modifier">The modifiers that are associated with the hot key.</param>
        /// <param name="key">The key itself that is associated with the hot key.</param>
        bool RegisterHotKey(ModifierKeys modifier, Keys key);

        /// <summary>
        /// A hot key has been pressed.
        /// </summary>
        event Action<KeyPressedEventArgs> KeyPressed;
    }
}