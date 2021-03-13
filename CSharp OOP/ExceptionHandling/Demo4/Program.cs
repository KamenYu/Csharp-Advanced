using System;

namespace Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
             // envelopes one exc inside another and keeps the information
             try
             { 
                try
                {
                    throw new ArgumentException("I am AE!");
                }
                catch (ArgumentException ae)
                {
                    throw new InvalidOperationException
                        ("I am IOE with inner AE", ae);
                }
             }
             catch(Exception e)
             {
                Console.WriteLine(e);
             }
        }
    }
}
