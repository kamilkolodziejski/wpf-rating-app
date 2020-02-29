using Kolodziejski.RatingApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Kolodziejski.RatingApp.Application
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow app = new MainWindow();
            MainViewModel context = new MainViewModel();
            //ViewsMediator.ParentViewModel = context;

            app.DataContext = context;
            app.Show();
        }

    }
}
