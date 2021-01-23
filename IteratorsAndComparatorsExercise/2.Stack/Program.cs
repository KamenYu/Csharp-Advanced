using System;
namespace _2.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack<int> myStack = new CustomStack<int>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                try
                {
                    string[] tokens = command.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    switch (tokens[0])
                    {
                        case "Push":
                            for (int i = 1; i < tokens.Length; i++)
                            {
                                myStack.Push(int.Parse(tokens[i]));
                            }
                            break;

                        case "Pop":
                            myStack.Pop();
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                command = Console.ReadLine();
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
