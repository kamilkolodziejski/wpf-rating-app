using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolodziejski.RatingApp.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _currentPageViewModel;
        //private List<BaseViewModel> _pageViewModels;

        public MainViewModel()
        {
            //_changePageViewModelCommand = new RelayCommand(p => OnChangeViewModel((BaseViewModel)p), p => p is BaseViewModel);

            //PageViewModels.Add(new BooksListViewModel());
            //PageViewModels.Add(new BookViewModel());

            CurrentPageViewModel = new BooksListViewModel();
        }

        public RelayCommand DisplayBookView
        {
            get
            {
                return new RelayCommand(action => CurrentPageViewModel = new BookViewModel(),
                              canExecute => true);
            }
        }

        public BaseViewModel CurrentPageViewModel
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

        //public List<BaseViewModel> PageViewModels
        //{
        //    get
        //    {
        //        if (_pageViewModels == null)
        //            _pageViewModels = new List<BaseViewModel>();

        //        return _pageViewModels;
        //    }
        //}

        private void OnChangeViewModel(BaseViewModel viewModel)
        {
            //if (!PageViewModels.Contains(viewModel))
            //    PageViewModels.Add(viewModel);
            //CurrentPageViewModel = PageViewModels.FirstOrDefault(x => x == viewModel);
            CurrentPageViewModel = viewModel;
        }
    }
}
