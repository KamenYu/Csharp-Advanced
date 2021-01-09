using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                string currentLine = reader.ReadLine();
                int counter = 0;
                while (currentLine != null)
                {                       
                       
                    if (counter % 2 == 0)
                    {
                        currentLine = Regex.Replace(currentLine, @"[-,.?!]", "@");
                        var array = currentLine.Split().ToArray().Reverse();
                        Console.WriteLine(string.Join(' ', array));
                    }
                    counter++;
                    currentLine = reader.ReadLine();
                }               
            }
        }
    }
}
