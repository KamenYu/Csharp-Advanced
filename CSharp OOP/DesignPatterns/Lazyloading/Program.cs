using System;

namespace Lazyloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Lazy<Cart> cart = new Lazy<Cart>(()=> new Cart("shopping"));
            Console.WriteLine("In main");

            cart.Value.Balance = 300;
            Console.WriteLine(cart.Value.Balance);
        }
    }
}
