using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolodziejski.RatingApp.ViewModel
{
    public class BooksListViewModel : BaseViewModel
    {
        private RelayCommand _addBookCommand;

        public BooksListViewModel()
        {
            _addBookCommand = new RelayCommand(OnAddBook);
        }

        public RelayCommand AddBookCommand
        {
            get { return _addBookCommand; }
        }

        private void OnAddBook(object args)
        {
            ViewsMediator.ChangeView(1);
        }
    }
}
