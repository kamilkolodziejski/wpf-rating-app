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
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IPagesViewModel, PagesViewModel>();
            container.RegisterType<IPagesManager, PagesManager>();

            var pagesModel = container.Resolve<IPagesViewModel>();

            var pagesManager = container.Resolve<IPagesManager>();

            base.OnStartup(e);
            var app = new MainWindow();


            app.Show();
        }

    }
}
