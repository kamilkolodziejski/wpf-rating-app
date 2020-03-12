using Kolodziejski.RatingApp.Core;
using Kolodziejski.RatingApp.Interfaces.Domain;
using System;

namespace Kolodziejski.RatingApp.Persist.AnotherMockDatabase
{
    public class AnotherBookDao : IBook
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public BookType Type { get; set; }
        public bool IsRead { get; set; }
        //private RatingDao _rating = new RatingDao();
        public IRating Rating { get; set; }
        //{
        //    get => (IRating)_rating;
        //    set => _rating = (RatingDao) value;
        //}
    }
}
