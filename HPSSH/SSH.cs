using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSH
{
    internal class SSH
    {
        public string? Signature { get; set; }
        public uint FileSize { get; set; }
        public uint Files { get; set; }
        public string DirectoryId { get; set; }
    }
}
