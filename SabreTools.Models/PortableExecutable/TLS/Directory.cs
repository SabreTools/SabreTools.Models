﻿namespace SabreTools.Models.PortableExecutable.TLS
{
    /// <see href="https://learn.microsoft.com/en-us/windows/win32/debug/pe-format"/>
    public sealed class Directory
    {
        /// <summary>
        /// The starting address of the TLS template. The template is a block of data
        /// that is used to initialize TLS data. The system copies all of this data
        /// each time a thread is created, so it must not be corrupted. Note that this
        /// address is not an RVA; it is an address for which there should be a base
        /// relocation in the .reloc section.
        /// </summary>
        /// <remarks>This value is 32-bit if PE32 and 64-bit if PE32+</remarks>
        public ulong RawDataStartVA { get; set; }

        /// <summary>
        /// The address of the last byte of the TLS, except for the zero fill. As
        /// with the Raw Data Start VA field, this is a VA, not an RVA.
        /// </summary>
        /// <remarks>This value is 32-bit if PE32 and 64-bit if PE32+</remarks>
        public ulong RawDataEndVA { get; set; }

        /// <summary>
        /// The location to receive the TLS index, which the loader assigns. This
        /// location is in an ordinary data section, so it can be given a symbolic
        /// name that is accessible to the program.
        /// </summary>
        /// <remarks>This value is 32-bit if PE32 and 64-bit if PE32+</remarks>
        public ulong AddressOfIndex { get; set; }

        /// <summary>
        /// The pointer to an array of TLS callback functions. The array is
        /// null-terminated, so if no callback function is supported, this field
        /// points to 4 bytes set to zero.
        /// </summary>
        /// <remarks>This value is 32-bit if PE32 and 64-bit if PE32+</remarks>
        public ulong AddressOfCallbacks { get; set; }

        /// <summary>
        /// The size in bytes of the template, beyond the initialized data delimited
        /// by the Raw Data Start VA and Raw Data End VA fields. The total template
        /// size should be the same as the total size of TLS data in the image file.
        /// The zero fill is the amount of data that comes after the initialized
        /// nonzero data.
        /// </summary>
        public uint SizeOfZeroFill { get; set; }

        /// <summary>
        /// The four bits [23:20] describe alignment info. Possible values are those
        /// defined as IMAGE_SCN_ALIGN_*, which are also used to describe alignment
        /// of section in object files. The other 28 bits are reserved for future use.
        /// </summary>
        public uint Characteristics { get; set; }
    }
}
