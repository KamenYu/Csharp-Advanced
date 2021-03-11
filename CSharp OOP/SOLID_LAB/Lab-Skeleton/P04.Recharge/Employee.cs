namespace P04.Recharge
{
    using System;

    public class Employee : IWorker, ISleeper
    {
        public Employee(string id)
        {
            ID = id;
        }

        public string ID { get; set; }

        public void Sleep()
        {
            Console.WriteLine("Dream a little dream of meeee...");
        }

        public void Work(int hours)
        {
            if (hours >= 9)
            {
                Console.WriteLine("Time to sleep");
            }
            else
            {
                Console.WriteLine("Let's to work");
            }            
        }
    }
}
