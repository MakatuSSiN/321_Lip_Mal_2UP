using _321_Lip_Mal_2UP.utility;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _321_Lip_Mal_2UP.viewModel
{
    public class Navigation : MainViewModel
    {
        // текущая страница
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                if (_currentView != value)
                {
                    _currentView = value;
                    OnPropertyChanged();
                }
            }
        }
        public Navigation()
        {
            // установка стартовой страницы партнеры
            _currentView = new PartnersVM(this);
        }
    }
}
