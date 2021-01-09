using System.IO;

namespace _10.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // the output file canot be read on my machine
            using (FileStream reader = new FileStream("../../../copyMe.png", FileMode.Open))
            {
                using (FileStream writer = new FileStream("../../../copy.png", FileMode.Create))
                {
                    byte[] buffer = new byte[4096];

                    while (reader.CanRead)
                    {
                        int bytesRead = reader.Read(buffer, 0, buffer.Length);
                        if (bytesRead == 0)
                        {
                            break;
                        }
                    }
                    writer.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
