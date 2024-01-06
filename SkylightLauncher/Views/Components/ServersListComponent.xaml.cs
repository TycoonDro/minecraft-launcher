using Accessibility;
using SkylightLauncher.Models;
using SkylightLauncher.Views.Components;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Логика взаимодействия для ServersListComponent.xaml
    /// </summary>
    public partial class ServersListComponent : UserControl
    {
        public ObservableCollection<IServer> ServersList
        {
            get { return (ObservableCollection<IServer>)GetValue(ServersListPropery); }
            set { SetValue(ServersListPropery, value); }
        }

        public static readonly DependencyProperty ServersListPropery =
            DependencyProperty.Register("ServersList", typeof(ObservableCollection<IServer>), typeof(ServersListComponent), new PropertyMetadata(null));

        public IServer SelectedServer
        {
            get { return (IServer)GetValue(SelectedServerPropery); }
            set { SetValue(SelectedServerPropery, value); }
        }

        public static readonly DependencyProperty SelectedServerPropery =
            DependencyProperty.Register("SelectedServer", typeof(IServer), typeof(ServersListComponent), new PropertyMetadata(null));
        public ServersListComponent()
        {
            InitializeComponent();
        }
    }
}
