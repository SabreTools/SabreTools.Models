using System.Runtime.InteropServices;

namespace SabreTools.Models.BSP
{
    /// <summary>
    /// QAngle is a C++ class in Source that represents a three-dimensional
    /// extrinsic Tait-Bryan rotations following the right-hand rule, offset
    /// from the cardinal Z axis.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class QAngle
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
    }
}