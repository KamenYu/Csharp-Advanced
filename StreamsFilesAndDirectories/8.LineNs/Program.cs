using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _8.LineNs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("../../../input.txt");
            string[] output = new string[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                MatchCollection matches = Regex.Matches(text[i], "[-.,?!']");
                string[] splitted = text[i].Split(new[] { ' ', ',', '.', '?', '-', '!', '\'', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
                int sum = 0;
                for (int j = 0; j < splitted.Length; j++)
                {
                    sum += splitted[j].Length;
                }

                output[i] = $"Line {i + 1}: {text[i]} ({sum})({matches.Count})";
            }
            File.WriteAllLines("../../../output.txt", output);
        }
    }
}
