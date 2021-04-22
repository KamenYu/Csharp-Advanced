using System;
namespace _5_suitcases_load
{
    class Program
    {
        static void Main(string[] args)
        {          
           // TODO check this again it gives you runtime error for the seond test       

            double capacity = double.Parse(Console.ReadLine());   //Капацитетът на багажника – реално число в диапазона[100.0…6000.0]
            string command = Console.ReadLine();
            int counter = 0;

            while (command != "End") //До получаване на команда "End" ще получавате обем на куфар.
            {
                double suitcaseVolume = double.Parse(command); //Обем на куфар – реално число в диапазона[100.0…6000.0]
                if (capacity <= suitcaseVolume) //Ако свободното пространството в даден момент е по-малко от обема на куфар товаренето ще прекъсне.
                {
                    Console.WriteLine("No more space!");
                    break;
                }
                counter++;
                if (counter % 3 == 0)
                {
                    suitcaseVolume = suitcaseVolume + (suitcaseVolume * 0.1); //Обемът на всеки трети куфар трябва да се увеличава с 10 %
                }
                capacity -= suitcaseVolume;
                command = Console.ReadLine();
            }
            if (command == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {counter} suitcases loaded.");
        }
    }
}
