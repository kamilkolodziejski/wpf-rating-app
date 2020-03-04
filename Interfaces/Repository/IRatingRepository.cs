using Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Repository
{
    public interface IRatingRepository
    {
        void Persist(IRating book);
        IRating Get(Guid id);
        IEnumerable<IRating> GetAll();
    }
}
