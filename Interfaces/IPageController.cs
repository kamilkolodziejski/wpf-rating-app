using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IPageController
    {
        void SetPageView(object pageView);
        void SetPageView(object pageView, int width, int hegith);
    }
}
