using Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Repository
{
    public interface IBookRepository
    {
        void Persist(IBook book);
        IBook Get(Guid id);
        IEnumerable<IBook> GetAll();
    }
}
