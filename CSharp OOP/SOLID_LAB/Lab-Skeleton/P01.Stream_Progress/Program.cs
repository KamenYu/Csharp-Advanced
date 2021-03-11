namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            StreamProgressInfo progressInfo = new StreamProgressInfo(new Music("","",10, 254));
            StreamProgressInfo progressInfo1 = new StreamProgressInfo(new File("",10, 254));
        }
    }
}
