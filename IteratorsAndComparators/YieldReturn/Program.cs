using System;
using System.Collections.Generic;

namespace YieldReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach (var name in GetNames())
            //{
            //    Console.WriteLine(name);
            //    Console.WriteLine("In the foreach");
            //}

            var enumerator = GetNames().GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }



        // foreach -> GetNames -> in -> yield return -> in -> var name
        // whatever is in {} -> in -> until the next yield return...->
        // the yield return "remembers" its place 
        // -> when there are no more yield returns it
        // yr retunrs the current method



        public static IEnumerable<string> GetNames()
        {
            // if it 'sees' yield return stops and
            // returns to the foreach
            yield return "Gogi";  
            Console.WriteLine("Moje");

            yield return "Bogi";
            Console.WriteLine("Rita");

            yield return "Moga";

            Console.WriteLine("ili");
            yield return "Go";

        }
    }
}
