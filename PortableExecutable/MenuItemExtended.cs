﻿namespace SabreTools.Models.PortableExecutable
{
    /// <summary>
    /// Defines a menu item in an extended menu template. This structure definition is for
    /// explanation only; it is not present in any standard header file.
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/windows/win32/menurc/menuex-template-item"/>
    public sealed class MenuItemExtended
    {
        /// <summary>
        /// Describes the menu item.
        /// </summary>
        public MenuFlags ItemType { get; set; }

        /// <summary>
        /// Describes the menu item.
        /// </summary>
        public MenuFlags State { get; set; }

        /// <summary>
        /// A numeric expression that identifies the menu item that is passed in the
        /// WM_COMMAND message.
        /// </summary>
        public uint ID { get; set; }

        /// <summary>
        /// A set of bit flags that specify the type of menu item.
        /// </summary>
        public MenuFlags Flags { get; set; }

        /// <summary>
        /// A null-terminated Unicode string that contains the text for this menu item.
        /// There is no fixed limit on the size of this string.
        /// </summary>
        public string? MenuText { get; set; }
    }
}
