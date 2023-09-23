namespace SabreTools.Models.Compression.Quantum
{
    /// <see href="http://www.russotto.net/quantumcomp.html"/>
    public sealed class ModelSymbol
    {
        public ushort Symbol { get; set; }

        public ushort CumulativeFrequency { get; set; }
    }
}