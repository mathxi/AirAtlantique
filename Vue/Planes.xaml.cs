using AirAtlantique.Modele;
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
using AirAtlantique.Modele;
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace AirAtlantique.Vue
{
    /// <summary>
    /// Logique d'interaction pour Planes.xaml
    /// </summary>
    public partial class Planes : Page
    {
        public Planes()
        {
            InitializeComponent();
            VueModele.VueHome vue = new VueModele.VueHome();

            gridPlanes.ItemsSource = vue.getPlanes();



        }
        private void Data_changed(object sender, SelectionChangedEventArgs e)
        {

        }



    }
    
}
