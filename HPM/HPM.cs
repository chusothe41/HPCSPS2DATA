using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HPM
{
    internal class HPM
    {
        public string? Signature { get; set; }
        public ushort HUnknown1 { get; set; }
        public ushort HUnknown2 { get; set; }
        public ushort HUnknown3 { get; set; }
        public ushort ElementsCount { get; set; }
        public uint HUnknown4 { get; set; }
        public ushort HUnknown5 { get; set; }
        public ushort HUnknown6 { get; set; }
        public uint HUnknown7 { get; set; }
        public List<HPMElement> HPMElements { get; set; }

        public HPM()
        {
            HPMElements = new List<HPMElement>();
        }

    }
}
