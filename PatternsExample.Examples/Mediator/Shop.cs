using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Examples.Mediator
{
    public class Shop
    {
        private readonly IMessanger _messanger;

        private List<Book> _books;
        public Shop(IMessanger messanger)
        {
            _messanger = messanger;
            _books = new List<Book>();
        }

        public Book GetBook(Guid code) =>
            _books.FirstOrDefault(x => x.Code == code);

        public Guid AddBook(string name)
        {
            var book = new Book(_messanger, name);
            _books.Add(book);
            return book.Code;
        }


    }
}
