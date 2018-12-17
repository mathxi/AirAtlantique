
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
        private Modele.ORM.type type;
        private Modele.ORM.crew crew;
        private Modele.ORM.warehouse warehouse;
        private bool status;




        public bool Status
        {
            get { return status; }
            set { status = value; }
        }



        public Modele.ORM.warehouse Warehouse
        {
            get { return warehouse; }
            set { warehouse = value; }
        }


        public int Crew
        {
            get { return crew; }
            set { crew = value; }
        }



        public Modele.ORM.type Type
        {
            get { return type; }
            set { type = value; }
        }






        public int IdPlane
        {
            get { return idPlane; }
            set { idPlane = value; OnPropertyChanged("idPlane"); }
        }




        public plane(int idplane, string name, string type, int nb_Seat, Modele.ORM.pilote id_Pilote, int id_airport)
        {
            //this.IdPlane = idplane;
            //this.Name = name;
            //this.Type = type;
            //this.Nb_Seat = nb_Seat;
            //this.Id_Pilote = id_Pilote;
            //this.Id_airport = id_airport;

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
