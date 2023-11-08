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
        public MenuHeader? MenuHeader { get; set; }

        /// <summary>
        /// Menu extended header structure
        /// </summary>
        public MenuHeaderExtended? ExtendedMenuHeader { get; set; }

        #endregion

        #region Menu items

        /// <summary>
        /// Menu items
        /// </summary>
        public MenuItem?[]? MenuItems { get; set; }

        /// <summary>
        /// Extended menu items
        /// </summary>
        public MenuItemExtended?[]? ExtendedMenuItems { get; set; }

        #endregion
    }
}
