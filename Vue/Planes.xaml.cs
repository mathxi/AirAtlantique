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
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace AirAtlantique.Vue
{
    /// <summary>
    /// Logique d'interaction pour Planes.xaml
    /// </summary>
    public partial class Planes : Page
    {
        VueModele.VueHome vue;
        public Planes()
        {

            InitializeComponent();
            vue = new VueModele.VueHome();

            gridPlanes.ItemsSource = vue.getPlanes();
            PlaneType.ItemsSource = vue.GetTypes();
            PlaneWarehouse.ItemsSource = vue.GetWarehouses();
        }

        private void AddFlyModalClick(object sender,RoutedEventArgs e)
        {
            this.ModalAddPlane.Visibility = Visibility.Visible;
        }
        private void deletePlane(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int idplane = (int)button.Tag;
            vue.deletePlane(idplane);
            gridPlanes.ItemsSource = vue.getPlanes();

        }


        private void ReturnPlaneListClick(object sender, RoutedEventArgs e)
        {
            this.ModalAddPlane.Visibility = Visibility.Collapsed;
        }

        private void InsertPlaneClick(object sender, RoutedEventArgs e)
        {
            //AirAtlantique.Modele.ORM.plane plane = new Modele.ORM.plane(Convert.ToInt32(Id.Text), Types.DefaultBinder, Crew.Text, Warehouse.Text, Status.Text);
            //AirAtlantique.Modele.DAL.Request.PlaneRequest.insertPlane();
        }
    }
    
}
