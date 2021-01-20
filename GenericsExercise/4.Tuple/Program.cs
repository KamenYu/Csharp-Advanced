using System;

namespace _4.Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // {first name} {last name} {address} {town}
            string[] line1 = Console.ReadLine().Split();
            string nameLine1 = $"{line1[0]} {line1[1]}";
            string address = line1[2];
            string town = string.Empty;

            if (line1.Length > 4)
            {
                town = $"{line1[3]} {line1[line1.Length - 1]}";                
            }
            else
            {
                town = $"{line1[3]}";
            }

            Tuple<string, string, string> line1T = new Tuple<string, string, string>(nameLine1, address, town);

            //{name} {liters of beer} {drunk or not}
            string[] line2 = Console.ReadLine().Split();
            string nameLine2 = line2[0];
            int litresOfBeer = int.Parse(line2[1]);

            bool isInebriated1 = default;

            if (line2[2] == "drunk")
            {
                isInebriated1 = true;
            }
            else
            {
                isInebriated1 = false;
            }

            Tuple<string, int, bool> line2T = new Tuple<string, int, bool>(nameLine2, litresOfBeer, isInebriated1);

            // {name} {account balance} {bank name}
            string[] line3 = Console.ReadLine().Split();
            string nameLine3 = line3[0];
            double num = double.Parse(line3[1]);
            string bankName = line3[2];

            Tuple<string, double, string> line3T = new Tuple<string, double, string>(nameLine3, num, bankName);

            Console.WriteLine(line1T);
            Console.WriteLine(line2T);
            Console.WriteLine(line3T);
        }
    }
}
