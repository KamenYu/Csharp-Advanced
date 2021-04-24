using System;
using FactoryMethodPattern.Contracts;

namespace FactoryMethodPattern
{
    public class Lynx :ICarnivore
    {
        public Lynx()
        {
        }

        public string Prey { get; set; }
    }
}
