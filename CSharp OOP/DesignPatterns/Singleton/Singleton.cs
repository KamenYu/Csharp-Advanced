using System;
namespace SingletonDemo
{
    public sealed class Singleton // do NOT use
    {
        // ensures a clss has only one instance
        private static Singleton instance;
        // in multithreading two thread can instantiate two different instances
        // this is a problem and is solved by "locking"
        private static object padLock = new object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null) // double locking to ensure a single instance
                {
                    lock (padLock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }

                return instance;
            }
        }

        public void Work()
        {
            Console.WriteLine("Singleton works with a single instance");
        }

    }
}
