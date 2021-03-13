using System;

namespace _5.ToDoubleTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            while (true)
            {
                try
                {
                    string s = Console.ReadLine();
                    double d = Convert.ToDouble(s);
                }
                catch (FormatException fe) // value is not in an appropriate format for a Double type.
                {
                    Console.WriteLine(fe.Message);
                }
                catch (InvalidCastException ice) // value does not implement the IConvertible interface.
                {
                    Console.WriteLine(ice.Message);
                }
                catch (OverflowException oe) // value represents a number that is less than MinValue or greater than MaxValue.
                {
                    Console.WriteLine(oe.Message);

                }
            }
        }
    }
}
