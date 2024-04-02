/// <remarks>
/// Information sourced from https://docwiki.embarcadero.com/Libraries/Alexandria/en/System.PackageUnitEntry
/// </remarks>
namespace SabreTools.Models.Delphi
{
    public class PackageUnitEntry
    {
        /// <remarks>
        /// System-dependent pointer type, assumed to be encoded for x86
        /// </remarks>
        public uint Init { get; set; }

        /// <remarks>
        /// System-dependent pointer type, assumed to be encoded for x86
        /// </remarks>
        public uint FInit { get; set; }
    }
}