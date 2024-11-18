using System.Runtime.InteropServices;

namespace SabreTools.Models.BSP
{
    /// <summary>
    /// The lighting data for each sample is represented by an array
    /// of 6 ColorRGBExp32
    /// </summary>
    /// <see href="https://developer.valvesoftware.com/wiki/BSP_(Source)"/> 
    [StructLayout(LayoutKind.Sequential)]
    public struct CompressedLightCube
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ColorRGBExp32[]? Colors;
    }
}