using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random rand;

        public RandomList()
        {
            rand = new Random();
        }

        public string RandomString()
        {           
            int removed = rand.Next(0, Count);
            string randomString = this[removed];
            RemoveAt(removed);
            return randomString;            
        }
    }
}
