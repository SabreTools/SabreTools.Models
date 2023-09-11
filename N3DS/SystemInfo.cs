namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/NCCH/Extended_Header#System_Info"/>
    public sealed class SystemInfo
    {
        /// <summary>
        /// SaveData Size
        /// </summary>
        public ulong SaveDataSize { get; set; }

        /// <summary>
        /// Jump ID
        /// </summary>
        public ulong JumpID { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved { get; set; }
#else
        public byte[]? Reserved { get; set; }
#endif
    }
}
