namespace SabreTools.Models.BSP
{
    /// <summary>
    /// Each of this structures defines a plane in 3-dimensional
    /// space by using the Hesse normal form: normal * point - distance = 0
    /// </summary>
    /// <see href="https://developer.valvesoftware.com/wiki/BSP_(GoldSrc)"/> 
    public sealed class PlaneLump
    {
        /// <summary>
        /// Planes
        /// </summary>
        public Plane[]? Planes { get; set; }
    }
}