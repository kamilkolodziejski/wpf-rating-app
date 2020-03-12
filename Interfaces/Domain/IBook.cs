using Kolodziejski.RatingApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolodziejski.RatingApp.Interfaces.Domain
{
    public interface IBook
    {
        Guid Id { get; set; }
        String Title { get; set; }
        String Genre { get; set; }
        String Author { get; set; }
        String Description { get; set; }
        bool IsRead { get; set; }
        BookType Type { get; set; }
        IRating Rating { get; set; }
    }
}
