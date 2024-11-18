namespace SabreTools.Models.BSP
{
    /// <summary>
    /// The face lump contains the surfaces of the scene.
    /// 
    /// The first number of this data structure is an index into
    /// the planes lump giving a plane which is parallel to this
    /// face (meaning they share the same normal). The second
    /// value may be seen as a boolean. If nPlaneSide equals 0,
    /// then the normal vector of this face equals the one of the
    /// parallel plane exactly. Otherwise, the normal of the plane
    /// has to be multiplied by -1 to point into the right direction.
    /// Afterwards we have an index into the surfedges lump, as
    /// well as the count of consecutive surfedges from that position.
    /// Furthermore there is an index into the texture info lump,
    /// which is used to find the BSPTEXINFO structure needed to
    /// calculate the texture coordinates for this face. Afterwards,
    /// there are four bytes giving some lighting information (partly
    /// used by the renderer to hide sky surfaces). Finally we have
    /// an offset in byes giving the beginning of the binary lightmap
    /// data of this face in the lighting lump.
    /// </summary>
    /// <see href="https://developer.valvesoftware.com/wiki/BSP_(GoldSrc)"/> 
    public sealed class FacesLump : Lump
    {
        /// <summary>
        /// Faces
        /// </summary>
        public Face[]? Faces { get; set; }
    }
}