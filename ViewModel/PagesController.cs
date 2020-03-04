using Interfaces;
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
