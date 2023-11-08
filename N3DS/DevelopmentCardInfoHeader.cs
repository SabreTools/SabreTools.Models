namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/NCSD#Development_Card_Info_Header_Extension"/>
    public sealed class DevelopmentCardInfoHeader
    {
        /// <summary>
        /// InitialData
        /// </summary>
        public InitialData? InitialData { get; set; }

        /// <summary>
        /// CardDeviceReserved1
        /// </summary>
        public byte[]? CardDeviceReserved1 { get; set; }

        /// <summary>
        /// TitleKey
        /// </summary>
        public byte[]? TitleKey { get; set; }

        /// <summary>
        /// CardDeviceReserved2
        /// </summary>
        public byte[]? CardDeviceReserved2 { get; set; }

        /// <summary>
        /// TestData
        /// </summary>
        public TestData? TestData { get; set; }
    }
}
