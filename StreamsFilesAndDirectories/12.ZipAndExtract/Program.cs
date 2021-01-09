using System.IO.Compression;

namespace _12.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory("/Users/kamenyu/Downloads/Problem04-Spiral-Matrix", "/Users/kamenyu/Downloads/createdByCSharp.zip");
            // change according to your machine
            ZipFile.ExtractToDirectory("/Users/kamenyu/Downloads/createdByCSharp.zip", "/Users/kamenyu/Downloads/work/");
            // check folders, they may not exist
        }
    }
}
