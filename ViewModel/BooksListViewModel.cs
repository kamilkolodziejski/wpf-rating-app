using Interfaces;
using Interfaces.Domain;
using Persistent;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Kolodziejski.RatingApp.ViewModel
{
    public class BooksListViewModel : BasePageViewModel
    {
        private ObservableCollection<IBook> _books;
        private IBook _selectedBook;

        public BooksListViewModel()
        {
            LoadData();
            AddBookCommand = new RelayCommand(x => BasePageViewModel.PageController.SetPageView(new BookViewModel()));
            EditBookCommand = new RelayCommand(x => BasePageViewModel.PageController.SetPageView(new BookViewModel()), pred => SelectedBook != null);
        }

        public RelayCommand AddBookCommand { get; private set; }
        public RelayCommand EditBookCommand { get; private set; }
        public IBook SelectedBook
        {
            get => _selectedBook; 
            set
            {
                _selectedBook = value;
                OnPropertyChanged(nameof(SelectedBook));
                //EditBookCommand.RaiseCanExecuteChanged();
            }
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
