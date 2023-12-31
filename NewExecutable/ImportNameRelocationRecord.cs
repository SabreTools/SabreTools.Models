﻿namespace SabreTools.Models.NewExecutable
{
    /// <see href="http://bytepointer.com/resources/win16_ne_exe_format_win3.0.htm"/>
    public sealed class ImportNameRelocationRecord
    {
        /// <summary>
        /// Index into module reference table for the imported module.
        /// </summary>
        public ushort Index { get; set; }

        /// <summary>
        /// Offset within Imported Names Table to procedure name string.
        /// </summary>
        public ushort Offset { get; set; }
    }
}
