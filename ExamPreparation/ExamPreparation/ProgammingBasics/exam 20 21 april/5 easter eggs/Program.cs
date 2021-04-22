using System;
namespace _5_easter_eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int colouredEggs = int.Parse(Console.ReadLine());
            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;

            for (int i = 0; i < colouredEggs; i++)
            {
                string colour = Console.ReadLine(); //"red", "orange", "blue", "green"
                if (colour == "red")
                {
                    redEggs++;
                }
                if (colour == "orange")
                {
                    orangeEggs++;
                }
                if (colour == "blue")
                {
                    blueEggs++;
                }
                if (colour == "green")
                {
                    greenEggs++;
                }
            }
            int max = Math.Max(redEggs, Math.Max(orangeEggs, Math.Max(blueEggs, greenEggs)));

            string colourMax = "";

            if (max == redEggs)
            {
                colourMax = "red";
            }
            else if (max == orangeEggs)
            {
                colourMax = "orange";
            }
            else if ( max == blueEggs)
            {
                colourMax = "blue";
            }
            else if (max == greenEggs)
            {
                colourMax = "green";
            }

            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            Console.WriteLine($"Max eggs: {max} -> {colourMax}");
        }
    }
}
