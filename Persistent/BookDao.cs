using Interfaces.Domain;
using Kolodziejski.RatingApp.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistent
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

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
