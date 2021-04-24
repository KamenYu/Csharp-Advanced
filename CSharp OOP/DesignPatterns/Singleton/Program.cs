namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton s = new Singleton(); // does not work, ctor is private

            //Singleton.Instance == null
            Singleton singleton = Singleton.Instance;
            //Singleton.Instance = singleton instance
            Singleton singleton2 = Singleton.Instance;
            //Singleton.Instance = singleton instance, not singleton2 instance
            singleton.Work();
        }
    }
}
