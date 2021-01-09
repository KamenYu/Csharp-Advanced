using System.IO;

namespace _5.SliceFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfPieces = 4;
            using (FileStream stream = new FileStream("../../../input.txt", FileMode.Open))
            {
                string text = File.ReadAllText("../../../input.txt");
                long piecesSize = text.Length / amountOfPieces;

                for (int i = 0; i < amountOfPieces; i++)
                {
                    using (FileStream piece = new FileStream($"../../../part-{i + 1}", FileMode.Create))
                    {
                        byte[] buffer = new byte[1];

                        int count = 0;

                        while (count < piecesSize)
                        {
                            stream.Read(buffer, 0, buffer.Length);
                            piece.Write(buffer, 0, buffer.Length);
                            count += buffer.Length;
                        }
                    }
                }
            }
        }
    }
}
