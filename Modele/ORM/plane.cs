
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
    class plane /*: INotifyPropertyChanged*/
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


        public Modele.ORM.crew Crew
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
            set { idPlane = value; /*OnPropertyChanged("idPlane"); */}
        }




        public plane( int idThisPlane, Modele.ORM.type thisType, Modele.ORM.crew thisCrew , Modele.ORM.warehouse thisWarehouse, bool thisStatus)
        {

            IdPlane = idThisPlane;
            Type = thisType;
            Crew = thisCrew;
            Warehouse = thisWarehouse;
            Status = thisStatus;

        }




        public static ObservableCollection<plane> getPlanes()
        {
            return Modele.DAL.Request.PlaneRequest.getPlanes();
        }
        public static void deletePlane(int idPlane)
        {
            Modele.DAL.Request.PlaneRequest.deletePlane(idPlane);
        }




        //public event PropertyChangedEventHandler PropertyChanged;

        //private void OnPropertyChanged(string info)
        //{
        //    PropertyChangedEventHandler handler = PropertyChanged;
        //    if (handler != null)
        //    {
        //        handler(this, new PropertyChangedEventArgs(info));
        //        Modele.DAO.DAOplanes.updatePlane(this);
        //    }
        //}


    }

}
