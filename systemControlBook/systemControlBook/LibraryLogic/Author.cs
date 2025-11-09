using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemControlBook.Новая_папка
{
    internal class Author
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string BirthDate { get; private set; }
        public List<Book> Books { get; private set; } = new List<Book>();

        public Author(string FirstName, string LastName, string BirthDate)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void GetAuthorsBook()
        {
            Console.WriteLine($"{FirstName} написал следующие книги:");
            foreach (Book book in Books)
            {
                Console.WriteLine(book.Title);
            }
        }

        public void GetAuthorsInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}" +
                $"\nРодился: {BirthDate}" +
                $"\nНаписал книг: {Books.Count}");
        }
    }
}
