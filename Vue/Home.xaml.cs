using System;
using System.Windows;
using System.Windows.Controls;
using AirAtlantique.Vue.Design;

namespace AirAtlantique.Vue
{
    /// <summary>
    /// Logique d'interaction pour Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        DateTime? selectedDate;

        public Home()
        {
            InitializeComponent();
            var lang = System.Windows.Markup.XmlLanguage.GetLanguage("fr");
            Date.Language = lang;



        }


        private void getDate(object sender, RoutedEventArgs e)
        {
            selectedDate = Date.SelectedDate;
            //SelectedTime.Text = "Time: " + Hour.SelectedTime.Value.ToString("hh:mm");
            string longdatetime = selectedDate.Value.ToString("yyyy/MM/dd") + " " + Hour.SelectedTime.Value.ToShortTimeString()  ;


            //DateTime Selected = DateTime.ParseExact(longdatetime, "yyyy/MM/dd mm:hh",
            //                          System.Globalization.CultureInfo.InvariantCulture);
            SelectedDateTime.Text ="Nombre de vol ce jour: " + Modele.DAL.Request.HomeRequest.howMuchFlights(longdatetime).ToString();
        }


    }





}


