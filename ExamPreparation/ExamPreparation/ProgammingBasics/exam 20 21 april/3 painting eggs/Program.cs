using System;

namespace _3_painting_eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            //                Червено(Red)   Зелено(Green)  Жълто(Yellow)
            //Големи(Large)      16 лв.        12 лв.        9 лв.
            //Средни(Medium)     13 лв.         9 лв.        7 лв.
            //Малки(Small)        9 лв.         8 лв.        5 лв.

            //С 35 % от крайната цена ще бъдат покрити производствени разходи.

            string size = Console.ReadLine();    //"Large", "Medium" или "Small"
            string colour = Console.ReadLine();              //"Red", "Green" или "Yellow"
            int sets = int.Parse(Console.ReadLine());
            int sum = 0;

            if (size == "Large")
            {
                if (colour == "Red")
                {
                    sum = sets * 16;
                }
                else if (colour == "Green")
                {
                    sum = sets * 12;
                }
                else if (colour == "Yellow")
                {
                    sum = sets * 9;
                }
            }
            else if (size == "Medium")
            {
                if (colour == "Red")
                {
                    sum = sets * 13;
                }
                else if (colour == "Green")
                {
                    sum = sets * 9;
                }
                else if (colour == "Yellow")
                {
                    sum = sets * 7;
                }
            }
            else if (size == "Small")
            {
                if (colour == "Red")
                {
                    sum = sets * 9;
                }
                else if (colour == "Green")
                {
                    sum = sets * 8;
                }
                else if (colour == "Yellow")
                {
                    sum = sets * 5;
                }
            }

            double rest = sum - (sum * 0.35);
            Console.WriteLine($"{rest:f2} leva.");
        }
    }
}
