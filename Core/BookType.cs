using System.ComponentModel;

namespace Kolodziejski.RatingApp.Core
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum BookType
    {
        [Description("E-Book")]
        EBOOK, 
        [Description("Książka papierowa")]
        PAPER, 
        [Description("Audiobook")]
        AUDIO
    }
}