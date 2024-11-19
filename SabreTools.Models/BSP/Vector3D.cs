using System.Runtime.InteropServices;

namespace SabreTools.Models.BSP
{
    /// <summary>
    /// There is a common struct used to represent a point in
    /// 3-dimensional space which is used throughout the file
    /// spec and the code of the hlbsp project.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector3D
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
    }
}