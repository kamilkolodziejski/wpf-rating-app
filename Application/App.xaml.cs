using Interfaces;
using Kolodziejski.RatingApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Unity;

namespace Kolodziejski.RatingApp.Application
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            //base.OnStartup(e);

            PagesController pageController = new PagesController();
            pageController.CurrentPageViewModel = new BooksListViewModel();
            BasePageViewModel.PageController = pageController;
            MainWindow app = new MainWindow();
            app.DataContext = pageController;
            app.Show();
        }

    }
}
