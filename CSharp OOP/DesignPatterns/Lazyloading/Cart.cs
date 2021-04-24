using System;
namespace Lazyloading
{
    public class Cart
    {
        public Cart(string what)
        {
            Console.WriteLine("Started " + what);
        }

        public int Balance { get; set; }
    }
}
