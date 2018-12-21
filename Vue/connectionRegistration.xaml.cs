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

namespace AirAtlantique.Vue
{
    /// <summary>
    /// Logique d'interaction pour connectionRegistration.xaml
    /// </summary>
    public partial class connectionRegistration : Page
    {
        VueModele.VueConnectionRegistration Vue;
        public connectionRegistration()
        {
            InitializeComponent();
            Vue = new VueModele.VueConnectionRegistration();


        }


        private void TryRegister(object sender, RoutedEventArgs e)
        {
            RegisterReturned.Text = "Vous êtes bien inscrit.";
            RegisterReturned.Foreground = new SolidColorBrush(Colors.Green);

        }



        private void Switch_Connection(object sender, RoutedEventArgs e)
        {
            this.ShowRegistration.Visibility = Visibility.Hidden;
            this.ShowConnection.Visibility = Visibility.Visible;
        }
        private void TryConnection(object sender, RoutedEventArgs e)
        {
            string coMail = idConnection.Text.ToString() ;
            string CoPassword = passwordConnection.Password.ToString();
            Modele.ORM.client Connected =  Vue.TryConnection(coMail, CoPassword);
            if(Connected == null)
            {
                ConnectionReturned.Text = "Erreur d'Email ou de Mot de passe";
                ConnectionReturned.Foreground = new SolidColorBrush(Colors.Red);

            }
            else
            {
                ConnectionReturned.Text = "Bienvenue "+ Connected.Name.ToString();
                ConnectionReturned.Foreground = new SolidColorBrush(Colors.Green);
            }
                
        }
        private void Switch_Registration(object sender, RoutedEventArgs e)
        {
            this.ShowConnection.Visibility = Visibility.Hidden;
            this.ShowRegistration.Visibility = Visibility.Visible;
        }

    }
}
