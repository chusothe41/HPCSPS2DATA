using System;
using System.Collections.Generic;
using System.Linq;

namespace SSH
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("El programa comienza");
            try
            {
                SSH sSH = new SSH();

                using (BinaryReader reader = new BinaryReader(File.Open("C:/Users/jesus/Desktop/HPAssets/OUTPUT/at_gen_hands_male_asian.ssh", FileMode.Open)))
                {
                    sSH.Signature = System.Text.Encoding.ASCII.GetString(reader.ReadBytes(4));
                    sSH.FileSize = BitConverter.ToUInt32(reader.ReadBytes(4));
                    sSH.Files = BitConverter.ToUInt32(reader.ReadBytes(4));
                    sSH.DirectoryId = System.Text.Encoding.ASCII.GetString(reader.ReadBytes(4));
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