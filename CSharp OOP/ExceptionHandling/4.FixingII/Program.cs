using System;

namespace _4.FixingII
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1 = 30, num2 = 60;
                byte result = Convert.ToByte(num1 * num2);
                // short result = (short)(num1 * num2);

                Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
