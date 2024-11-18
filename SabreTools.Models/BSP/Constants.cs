namespace SabreTools.Models.BSP
{
    /// <see href="https://developer.valvesoftware.com/wiki/BSP_(GoldSrc)"/> 
    public static class Constants
    {
        #region Header

        /// <summary>
        /// Number of lumps in a BSP
        /// </summary>
        public const int HEADER_LUMPS = 15;

        #endregion

        #region Lump

        public const int MAX_MAP_HULLS = 4;

        public const int MAX_MAP_MODELS = 400;
        public const int MAX_MAP_BRUSHES = 4096;
        public const int MAX_MAP_ENTITIES = 1024;
        public const int MAX_MAP_ENTSTRING = (128 * 1024);

        public const int MAX_MAP_PLANES = 32767;
        public const int MAX_MAP_NODES = 32767;
        public const int MAX_MAP_CLIPNODES = 32767;
        public const int MAX_MAP_LEAFS = 8192;
        public const int MAX_MAP_VERTS = 65535;
        public const int MAX_MAP_FACES = 65535;
        public const int MAX_MAP_MARKSURFACES = 65535;
        public const int MAX_MAP_TEXINFO = 8192;
        public const int MAX_MAP_EDGES = 256000;
        public const int MAX_MAP_SURFEDGES = 512000;
        public const int MAX_MAP_TEXTURES = 512;
        public const int MAX_MAP_MIPTEX = 0x200000;
        public const int MAX_MAP_LIGHTING = 0x200000;
        public const int MAX_MAP_VISIBILITY = 0x200000;

        public const int MAX_MAP_PORTALS = 65536;

        #endregion
    
        #region Entities

        public const int MAX_KEY = 32;

        public const int MAX_VALUE = 1024;

        #endregion

        #region Textures

        public const int MAXTEXTURENAME = 16;

        public const int MIPLEVELS = 4;

        #endregion
    }
}