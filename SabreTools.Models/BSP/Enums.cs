using System;

namespace SabreTools.Models.BSP
{
    /// <see href="https://developer.valvesoftware.com/wiki/BSP_(GoldSrc)"/> 
    public enum Contents : int
    {
        CONTENTS_EMPTY = -1,
        CONTENTS_SOLID = -2,
        CONTENTS_WATER = -3,
        CONTENTS_SLIME = -4,
        CONTENTS_LAVA = -5,
        CONTENTS_SKY = -6,
        CONTENTS_ORIGIN = -7,
        CONTENTS_CLIP = -8,
        CONTENTS_CURRENT_0 = -9,
        CONTENTS_CURRENT_90 = -10,
        CONTENTS_CURRENT_180 = -11,
        CONTENTS_CURRENT_270 = -12,
        CONTENTS_CURRENT_UP = -13,
        CONTENTS_CURRENT_DOWN = -14,
        CONTENTS_TRANSLUCENT = -15,
    }

    /// <see href="https://developer.valvesoftware.com/wiki/BSP_(GoldSrc)"/> 
    public enum LumpType : int
    {
        /// <summary>
        /// The entity lump is basically a pure ASCII text section.
        /// It consists of the string representations of all entities,
        /// which are copied directly from the input file to the output
        /// BSP file by the compiler.
        /// </summary>
        LUMP_ENTITIES = 0,

        /// <summary>
        /// This lump is a simple array of binary data structures.
        /// Each of this structures defines a plane in 3-dimensional
        /// space by using the Hesse normal form
        /// </summary>
        LUMP_PLANES = 1,

        /// <summary>
        /// The texture lump is somehow a bit more complex then the
        /// other lumps, because it is possible to save textures
        /// directly within the BSP file instead of storing them in
        /// external WAD files. 
        /// </summary>
        LUMP_TEXTURES = 2,

        /// <summary>
        /// This lump simply consists of all vertices of the BSP tree.
        /// They are stored as a primitve array of triples of floats. 
        /// </summary>
        LUMP_VERTICES = 3,

        /// <summary>
        /// The VIS lump contains data, which is irrelevant to the actual
        /// BSP tree, but offers a way to boost up the speed of the
        /// renderer significantly. Especially complex maps profit from
        /// the use if this data. This lump contains the so-called
        /// Potentially Visible Sets (PVS) (also called VIS lists) in the
        /// same amout of leaves of the tree, the user can enter (often
        /// referred to as VisLeaves). The visiblilty lists are stored as
        /// sequences of bitfields, which are run-length encoded. 
        /// </summary>
        LUMP_VISIBILITY = 4,

        /// <summary>
        /// This lump is simple again and contains an array of binary
        /// structures, the nodes, which are a major part of the BSP tree. 
        /// </summary>
        LUMP_NODES = 5,

        /// <summary>
        /// The texinfo lump contains informations about how textures are
        /// applied to surfaces. The lump itself is an array of binary data
        /// structures. 
        /// </summary>
        LUMP_TEXINFO = 6,

        /// <summary>
        /// The face lump contains the surfaces of the scene.
        /// </summary>
        LUMP_FACES = 7,

        /// <summary>
        /// This is one of the largest lumps in the BSP file. The lightmap
        /// lump stores all lightmaps used in the entire map. The lightmaps
        /// are arrays of triples of bytes (3 channel color, RGB) and stored
        /// continuously. 
        /// </summary>
        LUMP_LIGHTING = 8,

        /// <summary>
        /// This lump contains the so-called clipnodes, which build a second
        /// BSP tree used only for collision detection. 
        /// </summary>
        LUMP_CLIPNODES = 9,

        /// <summary>
        /// The leaves lump contains the leaves of the BSP tree.
        /// </summary>
        LUMP_LEAVES = 10,

        /// <summary>
        /// The marksurfaces lump is a simple array of short integers.
        /// </summary>
        LUMP_MARKSURFACES = 11,

        /// <summary>
        /// The edges delimit the face and further refer to the vertices of the
        /// face. Each edge is pointing to the start and end vertex of the edge. 
        /// </summary>
        LUMP_EDGES = 12,

        /// <summary>
        /// This lump represents pretty much the same mechanism as the marksurfaces.
        /// A face can insert its surfedge indexes into this array to get the
        /// corresponding edges delimitting the face and further pointing to the
        /// vertexes, which are required for rendering. The index can be positive
        /// or negative. If the value of the surfedge is positive, the first vertex
        /// of the edge is used as vertex for rendering the face, otherwise, the
        /// value is multiplied by -1 and the second vertex of the indexed edge is
        /// used. 
        /// </summary>
        LUMP_SURFEDGES = 13,

        /// <summary>
        /// A model is kind of a mini BSP tree. Its size is determinded by the
        /// bounding box spaned by the first to members of this struct.
        /// </summary>
        LUMP_MODELS = 14,
    }

    /// <see href="https://developer.valvesoftware.com/wiki/BSP_(GoldSrc)"/> 
    public enum PlaneType : int
    {
        // Plane is perpendicular to given axis
        PLANE_X = 0,
        PLANE_Y = 1,
        PLANE_Z = 2,

        // Non-axial plane is snapped to the nearest
        PLANE_ANYX = 3,
        PLANE_ANYY = 4,
        PLANE_ANYZ = 5,
    }

    /// <see href="https://developer.valvesoftware.com/wiki/BSP_(GoldSrc)"/> 
    [Flags]
    public enum TextureFlag : uint
    {
        /// <summary>
        /// Disable lightmaps and subdivision for the surface
        /// </summary>
        /// <remarks>Used by sky and liquids</remarks>
        DisableLightmaps = 0x01,
    }
}