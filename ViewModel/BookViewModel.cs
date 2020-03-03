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
        public RelayCommand CancelCommand { get; private set; }
        public BookViewModel()
        {
            CancelCommand = new RelayCommand(p => CancelAction(p), canExecuteMethod => true);
        }

        private void CancelAction(object param)
        {
            DialogResult dialogResult = MessageBox.Show("Chcesz wyjść nie zapisując zmian?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                PagesController.PageController.SetPageView(new BooksListViewModel());
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
