namespace SabreTools.Models.BSP
{
    /// <summary>
    /// The edges delimit the face and further refer to the vertices of the
    /// face. Each edge is pointing to the start and end vertex of the edge. 
    /// </summary>
    /// <see href="https://developer.valvesoftware.com/wiki/BSP_(GoldSrc)"/> 
    public sealed class EdgesLump : Lump
    {
        /// <summary>
        /// Edge
        /// </summary>
        public Edge[]? Edges { get; set; }
    }
}