using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            books.Add(new Book { Id = 56, Author = "Arthur Conan Doyle", DatePublished = new DateTime(1887, 04, 20) });
            books.Add(new Book { Id = 56, Author = "Arthur Conan Doyle", DatePublished = new DateTime(1887, 04, 20) });
            books.Add(new Book { Id = 56, Author = "Arthur Conan Doyle", DatePublished = new DateTime(1887, 04, 20) });



        }
    }

    public class Book
    {
        public int Id { get; set; }
        public Guid ISBN { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public int NumberOfPages { get; set; }
        public short NumberOfCopies { get; set; }
        public short NumberOfBorrowedOut { get; set; }
        public DateTime DatePublished { get; set; }


    }
}
