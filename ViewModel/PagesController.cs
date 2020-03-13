using Kolodziejski.RatingApp.BusinessLogic;
using Kolodziejski.RatingApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kolodziejski.RatingApp.ViewModel
{
    public class PagesController : BasePageViewModel, IPageController
    {
        private BasePageViewModel _currentPageViewModel;
        private List<BasePageViewModel> _pageViewModels;

        public PagesController()
        {
            var bookService = new BookService();
            var book = bookService.CreateNewBook();
            book.Id = Guid.NewGuid();
            book.Title = "Test title";
            book.Author = "Jan Kowalski";
            book.Genre = "Fantasy";
            book.Type = Core.BookType.AUDIO;
            book.IsRead = false;
            book.Description = "Simple description";

            book.Rating.Author = "Ja";
            book.Rating.Comment = "Hujnia";
            book.Rating.RatingPoints = 5;
            bookService.AddBook(book);

            PageViewModels.Add(new BooksListViewModel());
            PageViewModels.Add(new BookViewModel());

            CurrentPageViewModel = PageViewModels[0];
        }

        public List<BasePageViewModel> PageViewModels
        {
            get
            {
                if (_pageViewModels == null)
                    _pageViewModels = new List<BasePageViewModel>();
                return _pageViewModels;
            }
        }

        public int Width { set => Application.Current.MainWindow.Height = value; }
        public int Height { set => Application.Current.MainWindow.Width = value; }

        #region PageMethods
        public BasePageViewModel CurrentPageViewModel
        {
            get { return _currentPageViewModel; }
            set
            {
                if (value != _currentPageViewModel)
                {
                    _currentPageViewModel = value;
                    OnPropertyChanged("CurrentPageViewModel");
                }
            }
        }

        public void SetPageView(object pageView)
        {
            if(pageView is BasePageViewModel)
            {
                CurrentPageViewModel = (BasePageViewModel) pageView;
                if(CurrentPageViewModel.Width.HasValue && CurrentPageViewModel.Height.HasValue)
                {
                    Width = CurrentPageViewModel.Width.Value;
                    Height = CurrentPageViewModel.Height.Value;
                }
                //if (!PageViewModels.Contains(pageView))
                //    PageViewModels.Add((BasePageViewModel)pageView);

                //CurrentPageViewModel = PageViewModels.FirstOrDefault(p => p == pageView);
            }
        }
        public void SetPageView(object pageView, int width, int height)
        {
            if (pageView is BasePageViewModel)
            {
                CurrentPageViewModel = (BasePageViewModel)pageView;
                Width = width;
                Height = height;
                //if (!PageViewModels.Contains(pageView))
                //    PageViewModels.Add((BasePageViewModel)pageView);

                //CurrentPageViewModel = PageViewModels.FirstOrDefault(p => p == pageView);
            }
        }

        #endregion
    }
}
