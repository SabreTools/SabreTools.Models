namespace SabreTools.Models.Compression.Quantum
{
    /// <see href="https://github.com/wine-mirror/wine/blob/master/dlls/cabinet/cabinet.h"/>
    /// <see href="http://www.russotto.net/quantumcomp.html"/>
    public sealed class Model
    {
        public int TimeToReorder;

        public int Entries;

#if NET48
        public ModelSymbol[] Symbols;
#else
        public ModelSymbol?[]? Symbols;
#endif

#if NET48
        public ushort[] LookupTable = new ushort[256];
#else
        public ushort[]? LookupTable = new ushort[256];
#endif
    }
}