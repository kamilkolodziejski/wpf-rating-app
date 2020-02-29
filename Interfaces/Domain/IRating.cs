using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Domain
{
    public interface IRating
    {
        Guid Id { get; set; }
        String Author { get; set; }
        int RatingPoints { get; set; }
        String Comment { get; set; }
    }
}
