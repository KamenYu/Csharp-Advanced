using CollectionHeirarchy.Interfaces;

namespace CollectionHeirarchy.Models
{
    public class AddCollection : IAddCollection
    {
        private int index = -1;

        public int Add(string item) // add to the end
        {
            return ++index; 
        }
    }
}
