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

namespace AirAtlantique
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new Vue.Home();
            
        }

        private void Button_page_home(object sender, RoutedEventArgs e)
        {
            Main.Content = new Vue.Home();
        }

        private void Button_page_planes(object sender, RoutedEventArgs e)
        {
            Main.Content = new Vue.Planes();
        }
        private void Button_page_flights(object sender, RoutedEventArgs e)
        {
            Main.Content = new Vue.Flights();
        }
    }
}
