using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            Books = new SortedSet<Book>(books, new BookComparator());
        }

        public SortedSet<Book> Books { get; set; }

        public IEnumerator<Book> GetEnumerator()
        {
            // easiest way is to do that because Books are already List, which has GetEnumerator()
            return new LibraryIterator(Books.ToList());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private int index = -1;
            public LibraryIterator(List<Book> books)
            {
                Books = books;
            }

            public List<Book> Books { get; set; }

            public Book Current => Books[index];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                return ++index < Books.Count;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
