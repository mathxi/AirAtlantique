using System.Windows.Controls;
using AirAtlantique.Vue.Design;

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


            //Add item to ComboBox:
            ListPilote.Items.Add(new Design.ComboBoxItem("DisplayValue", "HiddenValue"));
            ListPilote.Items.Add(new Design.ComboBoxItem("Bruhhh", "HiddenValue"));
            ListPilote.Items.Add(new Design.ComboBoxItem("Weshhh", "HiddenValue"));

            //Get hidden value of selected item:
            //string hValue = ((Design.ComboBoxItem)ListPilote.SelectedItem).HiddenValue;


        }


    }





}


