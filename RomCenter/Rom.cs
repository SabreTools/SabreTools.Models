namespace SabreTools.Models.RomCenter
{
    /// <remarks>¬-delimited</remarks>
    public class Rom
    {
        /// <remarks>0</remarks>
#if NET48
        public string ParentName { get; set; }
#else
        public string? ParentName { get; set; }
#endif

        /// <remarks>1</remarks>
#if NET48
        public string ParentDescription { get; set; }
#else
        public string? ParentDescription { get; set; }
#endif

        /// <remarks>2</remarks>
#if NET48
        public string GameName { get; set; }
#else
        public string? GameName { get; set; }
#endif

        /// <remarks>3</remarks>
#if NET48
        public string GameDescription { get; set; }
#else
        public string? GameDescription { get; set; }
#endif

        /// <remarks>4</remarks>
#if NET48
        public string RomName { get; set; }
#else
        public string? RomName { get; set; }
#endif

        /// <remarks>5</remarks>
#if NET48
        public string RomCRC { get; set; }
#else
        public string? RomCRC { get; set; }
#endif

        /// <remarks>6</remarks>
#if NET48
        public string RomSize { get; set; }
#else
        public string? RomSize { get; set; }
#endif

        /// <remarks>7</remarks>
#if NET48
        public string RomOf { get; set; }
#else
        public string? RomOf { get; set; }
#endif

        /// <remarks>8</remarks>
#if NET48
        public string MergeName { get; set; }
#else
        public string? MergeName { get; set; }
#endif

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
#if NET48
        public string[] ADDITIONAL_ELEMENTS { get; set; }
#else
        public string[]? ADDITIONAL_ELEMENTS { get; set; }
#endif

        #endregion
    }
}