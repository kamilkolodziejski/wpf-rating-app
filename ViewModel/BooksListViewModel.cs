using Kolodziejski.RatingApp.Interfaces;
using Kolodziejski.RatingApp.Interfaces.Domain;
using Kolodziejski.RatingApp.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using Kolodziejski.RatingApp.BusinessLogic;

namespace Kolodziejski.RatingApp.ViewModel
{
    public class BooksListViewModel : BasePageViewModel
    {
        private ObservableCollection<IBook> _books;
        private IBook _selectedBook;

        public BooksListViewModel()
        {
            base.Width = 700;
            base.Height = 1200;
            var bookService = new BookService();
            _books = new ObservableCollection<IBook>(bookService.GetBooks());
            AddBookCommand = new RelayCommand(AddNewBook);
            EditBookCommand = new RelayCommand(x => EditBook(x), pred => SelectedBook != null);
            DeleteBookCommand = new RelayCommand(x => DeleteBook(x), pred => SelectedBook != null);
        }

        public RelayCommand AddBookCommand { get; private set; }
        public RelayCommand EditBookCommand { get; private set; }
        public RelayCommand DeleteBookCommand { get; private set; }
        public IBook SelectedBook
        {
            get => _selectedBook;
            set => SetValue(ref _selectedBook, value);
        }

        private void AddNewBook(object x)
        {
            var view = new BookViewModel();
            view.ActiveBook = new BookService().CreateNewBook();
            PagesControllerFactory.INSTANCE.SetPageView(view, 360, 360);
        }

        private void EditBook(object x)
        {
            Console.WriteLine(SelectedBook.ToString());
            var view = new BookViewModel();
            view.ActiveBook = SelectedBook;
            PagesControllerFactory.INSTANCE.SetPageView(view, 360, 360);
        }

        private void DeleteBook(object x)
        {
            var bookService = new BookService();
            bookService.RemoveBook(SelectedBook.Id);
            Books.Remove(SelectedBook);
            SelectedBook = null;
        }

        public ObservableCollection<IBook> Books
        {
            get
            {
                if(_books == null)
                {
                    _books = new ObservableCollection<IBook>();
                }
                return _books;
            }
            set => SetValue(ref _books, value);
        }
    }
}
