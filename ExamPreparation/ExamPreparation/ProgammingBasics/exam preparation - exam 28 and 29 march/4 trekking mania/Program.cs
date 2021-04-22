using System;
namespace _4_trekking_mania
{
    class Program
    {
        static void Main(string[] args)
        {
            //Според размера на групата, катерачите ще изкачват различни върхове.
            //•	Група до 5 човека– Мусала
            //•	Група от 6 до 12 – Монблан
            //•	Група от 13 до 25 – Килиманджаро
            //•	Група от 26 до 40 – К2
            //•	Група от 41 или повече – Еверест            
            
            int groups = int.Parse(Console.ReadLine()); //първи ред – броя на групите от катерачи – цяло число в интервала[1...1000]
            int total = 0;
            int musala = 0;
            int monblan = 0;
            int kilimanjaro = 0;
            int k2 = 0;
            int everest = 0;

            for (int i = 1; i <= groups; i++)
            {
                int peopleInEachGroup = int.Parse(Console.ReadLine()); //За всяка една група на отделен ред – броя на хората в групата – цяло число в интервала[1...1000]
                total += peopleInEachGroup;
                if (peopleInEachGroup <= 5)
                {
                    musala += peopleInEachGroup;
                }
                else if (peopleInEachGroup >= 6 && peopleInEachGroup <=12)
                {
                    monblan += peopleInEachGroup;
                }
                else if (peopleInEachGroup >= 13 && peopleInEachGroup <= 25)
                {
                    kilimanjaro += peopleInEachGroup;
                }
                else if (peopleInEachGroup >= 26 && peopleInEachGroup <= 40)
                {
                    k2 += peopleInEachGroup;
                }
                else
                {
                    everest += peopleInEachGroup;
                }
            }
            double musalaPercent = musala * 1.0 / total * 100;
            double monblanPercent = monblan * 1.0 / total * 100;
            double kilimanjaroPercent = kilimanjaro * 1.0 / total * 100;
            double k2Percent = k2 * 1.0 / total * 100;
            double everestPercent = everest * 1.0 / total * 100;

            Console.WriteLine($"{musalaPercent:f2}%");
            Console.WriteLine($"{monblanPercent:f2}%");
            Console.WriteLine($"{kilimanjaroPercent:f2}%");
            Console.WriteLine($"{k2Percent:f2}%");
            Console.WriteLine($"{everestPercent:f2}%");
        }
    }
}
