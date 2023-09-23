namespace SabreTools.Models.Compression.Quantum
{
    /// <see href="http://www.russotto.net/quantumcomp.html"/>
    public sealed class Model
    {
        public int Entries { get; set; }

#if NET48
        public ModelSymbol[] Symbols { get; set; }
#else
        public ModelSymbol?[]? Symbols { get; set; }
#endif
    }
}