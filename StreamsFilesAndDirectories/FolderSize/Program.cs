using System;
using System.IO;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath = "../../../TestFolder";
            string[] files = Directory.GetFiles(dirPath);
            double sum = 0;
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                sum += info.Length;
            }

            using (StreamWriter writer = new StreamWriter("../../../OutputInMB.txt"))
            {
                writer.WriteLine($"{sum / 1024 / 1024} MB");
            }           
        }
    }
}
