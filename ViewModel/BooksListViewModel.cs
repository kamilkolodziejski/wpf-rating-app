using Interfaces;
using Interfaces.Domain;
using Kolodziejski.RatingApp.Core;
using Persistent;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolodziejski.RatingApp.ViewModel
{
    public class BooksListViewModel : BasePageViewModel
    {
        private ObservableCollection<IBook> _books;
        private IBook _selectedBook;

        public BooksListViewModel()
        {
            LoadData();
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

        private void LoadData()
        {
            var book = new BookDao()
            {
                Author = "Jony Sangiago",
                Title = "Pewnego razu w chinach",
                Genre = "Historyczna",
                Id = Guid.NewGuid(),
                Type = BookType.EBOOK,
                Description = "Gupia ksiazka",
                IsRead = false
            };
            Books.Add(book);

            book = new BookDao()
            {
                Author = "Adam Ziemniewicz",
                Title = "Ziemniaki - hodowla. Best practices.",
                Genre = "Naukowa",
                Id = Guid.NewGuid(),
                Type = BookType.PAPER,
                Description = "Mondra ksiazka",
                IsRead = true
            };
            Books.Add(book);
        }
    }
}
