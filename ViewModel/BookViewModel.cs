using Kolodziejski.RatingApp.Interfaces.Domain;
using Kolodziejski.RatingApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolodziejski.RatingApp.ViewModel
{
    public class BookViewModel : BasePageViewModel
    {
        public RelayCommand SaveChangesCommand { get; private set; }
        public RelayCommand RejectChangesCommand { get; private set; }
        public BookViewModel() : base()
        {
            SaveChangesCommand = new RelayCommand(CancelAction);
            RejectChangesCommand = new RelayCommand(CancelAction);
        }


        private IBook _activeBook;
        public IBook ActiveBook
        {
            get => _activeBook;
            set => SetValue(ref _activeBook, value);
        }

        private void CancelAction(object param) =>
            PagesControllerFactory.INSTANCE.SetPageView(new BooksListViewModel(), 400, 600);


        //DialogResult dialogResult = MessageBox.Show("Chcesz wyjść nie zapisując zmian?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        //if (dialogResult == DialogResult.Yes)
        //{
        //    PagesControllerFactory.INSTANCE.SetPageView(new BooksListViewModel());
        //}
        //else if (dialogResult == DialogResult.No)
        //{
        //    return;
    }
}
