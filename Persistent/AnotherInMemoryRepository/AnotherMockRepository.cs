using Kolodziejski.RatingApp.Interfaces;
using Kolodziejski.RatingApp.Interfaces.Domain;
using Kolodziejski.RatingApp.Persist.AnotherMockDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolodziejski.RatingApp.Persist.AnotherMockDatabase
{
    public class AnotherMockRepository : IBookRepository
    {
        private static IList<IBook> _books = new List<IBook>();

        public IList<IBook> Browse()
            => _books;

        public IBook CreateNewBook()
            => new AnotherBookDao();

        public void Delete(Guid id)
        {
            var book = _books.FirstOrDefault(x => x.Id == id);
            _books.Remove(book);
        }
        
        public void Persist(IBook book)
        {
            var bookFromStore = _books.FirstOrDefault(r => r.Id == book.Id);
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
