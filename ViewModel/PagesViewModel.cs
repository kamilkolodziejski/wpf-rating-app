﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolodziejski.RatingApp.ViewModel
{
    public class PagesViewModel : BaseViewModel
    {
        private BaseViewModel _currentPageViewModel;
        //private List<BaseViewModel> _pageViewModels;

        public PagesViewModel()
        {
            //_changePageViewModelCommand = new RelayCommand(p => OnChangeViewModel((BaseViewModel)p), p => p is BaseViewModel);

            //PageViewModels.Add(new BooksListViewModel());
            //PageViewModels.Add(new BookViewModel());

            CurrentPageViewModel = new BooksListViewModel();
        }

        private RelayCommand _displayBookView;
        public RelayCommand DisplayBookView
        {
            get
            {
                if(_displayBookView==null)
                    _displayBookView = new RelayCommand(action => CurrentPageViewModel = new BookViewModel());
                Console.WriteLine("HELLLOOOOOO");
                return _displayBookView;
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