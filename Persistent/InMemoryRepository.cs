using Interfaces.Domain;
using Interfaces.Repository;
using Persistent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolodziejski.RatingApp.Persist.InMemory
{
    public class InMemoryRepository : IBookRepository, IRatingRepository
    {
        private IEnumerable<IBook> _books;
        private IEnumerable<IRating> _ratings;

        public InMemoryRepository()
        {
            _books = new List<IBook>();
            _ratings = new List<IRating>();
        }

        public IRating Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IRating> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Persist(IRating book)
        {
            throw new NotImplementedException();
        }

        public void Persist(IBook book)
        {
            throw new NotImplementedException();
        }

        IBook IBookRepository.Get(Guid id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<IBook> IBookRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
