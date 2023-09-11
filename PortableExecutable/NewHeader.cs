namespace SabreTools.Models.PortableExecutable
{
    /// <summary>
    /// Contains the number of icon or cursor components in a resource group. The
    /// structure definition provided here is for explanation only; it is not present
    /// in any standard header file.
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/windows/win32/menurc/newheader"/>
    public sealed class NewHeader
    {
        /// <summary>
        /// Reserved; must be zero.
        /// </summary>
        public ushort Reserved { get; set; }

        /// <summary>
        /// The resource type. This member must have one of the following values.
        /// - RES_ICON (1): Icon resource type.
        /// - RES_CURSOR (2): Cursor resource type.
        /// </summary>
        public ushort ResType { get; set; }

        /// <summary>
        /// The number of icon or cursor components in the resource group.
        /// </summary>
        public ushort ResCount { get; set; }
    }
}
