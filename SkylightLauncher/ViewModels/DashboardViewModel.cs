using MvvmCross.ViewModels;
using SkylightLauncher.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace SkylightLauncher.ViewModels
{
    public class DashboardViewModel : MvxViewModel
    {

        #region Текущая страница
        private ObservableCollection<IServer> _serversList = new ObservableCollection<IServer>();

        public ObservableCollection<IServer> ServersList
        {
            get => _serversList;
            set => SetProperty(ref _serversList, value);
        }
        #endregion
        public DashboardViewModel()
        {
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@"C:\Users\user\source\repos\SkylightLauncher\SkylightLauncher\Views\Resources\Images\default.png");
            bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
            bitmapImage.EndInit();
            
            ServersList.Add(new Server
            {
                Name = "Кубач",
                Image = bitmapImage
            });
            ServersList.Add(new Server
            {
                Name = "Кубач",
                Image = bitmapImage
            });
            ServersList.Add(new Server
            {
                Name = "Кубач",
                Image = bitmapImage
            });
            ServersList.Add(new Server
            {
                Name = "Кубач",
                Image = bitmapImage
            });
            ServersList.Add(new Server
            {
                Name = "Кубач",
                Image = bitmapImage
            });
        }
    }
}
