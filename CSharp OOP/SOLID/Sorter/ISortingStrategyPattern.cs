using System.Collections.Generic;

namespace Sorter
{
    public interface ISortingStrategyPattern
    {
        ICollection<int> Sort (ICollection<int> collection);
    }
}
