using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemControlBook.Новая_папка
{
    internal class Library
    {
        //Свойства: List<Book> Books, List<Author> Authors, List<Reader> Readers
        public List<Book> BooksInLibrary { get; private set; } = new List<Book>();
        public List<Author> Authors { get; private set; } = new List<Author>();
        public List<Reader> Readers { get; private set; } = new List<Reader>();

        //Методы: AddBook(), AddAuthor(), RegisterReader(), FindBooksByGenre(), FindBooksByAuthor(), GetLibraryStatistics()

        public void AddBook(Book book)
        {
            if (BooksInLibrary.Contains(book))
            {
                Console.WriteLine($"Данные книги уже лежат на полках нашей библиотеки");
            }
            else
            {
                BooksInLibrary.Add(book);
                Console.WriteLine($"Наша библиотека теперь дом для новой книги");
            }
        }

        public void AddAuthor(Author author)
        {
            if (Authors.Contains(author))
            {
                Console.WriteLine($"Вы уже находитесь в списке авторов нашей библиотеки");
            }
            else
            {
                Authors.Add(author);
            }
        }

        public void RegisterReader(Reader reader)
        {
            if (Readers.Contains(reader))
            {
                Console.WriteLine($"Вы не являетесь новым читателем в нашей библеотеке");
            }
            else
            {
                Readers.Add(reader);
            }
        }

        public void FindBooksByGenre(string genre)
        {
            Console.WriteLine($"Вот список книг которые соответсвуют вашему предпочтению по жанрам");

            for (int i = 0; i < BooksInLibrary.Count; i++)
            {
                if (BooksInLibrary[i].Genere == genre)
                {
                    BooksInLibrary[i].GetInfoByBook();
                }
            }

        }

        public void FindBooksByAuthor(Author author)
        {
            if (!Authors.Contains(author))
            {
                Console.WriteLine($"У нас нет книг написанных данным автором");
            }
            else
            {
                author.GetAuthorsBook();
            }
        }

        public void GetLibraryStatistics()
        {
            Console.WriteLine($"Доносим к вашему сведению, что наша библиотека хранит в себе:" +
                $"\nКниг: {BooksInLibrary.Count + 1}" +
                $"\nЧитателей которые активно пользуются нашими услугами: {Readers.Count + 1}");
        }
    }
}
