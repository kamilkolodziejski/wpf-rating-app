using Kolodziejski.RatingApp.Interfaces;
using Kolodziejski.RatingApp.Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolodziejski.RatingApp.BusinessLogic
{
    public class BookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService()
        {
            var classProvider = new ClassProvider();
            _bookRepository = classProvider.GetBookRepositoryImplementation();
        }

        public void AddBook(IBook book)
        {
            _bookRepository.Persist(book);
        }

        public IBook CreateNewBook()
            => _bookRepository.CreateNewBook();

        public IList<IBook> GetBooks()
            => _bookRepository.Browse();

        public IBook GetBookById(Guid id)
            => _bookRepository.Browse().First(x => x.Id == id);
    }
}
