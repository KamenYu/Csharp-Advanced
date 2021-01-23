using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ListyIterator<string> list = null;

            //list.Print();
            //list.Move();
            //list.Print();

            string command = Console.ReadLine();

            while (command != "END")
            {
                try
                {
                    string[] tokens = command.Split();

                    switch (tokens[0])
                    {
                        case "Create":
                            List<string> items = tokens.Skip(1)
                                .ToList();
                            list = new ListyIterator<string>(items);

                            break;

                        case "HasNext":
                            Console.WriteLine(list.HasNext());
                            break;

                        case "Print":
                            list.Print();
                            break;

                        case "Move":
                            Console.WriteLine(list.Move());
                            break;

                        case "PrintAll":

                            foreach (string item in list)
                            {
                                Console.Write(item + " ");
                            }

                            Console.WriteLine();
                            break;
                    }
                }
                catch (Exception ex) // try catching the expected exceptions, not all
                {
                    Console.WriteLine(ex.Message);
                }

                command = Console.ReadLine();
            }
        }
    }
}
