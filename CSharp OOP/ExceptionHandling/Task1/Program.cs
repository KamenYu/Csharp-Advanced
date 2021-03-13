using System;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {                        
            try
            {
                string s = Console.ReadLine();
                //string s = Console.ReadLine().Substring(0, 2);
                int num = int.Parse(s);

                //for (double i = 0; i < 3.5; i+= 0.5)
                //{
                //    Console.WriteLine(i);
                //}
            }
            catch (FormatException fe) // catch behaves like an if,
            //in example 1.23344557893753672563458685746863863, the catched exception is FE
            // and other exceptions are skipped
            {
                Console.WriteLine("Invalid number format");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("The number is too big");
            }
            catch (Exception e)
            {
                Console.WriteLine("There is a problem, but who knows where or what it is!");
            }
        }
    }
}
