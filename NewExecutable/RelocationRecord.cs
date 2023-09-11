using System.Runtime.InteropServices;

namespace SabreTools.Models.NewExecutable
{
    /// <summary>
    /// A table of relocation records follows. The following is the format
    /// of each relocation record.
    /// </summary>
    /// <see href="http://bytepointer.com/resources/win16_ne_exe_format_win3.0.htm"/>
    [StructLayout(LayoutKind.Sequential)]
    public sealed class RelocationRecord
    {
        /// <summary>
        /// Source type.
        /// </summary>
        public RelocationRecordSourceType SourceType { get; set; }

        /// <summary>
        /// Flags byte.
        /// 
        /// The target value has four types that are defined in the flag
        /// byte field.
        /// </summary>
        public RelocationRecordFlag Flags { get; set; }

        /// <summary>
        /// Offset within this segment of the source chain.
        /// If the ADDITIVE flag is set, then target value is added to
        /// the source contents, instead of replacing the source and
        /// following the chain. The source chain is an 0FFFFh
        /// terminated linked list within this segment of all
        /// references to the target.
        /// </summary>
        public ushort Offset { get; set; }

        /// <summary>
        /// INTERNALREF
        /// </summary>
        /// <remarks>Must be <c>NULL</c> if <see cref="Flags"/> is not set to <see cref="RelocationRecordFlag.INTERNALREF"/></remarks>
#if NET48
        public InternalRefRelocationRecord InternalRefRelocationRecord { get; set; }
#else
        public InternalRefRelocationRecord? InternalRefRelocationRecord { get; set; }
#endif

        /// <summary>
        /// IMPORTNAME
        /// </summary>
        /// <remarks>Must be <c>NULL</c> if <see cref="Flags"/> is not set to <see cref="RelocationRecordFlag.IMPORTNAME"/></remarks>
#if NET48
        public ImportNameRelocationRecord ImportNameRelocationRecord { get; set; }
#else
        public ImportNameRelocationRecord? ImportNameRelocationRecord { get; set; }
#endif

        /// <summary>
        /// IMPORTORDINAL
        /// </summary>
        /// <remarks>Must be <c>NULL</c> if <see cref="Flags"/> is not set to <see cref="RelocationRecordFlag.IMPORTORDINAL"/></remarks>
#if NET48
        public ImportOrdinalRelocationRecord ImportOrdinalRelocationRecord { get; set; }
#else
        public ImportOrdinalRelocationRecord? ImportOrdinalRelocationRecord { get; set; }
#endif

        /// <summary>
        /// IMPORTORDINAL
        /// </summary>
        /// <remarks>Must be <c>NULL</c> if <see cref="Flags"/> is not set to <see cref="RelocationRecordFlag.OSFIXUP"/></remarks>
#if NET48
        public OSFixupRelocationRecord OSFixupRelocationRecord { get; set; }
#else
        public OSFixupRelocationRecord? OSFixupRelocationRecord { get; set; }
#endif
    }
}
