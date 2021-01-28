using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string input = Console.ReadLine();

            while (input != "Beast!")
            {
                try
                {
                    string[] info = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    switch (input)
                    {
                        case "Cat":
                            Cat cat = new Cat(info[0], int.Parse(info[1]), info[2]);
                            animals.Add(cat);
                            break;

                        case "Kitten":
                            Kitten kitten = new Kitten(info[0], int.Parse(info[1]));
                            animals.Add(kitten);
                            break;

                        case "Tomcat":
                            Tomcat tomCat = new Tomcat(info[0], int.Parse(info[1]));
                            animals.Add(tomCat);
                            break;

                        case "Dog":
                            Dog dog = new Dog(info[0], int.Parse(info[1]), info[2]);
                            animals.Add(dog);
                            break;

                        case "Frog":
                            Frog frog = new Frog(info[0], int.Parse(info[1]), info[2]);
                            animals.Add(frog);
                            break;

                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
