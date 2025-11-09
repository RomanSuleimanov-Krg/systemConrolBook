using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemControlBook.Новая_папка
{
    internal interface ILibraryItem
    {
        int ISBN { get; }
        string Title { get; }
        public bool IsAvailable { get; }
        public void Borrow();
        public void Return();

    }
}
