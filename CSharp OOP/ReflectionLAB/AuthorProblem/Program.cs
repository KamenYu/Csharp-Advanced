using System;

namespace AuthorProblem
{
    [Author("Niko")]
    public class StartUp
    {
        [Author("Losho kuche Gosho")]
        static void Main(string[] args)
        {
            Tracker tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }
    }
}
