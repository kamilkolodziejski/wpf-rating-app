using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolodziejski.RatingApp.ViewModel
{
    public static class PagesControllerFactory
    {
        private static IPageController _pagesController;

        public static IPageController INSTANCE
        {
            get
            {
                if (_pagesController == null)
                    _pagesController = new PagesController();
                return _pagesController;
            }
        }
    }
}
