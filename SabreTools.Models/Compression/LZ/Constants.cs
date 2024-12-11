namespace SabreTools.Models.Compression.LZ
{
    public static class Constants
    {
        public static readonly byte[] KWAJSignatureBytes = [0x4B, 0x57, 0x41, 0x4A, 0x88, 0xF0, 0x27, 0xD1];

        public static readonly byte[] SZDDSignatureBytes = [0x53, 0x5A, 0x44, 0x44, 0x88, 0xF0, 0x27, 0x33];

        public static readonly byte[] QBasicSignatureBytes = [0x53, 0x5A, 0x20, 0x88, 0xF0, 0x27, 0x33, 0xD1];

        public const int GETLEN = 2048;

        public const int LZ_TABLE_SIZE = 0x1000;

        public const int MAX_LZSTATES = 16;

        public const int LZ_MIN_HANDLE = 0x400;
    }
}