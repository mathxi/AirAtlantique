using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace AirAtlantique.Vue
{
    /// <summary>
    /// Logique d'interaction pour Flights.xaml
    /// </summary>
    public partial class Flights : Page
    {
        VueModele.VueFlights vue;

        public Flights()
        {
            InitializeComponent();
            vue = new VueModele.VueFlights();
            gridFlights.ItemsSource = vue.getFlights();
            var lang = System.Windows.Markup.XmlLanguage.GetLanguage("fr");
            DateD.Language = lang;
            DateA.Language = lang;
            Plane.ItemsSource = vue.getPlanes();

        }



        private void deleteFlight(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int idFlight = (int)button.Tag;
            vue.deleteFlight(idFlight);
            gridFlights.ItemsSource = vue.getFlights();
            
        }

        private void InsertFlightClick(object sender, RoutedEventArgs e)
        {
            string longdatetimeD = DateD.SelectedDate.Value.ToString("yyyy/MM/dd") + " " + HourD.SelectedTime.Value.ToShortTimeString();
            string longdatetimeA = DateA.SelectedDate.Value.ToString("yyyy/MM/dd") + " " + HourA.SelectedTime.Value.ToShortTimeString();
            Modele.ORM.plane APlane = Plane.SelectedItem as Modele.ORM.plane;
            //test récupération valeur
            //MessageBox.Show("L'avion : "+APlane.IdPlane.ToString()+" a une date de départ = " + longdatetimeA + " Date arrivé = "+ longdatetimeA);
            vue.insertFlight(APlane, longdatetimeD, longdatetimeA);
            gridFlights.ItemsSource = vue.getFlights();
            this.ModalAddFlight.Visibility = Visibility.Collapsed;

        }


        private void AddFlyModalClick(object sender, RoutedEventArgs e)
        {
            this.ModalAddFlight.Visibility = Visibility.Visible;

        }

        private void ReturnFlightListClick(object sender, RoutedEventArgs e)
        {
            this.ModalAddFlight.Visibility = Visibility.Collapsed;
        }


        private void Data_changed(object sender, SelectionChangedEventArgs e)
        {

        }


    }
}
