namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/NCSD#Development_Card_Info_Header_Extension"/>
    public sealed class DevelopmentCardInfoHeader
    {
        /// <summary>
        /// InitialData
        /// </summary>
#if NET48
        public InitialData InitialData;
#else
        public InitialData? InitialData;
#endif

        /// <summary>
        /// CardDeviceReserved1
        /// </summary>
#if NET48
        public byte[] CardDeviceReserved1;
#else
        public byte[]? CardDeviceReserved1;
#endif

        /// <summary>
        /// TitleKey
        /// </summary>
#if NET48
        public byte[] TitleKey;
#else
        public byte[]? TitleKey;
#endif

        /// <summary>
        /// CardDeviceReserved2
        /// </summary>
#if NET48
        public byte[] CardDeviceReserved2;
#else
        public byte[]? CardDeviceReserved2;
#endif

        /// <summary>
        /// TestData
        /// </summary>
#if NET48
        public TestData TestData;
#else
        public TestData? TestData;
#endif
    }
}
