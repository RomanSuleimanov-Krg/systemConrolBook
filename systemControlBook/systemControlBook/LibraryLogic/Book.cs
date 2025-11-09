using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using systemControlBook.Новая_папка;



    internal class Book : ILibraryItem
    {
        public int ISBN { get; }
        public string Title { get; }
        public Author Author { get; }
        public string Genere { get; }
        public int Year { get; }
        public int Page { get; }
        public bool IsAvailable { get; private set; }

        public Book(int ISBN, string Title, Author Author, string Gener, int Year, int Page)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
            this.Genere = Gener;
            this.Year = Year;
            this.Page = Page;

            IsAvailable = true;

        }

        public void Borrow()
        {
            if (IsAvailable)
            {
                Console.WriteLine("Выдали книгу");
                IsAvailable = false;
            }
            else
            {
                Console.WriteLine("Данной книги нет в наличии");
            }

        }

        public void Return()
        {
            if (!IsAvailable)
            {
                Console.WriteLine("Книга возвращена обратно в библеотеку");
                IsAvailable=true;
            }
            else
            {
                Console.WriteLine("Такая книга уже лежит на полках");
            }
        }

        public void GetInfoByBook()
        {
            Console.WriteLine($"{Title}" +
                $"\nНаписал: {Author.FirstName} {Author.LastName}" +
                $"\nГод:{Year}" +
                $"\nСтраниц:{Page}");
        }
    }

