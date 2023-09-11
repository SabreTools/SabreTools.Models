namespace SabreTools.Models.Compression.Quantum
{
    /// <see href="https://github.com/wine-mirror/wine/blob/master/dlls/cabinet/cabinet.h"/>
    /// <see href="http://www.russotto.net/quantumcomp.html"/>
    public sealed class Model
    {
        public int TimeToReorder { get; set; }

        public int Entries { get; set; }

#if NET48
        public ModelSymbol[] Symbols { get; set; }
#else
        public ModelSymbol?[]? Symbols { get; set; }
#endif

#if NET48
        public ushort[] LookupTable { get; set; } = new ushort[256];
#else
        public ushort[]? LookupTable { get; set; } = new ushort[256];
#endif
    }
}