using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemControlBook.Новая_папка
{
    internal class Reader
    {
        public int ReaderId { get; private set; }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public List<Book> BorrowedBooks { get; private set; } = new List<Book>();

        public Reader(int ReaderId, string FullName, string Email)
        {
            this.ReaderId = ReaderId;
            this.FullName = FullName;
            this.Email = Email;
        }

        public void BorrowBook(Book book)
        {
            if (book.IsAvailable)
            {
                book.Borrow();
                BorrowedBooks.Add(book);
            }
            else
            {
                Console.WriteLine($"Низя взять эту книгу.");
            }
        }

        public void ReturnBook(Book book)
        {
            if (!BorrowedBooks.Contains(book))
            {
                Console.WriteLine("Такой книги не наблюдалось в этой библиотеке.");
            }
            else
            {
                book.Return();
                BorrowedBooks.Remove(book);
                Console.WriteLine($"Ура, я вернул книжку");
            }
        }

        public void GetBorrowedBooks()
        {
            Console.WriteLine($"Мне нужно вернуть следующие книги в библеотеку:");
            foreach (Book book in BorrowedBooks)
            {
                book.GetInfoByBook();
            }
        }
    }
}
