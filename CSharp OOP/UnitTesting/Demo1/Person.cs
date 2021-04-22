using System;
namespace Demo1
{
    public class Person
    {
        public Person(string name, decimal money)
        {
            Name = name;
            SavedMoney = money;
        }

        public string Name { get; set; }

        public decimal SavedMoney { get; set; }

        public string WhatIsMyName()
        {
            return $"My name is {Name}";
            //throw new ArgumentException("Given name is not valid");
        }
    }
}
