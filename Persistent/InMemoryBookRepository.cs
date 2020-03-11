using Kolodziejski.RatingApp.Interfaces;
using Kolodziejski.RatingApp.Interfaces.Domain;
using Kolodziejski.RatingApp.Persist.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolodziejski.RatingApp.Persist.InMemory
{
    public class InMemoryBookRepository : IBookRepository
    {
        private static IList<IBook> _books = new List<IBook>();

        public IList<IBook> Browse()
            => _books;

        public IBook CreateNewBook()
            => new BookDao();

        public void Delete(Guid id)
        {
            var book = _books.First(x => x.Id == id);
            _books.Remove(book);
        }
        
        public void Persist(IBook book)
        {
            var bookFromStore = _books.First(r => r.Id == book.Id);
            if (bookFromStore != null)
            {
                bookFromStore = book;
            }
            else
            {
                _books.Add(book);
            }
        }
    }
}
