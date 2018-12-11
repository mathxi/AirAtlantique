using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using plane= AirAtlantique.Modele.ORM.plane;

namespace AirAtlantique.Vue
{
    /// <summary>
    /// Logique d'interaction pour Home.xaml
    /// </summary>
    public partial class Home : Page
    {

        public Home()
        {
            InitializeComponent();
            VueModele.VueHome vue = new VueModele.VueHome();
            ObservableCollection<Modele.ORM.plane> planes  = vue.getPlanes();



            gridPlanes.ItemsSource = planes;
           // gridPlanes.DataContextChanged;


        }
        private void Data_changed(object sender, SelectionChangedEventArgs e)
        {
           
        }
    }


}
