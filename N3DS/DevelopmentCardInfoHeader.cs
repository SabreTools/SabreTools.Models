namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/NCSD#Development_Card_Info_Header_Extension"/>
    public sealed class DevelopmentCardInfoHeader
    {
        /// <summary>
        /// InitialData
        /// </summary>
#if NET48
        public InitialData InitialData { get; set; }
#else
        public InitialData? InitialData { get; set; }
#endif

        /// <summary>
        /// CardDeviceReserved1
        /// </summary>
#if NET48
        public byte[] CardDeviceReserved1 { get; set; }
#else
        public byte[]? CardDeviceReserved1 { get; set; }
#endif

        /// <summary>
        /// TitleKey
        /// </summary>
#if NET48
        public byte[] TitleKey { get; set; }
#else
        public byte[]? TitleKey { get; set; }
#endif

        /// <summary>
        /// CardDeviceReserved2
        /// </summary>
#if NET48
        public byte[] CardDeviceReserved2 { get; set; }
#else
        public byte[]? CardDeviceReserved2 { get; set; }
#endif

        /// <summary>
        /// TestData
        /// </summary>
#if NET48
        public TestData TestData { get; set; }
#else
        public TestData? TestData { get; set; }
#endif
    }
}
