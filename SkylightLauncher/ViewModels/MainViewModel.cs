using MvvmCross.ViewModels;
using SkylightLauncher.Views.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SkylightLauncher.ViewModels
{
    public class MainViewModel : MvxViewModel
    {

        private Page _dashboardPage = new DashboardPage();

        #region Текущая страница
        private Page _currentPage;
        public Page ContentPage
        {
            get => _currentPage;
            set => SetProperty(ref _currentPage, value);

        }
        #endregion

        public MainViewModel()
        {
            ContentPage = _dashboardPage;
        }
    }
}
