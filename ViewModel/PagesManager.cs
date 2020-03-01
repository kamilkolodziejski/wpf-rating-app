using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Kolodziejski.RatingApp.ViewModel
{
    public class PagesManager : IPagesManager
    {

        public PagesManager()
        {
        }

        private IPagesViewModel _pagesViewModel;

        public void SetPageView(IViewModel viewModel)
        {
            if(_pagesViewModel == null)
                _pagesViewModel = new UnityContainer().Resolve<IPagesViewModel>();
            _pagesViewModel.CurrentPageViewModel = viewModel;
        }
    }
}
