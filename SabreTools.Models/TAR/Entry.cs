using System.Collections.Generic;

namespace SabreTools.Models.TAR
{
    public sealed class Entry
    {
        /// <summary>
        /// Entry header
        /// </summary>
        public Header? Header { get; set; }

        /// <summary>
        /// 0 or more blocks representing the content
        /// </summary>
        public List<Block>? Blocks { get; set; }
    }
}