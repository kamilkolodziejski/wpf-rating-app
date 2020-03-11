using Kolodziejski.RatingApp.Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolodziejski.RatingApp.Persist.InMemory
{
    public class RatingDao : IRating
    {
        public Guid Id { get; set; }
        public string Author { get; set; }
        public int RatingPoints { get; set; }
        public string Comment { get; set; }
    }
}
