namespace SabreTools.Models.ClrMamePro
{
    /// <summary>
    /// Base class to unify the various game-like types
    /// </summary>
    public abstract class GameBase
    {
        /// <remarks>name</remarks>
        [Required]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <remarks>description</remarks>
#if NET48
        public string Description { get; set; }
#else
        public string? Description { get; set; }
#endif

        /// <remarks>year</remarks>
#if NET48
        public string Year { get; set; }
#else
        public string? Year { get; set; }
#endif

        /// <remarks>manufacturer</remarks>
#if NET48
        public string Manufacturer { get; set; }
#else
        public string? Manufacturer { get; set; }
#endif

        /// <remarks>category</remarks>
#if NET48
        public string Category { get; set; }
#else
        public string? Category { get; set; }
#endif

        /// <remarks>cloneof</remarks>
#if NET48
        public string CloneOf { get; set; }
#else
        public string? CloneOf { get; set; }
#endif

        /// <remarks>romof</remarks>
#if NET48
        public string RomOf { get; set; }
#else
        public string? RomOf { get; set; }
#endif

        /// <remarks>sampleof</remarks>
#if NET48
        public string SampleOf { get; set; }
#else
        public string? SampleOf { get; set; }
#endif

        /// <remarks>release</remarks>
#if NET48
        public Release[] Release { get; set; }
#else
        public Release[]? Release { get; set; }
#endif

        /// <remarks>biosset</remarks>
#if NET48
        public BiosSet[] BiosSet { get; set; }
#else
        public BiosSet[]? BiosSet { get; set; }
#endif

        /// <remarks>rom</remarks>
#if NET48
        public Rom[] Rom { get; set; }
#else
        public Rom[]? Rom { get; set; }
#endif

        /// <remarks>disk</remarks>
#if NET48
        public Disk[] Disk { get; set; }
#else
        public Disk[]? Disk { get; set; }
#endif

        /// <remarks>sample</remarks>
#if NET48
        public Sample[] Sample { get; set; }
#else
        public Sample[]? Sample { get; set; }
#endif

        /// <remarks>archive</remarks>
#if NET48
        public Archive[] Archive { get; set; }
#else
        public Archive[]? Archive { get; set; }
#endif

        #region Aaru Extensions

        /// <remarks>media, Appears after Disk</remarks>
#if NET48
        public Media[] Media { get; set; }
#else
        public Media[]? Media { get; set; }
#endif

        #endregion

        #region MAME Extensions

        /// <remarks>chip, Appears after Archive</remarks>
#if NET48
        public Chip[] Chip { get; set; }
#else
        public Chip[]? Chip { get; set; }
#endif

        /// <remarks>video, Appears after Chip</remarks>
#if NET48
        public Video[] Video { get; set; }
#else
        public Video[]? Video { get; set; }
#endif

        /// <remarks>sound, Appears after Video</remarks>
#if NET48
        public Sound Sound { get; set; }
#else
        public Sound? Sound { get; set; }
#endif

        /// <remarks>input, Appears after Sound</remarks>
#if NET48
        public Input Input { get; set; }
#else
        public Input? Input { get; set; }
#endif

        /// <remarks>dipswitch, Appears after Input</remarks>
#if NET48
        public DipSwitch[] DipSwitch { get; set; }
#else
        public DipSwitch[]? DipSwitch { get; set; }
#endif

        /// <remarks>driver, Appears after DipSwitch</remarks>
#if NET48
        public Driver Driver { get; set; }
#else
        public Driver? Driver { get; set; }
#endif

        #endregion

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