namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/NCCH/Extended_Header#ARM9_Access_Control"/>
    public sealed class ARM9AccessControl
    {
        /// <summary>
        /// Descriptors
        /// </summary>
#if NET48
        public byte[] Descriptors { get; set; }
#else
        public byte[]? Descriptors { get; set; }
#endif

        /// <summary>
        /// ARM9 Descriptor Version. Originally this value had to be ≥ 2.
        /// Starting with 9.3.0-X this value has to be either value 2 or value 3.
        /// </summary>
        public byte DescriptorVersion { get; set; }
    }
}
