
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
        private Modele.ORM.pilote id_pilote;
        private int id_airport;



        public int IdPlane
        {
            get { return idPlane; }
            set { idPlane = value; OnPropertyChanged("idPlane"); }
        }


        public int Id_airport
        {
            get { return id_airport; }
            set { id_airport = value; OnPropertyChanged("id_airport"); }
        }



        public Modele.ORM.pilote Id_Pilote
        {
            get { return id_pilote; }
            set { id_pilote = value; OnPropertyChanged("id_pilote"); }
        }


        public int Nb_Seat
        {
            get { return nb_Seat; }
            set { nb_Seat = value; OnPropertyChanged("nb_Seat"); }
        }



        public string Type
        {
            get { return type; }
            set { type = value; OnPropertyChanged("type"); }
        }


        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("name"); }
        }




        public plane(int idplane, string name, string type, int nb_Seat, Modele.ORM.pilote id_Pilote, int id_airport)
        {
            this.IdPlane = idplane;
            this.Name = name;
            this.Type = type;
            this.Nb_Seat = nb_Seat;
            this.Id_Pilote = id_Pilote;
            this.Id_airport = id_airport;

        }

       



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
                Modele.DAO.DAOplanes.updatePlane(this);
            }
        }


    }

}
