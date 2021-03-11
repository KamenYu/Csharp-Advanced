using System.Collections.Generic;

namespace P02._Books_Before
{
    public class Library
    {
        public Dictionary<Book, int> Books { get; set; }

        public int GetPage (Book book)
        {
            return Books[book]; 
        }

        public int SetPage(Book book, int newPage)
        {
            return Books[book] = newPage;
        }
    }
}
