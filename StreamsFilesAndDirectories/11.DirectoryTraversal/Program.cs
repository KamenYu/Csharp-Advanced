using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _11.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            Dictionary<string, Dictionary<string, double>> log = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo info = new DirectoryInfo("/Users/kamenyu/Downloads/Solutions/Documents/ProgrammingBasicsApril2020"); // change the path
            // i am on a mac

            FileInfo[] files = info.GetFiles();

            foreach (var item in files)
            {
                if (log.ContainsKey(item.Extension) == false)
                {
                    log.Add(item.Extension, new Dictionary<string, double>());
                }
                log[item.Extension].Add(item.Name, item.Length / 1024.00);
            }

            using (StreamWriter writer = new StreamWriter(@$"{path}/DirectoryTraversal.txt"))
            {
                foreach (var item in log.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))
                {
                    writer.WriteLine(item.Key);

                    foreach (var file in item.Value.OrderBy(x => x.Value))
                    {
                        writer.WriteLine($"--{file.Key} - {file.Value}kb");
                    }
                }
            }            
        }
    }
}
