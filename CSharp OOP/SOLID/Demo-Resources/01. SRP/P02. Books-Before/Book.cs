namespace P02._Books_Before
{
    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        //public int Location { get; set; } why does a book need to know on which page it was read

        //public string TurnPage(int page) why does a book need to know the current page, the user needs to know that
        //{
        //    return "Current page";
        //} useless
    }
}
