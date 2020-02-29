using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolodziejski.RatingApp.ViewModel
{
    public static class ViewsMediator
    {
        public static ApplicationViewModel ParentViewModel;

        public static void ChangeView(int id)
        {
            ParentViewModel.CurrentPageViewModel = ParentViewModel.PageViewModels[1];
        }
    }
}
