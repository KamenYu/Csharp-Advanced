using System.Collections.Generic;
using System.Text;

namespace _2.GenericSwapMethodStringAndInt
{
    public class Box<T>
    {

        public List<T> List { get; set; } = new List<T>();

        public Box(List<T> input)
        {
            List = input;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (IndexChecker(firstIndex) && IndexChecker(secondIndex))
            {
                T temp = List[firstIndex];
                List[firstIndex] = List[secondIndex];
                List[secondIndex] = temp;
            }
        }

        private bool IndexChecker(int index)
            => index >= 0 && index < List.Count;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in List)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString().TrimEnd();
        }

    }
}
