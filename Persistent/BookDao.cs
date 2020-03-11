using Kolodziejski.RatingApp.Interfaces.Domain;
using Kolodziejski.RatingApp.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolodziejski.RatingApp.Persist.InMemory
{
    public class BookDao : IBook
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public BookType Type { get; set; }
        public bool IsRead { get; set; }
        //private RatingDao _rating = new RatingDao();
        //public IRating Rating
        //{
        //    get => (IRating)_rating;
        //    set => _rating = (RatingDao) value;
        //}
    }
}
