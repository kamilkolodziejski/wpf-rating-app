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
        private IPagesManager _pagesManager;
        private RelayCommand _addBookCommand;

        public RelayCommand AddBookCommand
        {
            get
            {
                if (_addBookCommand == null)
                    _addBookCommand = new RelayCommand(execute => {
                        if (_pagesManager == null) _pagesManager = new UnityContainer().Resolve<IPagesManager>();
                        _pagesManager.SetPageView(new BookViewModel());
                        }, canExecute => true);
                return _addBookCommand;
            }
        }

        public BooksListViewModel()
        {
            LoadData();
        }

        //[Dependency]
        //public IPagesManager PagesManager
        //{
        //    set
        //    {
        //        _pagesManager = value;
        //    }
        //    private get { return _pagesManager; }
        //}

        public IBook SelectedBook
        {
            get { return _selectedBook; }
            set
            {
                _selectedBook = value;
                
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
