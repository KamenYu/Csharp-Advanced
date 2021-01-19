using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] names = ArrayCreator.Create(5, "Lolo");
            int[] ages = ArrayCreator.Create(3, 99);
            char[] percents = ArrayCreator.Create(99, '%');

            Console.WriteLine(string.Join(", ", percents));
        }
    }
}
