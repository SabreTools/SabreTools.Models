namespace SabreTools.Models.PortableExecutable
{
    /// <summary>
    /// A menu resource consists of a MENUHEADER structure followed by one or more
    /// NORMALMENUITEM or POPUPMENUITEM structures, one for each menu item in the menu
    /// template. The MENUEX_TEMPLATE_HEADER and the MENUEX_TEMPLATE_ITEM structures
    /// describe the format of extended menu resources.
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/windows/win32/menurc/resource-file-formats"/>
    public sealed class MenuResource
    {
        #region Menu header

        /// <summary>
        /// Menu header structure
        /// </summary>
#if NET48
        public MenuHeader MenuHeader;
#else
        public MenuHeader? MenuHeader;
#endif

        /// <summary>
        /// Menu extended header structure
        /// </summary>
#if NET48
        public MenuHeaderExtended ExtendedMenuHeader;
#else
        public MenuHeaderExtended? ExtendedMenuHeader;
#endif

        #endregion

        #region Menu items

        /// <summary>
        /// Menu items
        /// </summary>
#if NET48
        public MenuItem[] MenuItems;
#else
        public MenuItem?[]? MenuItems;
#endif

        /// <summary>
        /// Extended menu items
        /// </summary>
#if NET48
        public MenuItemExtended[] ExtendedMenuItems;
#else
        public MenuItemExtended?[]? ExtendedMenuItems;
#endif

        #endregion
    }
}
