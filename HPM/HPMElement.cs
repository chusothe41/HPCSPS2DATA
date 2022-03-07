using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HPM
{
    internal class HPMElement
    {
        public ushort EUnknown1 { get; set; }
        public uint VertexCount { get; set; }
        public byte EUnknown2 { get; set; }
        public Vector3[]? Vertex { get; set; }
        public uint EUnknown3 { get; set; }
        public uint EUnknown4 { get; set; }
    }
}
