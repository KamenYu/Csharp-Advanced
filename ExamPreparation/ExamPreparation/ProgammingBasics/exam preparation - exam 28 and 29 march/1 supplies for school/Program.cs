using System;

namespace supplies_for_school
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Пакет химикали -5.80 лв
            //•	Пакет маркери -7.20 лв
            //•	Препарат - 1.20 лв(за литър)
           
            int penPack = int.Parse(Console.ReadLine());
            int markerPack = int.Parse(Console.ReadLine());
            double boardCleaner = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double sum = penPack * 5.8 + markerPack * 7.2 + boardCleaner * 1.2;
            double total = sum - sum * discount * 0.01;
            Console.WriteLine($"{total:f3}");

        }
    }
}
