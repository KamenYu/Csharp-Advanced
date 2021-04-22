using FizzBuzz.Contracts;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private IWriter writer;
        public FizzBuzz(IWriter writer)
        {
            this.writer = writer;
        }

        public void PrintNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i <= 0)
                {
                    continue;
                }

                if (i > 100)
                {
                    break;
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    writer.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    writer.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    writer.WriteLine("Buzz");
                }                             
                else
                {
                    writer.WriteLine(i.ToString());
                }
            }
        }
    }
}
