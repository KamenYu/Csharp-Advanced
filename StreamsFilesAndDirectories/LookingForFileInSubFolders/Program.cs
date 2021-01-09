using System;
using System.IO;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath = "../../../TestFolder";

            Console.WriteLine(GetDirectorySize(dirPath));          
        }

        public static double GetDirectorySize(string path)
        {
            string[] files = Directory.GetFiles(path); // the files in the current directory

            string[] dirs = Directory.GetDirectories(path); // the dirs in the current dir

            for (int i = 0; i < dirs.Length; i++)
            {
                GetDirectorySize(dirs[i]);
            }

            double sum = 0;
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                sum += info.Length;
            }
            return sum;
        }
    }
}

