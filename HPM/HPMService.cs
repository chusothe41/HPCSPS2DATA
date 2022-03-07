using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPM
{
    internal class HPMService : IHPMService
    {
        /// <summary>
        /// Export to obj wavefront
        /// </summary>
        /// <returns></returns>
        public string ToWavefront(HPM hpm) //TODO: Hacer comprobaciones
        {
            if (hpm == null || hpm.HPMElements == null) return "";

            StringBuilder stringBuilder = new StringBuilder();
            foreach (HPMElement hpmElement in hpm.HPMElements)
            {
                stringBuilder.AppendLine("# Vertex" + hpmElement.VertexCount);
                for (int i = 0; i < hpmElement.VertexCount; i++)
                {
                    stringBuilder.AppendLine("v " + hpmElement.Vertex[i].X.ToString(CultureInfo.InvariantCulture) + " " + hpmElement.Vertex[i].Y.ToString(CultureInfo.InvariantCulture) + " " + hpmElement.Vertex[i].Z.ToString(CultureInfo.InvariantCulture));
                }
            }
            return stringBuilder.ToString();
        }
    }
}
