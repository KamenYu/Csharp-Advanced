using System.IO;
using System;

namespace _2.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    string currentLine = reader.ReadLine();
                    int counter = 0;
                    while (currentLine != null)
                    {
                        writer.WriteLine($"{++counter}. {currentLine}");                        
                        currentLine = reader.ReadLine();
                    }
                }
            }

            using (StreamReader outputReader = new StreamReader("../../../output.txt"))
            {
                Console.WriteLine(outputReader.ReadToEnd());
            }
        }
    }
}
