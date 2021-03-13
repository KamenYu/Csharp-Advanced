using System;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    throw new ExecutionEngineException();
                }
                catch (ExecutionEngineException eex)
                {
                    Console.WriteLine(eex.Message);
                    throw eex;
                }
            }
            catch (Exception ex) // catches all exc, it is the base, not the best solution
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
