using System;

namespace _1.SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());

                if (n < 0)
                {
                    throw new ArithmeticException();
                }

                Console.WriteLine(Math.Sqrt(n));
            }
            catch (ArithmeticException ae)
            {
                Console.WriteLine("Invalid number");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
