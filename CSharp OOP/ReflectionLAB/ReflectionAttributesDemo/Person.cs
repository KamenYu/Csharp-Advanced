using System;

namespace ReflectionAttributesDemo
{
    //[Obsolete] // no longer in use
    [Author("Koljo")]
    [Author("Ivan")]
    [Author("Livan")]
    [Author("Baj Ivan")]

    public class Person
    {
        
        public Person()
        {
        }

        [Author("Livan")]
        [Author("Baj Ivan")]

        public int Age { get; set; }
    }
}
