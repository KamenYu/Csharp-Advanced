using System;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before try-finally");

            try
            {
                string s = Console.ReadLine();
                int.Parse(s);
                Console.WriteLine("Parsing successful.");
                return; // goes to finally
            }
            catch (FormatException fe)
            {
                Console.WriteLine
                    (fe.Message + $"{Environment.NewLine}Parsing failed");
            }
            finally // always executed
            {
                Console.WriteLine("This cleanup code is always executed.");
            }
            // when "return" this code is unreachable
            Console.WriteLine("After try-finally");

            // if input is valid 
                // Before try-finally           
                // 3
                // 3
                // Parsing successful.
                // This cleanup code is always executed
            // if input is invalid
                // Before try-finally
                // w
                // w
                // Input string was not in a correct format.
                // Parsing failed
                // This cleanup code is always executed.
                // After try-finally

        }
    }
}
