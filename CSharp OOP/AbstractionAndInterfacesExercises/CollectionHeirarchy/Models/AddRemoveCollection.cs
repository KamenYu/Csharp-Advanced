using System.Collections.Generic;

using CollectionHeirarchy.Interfaces;

namespace CollectionHeirarchy.Models
{
    public class AddRemoveCollection : IAddRemoveCollection
    {
        private readonly List<string> list = new List<string>(100);
        private int index = -1;

        public int Add(string item) // ADD TO THE start
        {
            index++;
            list.Insert(index, item);
            return 0; // ???
        }

        public string Remove() // removes the last item
        {
            string removedAtLastPostion = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            index--;
            return removedAtLastPostion;
        }
    }
}
