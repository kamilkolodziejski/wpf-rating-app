using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolodziejski.RatingApp.ViewModel
{
    public class PagesController : BasePageViewModel, IPageController
    {
        private BasePageViewModel _currentPageViewModel;



        public PagesController()
        {

        }
        
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
            }
        }
    }
}
