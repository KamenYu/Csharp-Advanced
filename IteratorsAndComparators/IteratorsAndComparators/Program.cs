using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);
            Book bookF = new Book("The Hunting Party", 2003, "Lindsey Lohan");

            Library library = new Library(bookOne, bookTwo, bookThree, bookF);

            //foreach (var book in library)
            //{
            //    Console.WriteLine(book.Title);
            //}

            //bookOne.Year.CompareTo(1234);
            //bookOne.CompareTo(bookTwo);

            List<Book> books = new List<Book>() { bookOne, bookTwo, bookThree, bookF };
            books.Sort(); // uses the CompareTo() from Book
            // OrderBy uses the same CompareTo() like Sort() , which means that I control them

            //foreach (var item in books)
            //{
            //    Console.WriteLine($"{item.Title} -> {item.Year}");
            //}

            Library libraryTwo = new Library(bookOne, bookTwo, bookThree, bookF);

            foreach (var book in libraryTwo)
            {
                Console.WriteLine(book);
            }

        }
    }
}
