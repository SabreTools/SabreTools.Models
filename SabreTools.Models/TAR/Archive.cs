using System.Collections.Generic;

namespace SabreTools.Models.TAR
{
    public sealed class Archive
    {
        /// <summary>
        /// 1 or more entries
        /// </summary>
        public List<Entry>? Entries { get; set; }
    }
}