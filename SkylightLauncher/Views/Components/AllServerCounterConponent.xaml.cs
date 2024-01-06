using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SkylightLauncher.Views.Components
{
    /// <summary>
    /// Логика взаимодействия для AllServerCounterConponent.xaml
    /// </summary>
    public partial class AllServerCounterConponent : UserControl
    {



        public int PlayerCount
        {
            get { return (int)GetValue(PlayerCountProperty); }
            set { SetValue(PlayerCountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlayerCount.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlayerCountProperty =
            DependencyProperty.Register("PlayerCount", typeof(int), typeof(AllServerCounterConponent), new PropertyMetadata(0));


        public AllServerCounterConponent()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
