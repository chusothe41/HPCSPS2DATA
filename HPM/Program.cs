using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace HPM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The program starts");
            IHPMService hpmService = new HPMService();
            string testFile = "";

            try
            {
                HPM hpm = new HPM();

                using (BinaryReader reader = new BinaryReader(File.Open(testFile, FileMode.Open)))
                {
                    #region Header
                    hpm.Signature = System.Text.Encoding.ASCII.GetString(reader.ReadBytes(4));
                    hpm.HUnknown1 = reader.ReadUInt16();
                    hpm.HUnknown2 = reader.ReadUInt16(); // #of nodes?
                    hpm.HUnknown3 = reader.ReadUInt16();
                    hpm.ElementsCount = reader.ReadUInt16();
                    hpm.HUnknown4 = reader.ReadUInt32();
                    hpm.HUnknown5 = reader.ReadUInt16();
                    hpm.HUnknown6 = reader.ReadUInt16();
                    hpm.HUnknown7 = reader.ReadUInt32();
                    #endregion

                    #region Element
                    try
                    {
                        while (true)
                        {
                            if (reader.ReadByte() == 1 && reader.ReadByte() == 128)
                            {
                                HPMElement hpmElement = new HPMElement();
                                hpmElement.VertexCount = reader.ReadByte();
                                if (reader.ReadByte() == 104)
                                {
                                    Vector3[]? vertexArr = new Vector3[hpmElement.VertexCount];
                                    for (int i = 0; i < hpmElement.VertexCount; i++)
                                    {
                                        vertexArr[i].X = reader.ReadSingle();
                                        vertexArr[i].Y = reader.ReadSingle();
                                        vertexArr[i].Z = reader.ReadSingle();
                                    }
                                    hpmElement.Vertex = vertexArr;
                                    hpm.HPMElements.Add(hpmElement);
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        var a = hpmService.ToWavefront(hpm);
                    }
                    #endregion
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}