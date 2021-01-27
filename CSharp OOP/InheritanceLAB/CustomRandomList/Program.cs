using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();

            list.Add("Koko");
            list.Add("Ktko");
            list.Add("Keko");
            list.Add("Koto");
            list.Add("Kowo");
            string random = list.RandomString();
            Console.WriteLine(random);
        }
    }
}
