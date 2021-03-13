using System;

namespace _6.ValidPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person("Gnihoshol", "Milinalin", 34); // valid
            //Person p2 = new Person(null, "Milinalin", 34); // invalid
            //Person p3 = new Person("Vedimir", string.Empty, 34); // invalid
            //Person p4 = new Person("Vedimir", "Ohobohov", -1); // invalid
            //Person p5 = new Person("Vedimir", "Hidrolivich", 12034); // invalid
            //Person p6 = new Person("", "", 34); // invalid
            //Person p = new Person("Pen40", "Ivanov", 12); // invalid

            try
            {
                Person p = new Person("Pen40", "Ivanov", 12);
            }
            catch (MyInvalidPersonNameException mipne)
            {
                Console.WriteLine(mipne.Message);
            }
            catch (ArgumentNullException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                Console.WriteLine(aoore.Message);
            }

        }
    }
}
