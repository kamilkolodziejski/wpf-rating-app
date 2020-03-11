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
            var bookService = new BookService();
            AddBookCommand = new RelayCommand(x => PagesControllerFactory.INSTANCE.SetPageView(new BookViewModel(), 360, 360));
            EditBookCommand = new RelayCommand(x => EditBook(x), pred => SelectedBook != null);
        }

        public RelayCommand AddBookCommand { get; private set; }
        public RelayCommand EditBookCommand { get; private set; }
        public IBook SelectedBook
        {
            get => _selectedBook;
            set => SetValue(ref _selectedBook, value);
        }

        private void EditBook(object x)
        {
            var view = new BookViewModel();
            view.ActiveBook = SelectedBook;
            PagesControllerFactory.INSTANCE.SetPageView(view, 360, 360);
            var pageController = (PagesController) PagesControllerFactory.INSTANCE;
            ((BookViewModel)pageController.CurrentPageViewModel).ActiveBook = SelectedBook;
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
        }
    }
}
