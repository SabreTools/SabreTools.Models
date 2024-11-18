namespace SabreTools.Models.BSP
{
    /// <summary>
    /// This lump is simple again and contains an array of binary
    /// structures, the nodes, which are a major part of the BSP tree.
    /// 
    /// Every BSPNODE structure represents a node in the BSP tree and
    /// every node equals more or less a division step of the BSP algorithm.
    /// Therefore, each node has an index (iPlane) referring to a plane
    /// in the plane lump which devides the node into its two child nodes.
    /// The childnodes are also stored as indexes. Contrary to the plane
    /// index, the node index for the child is signed. If the index is
    /// larger than 0, the index indicates a child node. If it is equal
    /// to or smaller than zero (no valid array index), the bitwise
    /// inversed value of the index gives an index into the leaves lump.
    /// Additionally two points (nMins, nMaxs) span the bounding box
    /// (AABB, axis aligned bounding box) delimitting the space of the node.
    /// Finally firstFace indexes into the face lump and spezifies the
    /// first of nFaces surfaces contained in this node.
    /// </summary>
    /// <see href="https://developer.valvesoftware.com/wiki/BSP_(GoldSrc)"/> 
    public sealed class NodesLump : Lump
    {
        /// <summary>
        /// Nodes
        /// </summary>
        public Node[]? Nodes { get; set; }
    }
}