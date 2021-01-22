using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNames("Koko", "Kiki", "Kuki");
        }

        // params is always the last parameter
        
        public static void PrintNames(params string[] names)
        {
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
        }
    }
}
