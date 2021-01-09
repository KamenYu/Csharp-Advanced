using System;
using System.IO;

namespace _4.MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputOne = File.ReadAllText("../../../inputOne.txt").Split();
            string[] inputTwo = File.ReadAllText("../../../inputTwo.txt").Split();
            File.WriteAllText("../../../result.txt", "");
            for (int i = 0; i < inputOne.Length; i++)
            {
                File.AppendAllText("../../../result.txt", inputOne[i] + Environment.NewLine + inputTwo[i] + Environment.NewLine);
            }
        }
    }
}
