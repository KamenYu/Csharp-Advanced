using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Command Pattern follows O/C
            User user = new User(new Calculator());

            while (true)
            {
                Console.WriteLine("Enter operation_ "); // + 5.6
                string[] split = Console.ReadLine().Split();

                if (split[0].Contains("undo"))
                {
                    int undoLevels = int.Parse(split[1]);
                    user.Calculator.Undo(undoLevels);
                }
                else
                {
                    string sign = split[0];
                    decimal value = decimal.Parse(split[1]);

                    user.Calculate(sign, value);
                }

                Console.WriteLine($"New Value is : {user.Calculator.CurrentValue}");
            }
        }
    }
}
