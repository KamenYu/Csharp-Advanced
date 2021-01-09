using System;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a text file and writes its every odd line in another file. Line numbers starts from 0. 
            // {"-", ",", ".", "!", "?"} with "@"
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    string currentLine = reader.ReadLine();
                    int counter = 0;
                    while (currentLine != null)
                    {
                        if (counter % 2 != 0)
                        {
                            writer.WriteLine(currentLine);
                        }
                        counter++;
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
