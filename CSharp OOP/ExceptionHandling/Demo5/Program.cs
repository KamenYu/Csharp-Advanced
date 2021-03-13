using System;

namespace _7.CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            // stays in a folder Exceptions

            try
            {
                throw new MyInvalidUserNameException("Pesho", "Not authenticated");
            }
            catch (MyInvalidUserNameException miue)
            {
                Console.WriteLine($"{miue.UserName} -> {miue.Message}");
            }
            catch (SystemException se)
            {
                Console.WriteLine(se.Message);
            }
        }
    }

    public class MyInvalidUserNameException : Exception
    {
        public MyInvalidUserNameException(string username, string message)
            : base(message)
        {
            UserName = username;
        }

        public MyInvalidUserNameException()
        { }

        public string UserName { get; }
     
    }
}
