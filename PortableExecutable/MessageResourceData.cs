using System.Collections.Generic;

namespace SabreTools.Models.PortableExecutable
{
    /// <summary>
    /// Contains information about formatted text for display as an error message or in a message
    /// box in a message table resource.
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/windows/win32/api/winnt/ns-winnt-message_resource_data"/>
    public sealed class MessageResourceData
    {
        /// <summary>
        /// The number of MESSAGE_RESOURCE_BLOCK structures.
        /// </summary>
        public uint NumberOfBlocks;

        /// <summary>
        /// An array of structures. The array is the size indicated by the NumberOfBlocks member.
        /// </summary>
#if NET48
        public MessageResourceBlock[] Blocks;
#else
        public MessageResourceBlock[]? Blocks;
#endif

        /// <summary>
        /// Message resource entries
        /// </summary>
#if NET48
        public Dictionary<uint, MessageResourceEntry> Entries;
#else
        public Dictionary<uint, MessageResourceEntry?>? Entries;
#endif
    }
}
