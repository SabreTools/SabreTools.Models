namespace SabreTools.Models.BSP
{
    /// <summary>
    /// This lump contains the so-called clipnodes, which build a second
    /// BSP tree used only for collision detection.
    /// 
    /// This structure is a reduced form of the BSPNODE struct from the
    /// nodes lump. Also the BSP tree built by the clipnodes is simpler
    /// than the one described by the BSPNODEs to accelerate collision calculations. 
    /// </summary>
    /// <see href="https://developer.valvesoftware.com/wiki/BSP_(GoldSrc)"/> 
    public sealed class ClipnodesLump : Lump
    {
        /// <summary>
        /// Clipnodes
        /// </summary>
        public Clipnode[]? Clipnodes { get; set; }
    }
}