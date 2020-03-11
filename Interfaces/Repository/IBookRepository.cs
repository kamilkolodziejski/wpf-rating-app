using Kolodziejski.RatingApp.Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolodziejski.RatingApp.Interfaces
{
    public interface IBookRepository
    {
        void Persist(IBook book);
        void Delete(Guid id);
        IList<IBook> Browse();
        IBook CreateNewBook();
    }
}
