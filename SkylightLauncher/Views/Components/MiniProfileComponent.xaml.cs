using System.Windows;
using System.Windows.Controls;

namespace SkylightLauncher.Views.Components
{
    public partial class MiniProfileComponent : UserControl
    {



        public string PlayerName
        {
            get { return (string)GetValue(PlayerNameProperty); }
            set { SetValue(PlayerNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlayerName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlayerNameProperty =
            DependencyProperty.Register("PlayerName", typeof(string), typeof(MiniProfileComponent), new PropertyMetadata(string.Empty));



        public int HourPlayTime
        {
            get { return (int)GetValue(HourPlayTimeProperty); }
            set { SetValue(PlayerNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HourPlayTime.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HourPlayTimeProperty =
            DependencyProperty.Register("HourPlayTime", typeof(int), typeof(MiniProfileComponent), new PropertyMetadata(0));



        public int MinutesPlayTime
        {
            get { return (int)GetValue(MinutesPlayTimeProperty); }
            set { SetValue(MinutesPlayTimeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MinutesPlayTime.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinutesPlayTimeProperty =
            DependencyProperty.Register("MinutesPlayTime", typeof(int), typeof(MiniProfileComponent), new PropertyMetadata(0));



        public MiniProfileComponent()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
