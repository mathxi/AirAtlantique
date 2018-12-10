
using AirAtlantique.Modele.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.ORM
{
    class plane : INotifyPropertyChanged
    {
        private int idPlane;
        private string name;
        private string type;
        private int nb_Seat;
        private int id_Pilote;
        private int id_airport;





        public plane(int idplane, string name, string type, int nb_Seat, int id_Pilote, int id_airport)
        {
            this.idPlane = idplane;
            this.name = name;
            this.type = type;
            this.nb_Seat = nb_Seat;
            this.id_Pilote = id_Pilote;
            this.id_airport = id_airport;

        }

        public int IdPlane { get => idPlane; set => idPlane = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int Nb_Seat { get => nb_Seat; set => nb_Seat = value; }
        public int Id_Pilote { get => id_Pilote; set => id_Pilote = value; }
        public int Id_airport { get => id_airport; set => id_airport = value; }



        public static ObservableCollection<plane> getPlanes()
        {
            return Modele.DAO.DAOplanes.getplanes();
        }

        
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
                plane.updatePlane(this);
            }
        }

        private static void updatePlane(plane plane)
        {
            
        }
    }

}
