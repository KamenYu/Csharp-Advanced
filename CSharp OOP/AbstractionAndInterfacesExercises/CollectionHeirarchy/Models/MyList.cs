using System.Collections.Generic;

using CollectionHeirarchy.Interfaces;

namespace CollectionHeirarchy.Models
{
    public class MyList : IMyList
    {
        private readonly List<string> list = new List<string>(100);
        private int index = -1;

        public int Used { get; }

        public int Add(string item) // ADD TO THE start
        {
            index++;
            list.Insert(index, item);
            return 0;
        }

        public string Remove() // first element in the collection
        {
            string first = list[0];
            list.RemoveAt(0);
            return first;
        }
    }
}
