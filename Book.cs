using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace IO_Files_And_Directories
{
    class Book
    {
        public int Id { get; set; }
        public Guid ISBN { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public int NumberOfPages { get; set; }
        public short NumberOfCopies { get; set; }
        public short NumberOfBorrowedOut { get; set; }
        public DateTime DatePublished { get; set; }

        List<Book> books = new List<Book>();

        public List<Book> BooksList()
        {
            books.Add(new Book { Id = 987, ISBN = new Guid(), Author = "Mozes", Name = "Efshar Gam Bly Qavier", NumberOfPages = 321, NumberOfCopies = 10, NumberOfBorrowedOut = 7, DatePublished = new DateTime(1947, 02, 01) });
            books.Add(new Book { Id = 964, ISBN = new Guid(), Author = "Ariel NAim", Name = "My First Book", NumberOfPages = 543, NumberOfCopies = 29, NumberOfBorrowedOut = 27, DatePublished = new DateTime(2007, 05, 24) });
            books.Add(new Book { Id = 864, ISBN = new Guid(), Author = "Haim Mosh", Name = "Ein li Shem Amiti", NumberOfPages = 111, NumberOfCopies = 7, NumberOfBorrowedOut = 0, DatePublished = new DateTime(1985, 11, 11) });
            books.Add(new Book { Id = 653, ISBN = new Guid(), Author = "Gady Halper", Name = "My New Car", NumberOfPages = 444, NumberOfCopies = 17, NumberOfBorrowedOut = 13, DatePublished = new DateTime(2021, 10, 21) });
            return books;
        }


        public string ToCSV()
        {
            string str;
            str = string.Format($"{Name},{Id}");
            return str;
        }

    }

    
}
