using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.VueModele
{
    class VueFlights
    {

        ObservableCollection<Modele.ORM.flight> Flights;
        ObservableCollection<Modele.ORM.type> Types;
        ObservableCollection<Modele.ORM.plane> Planes;
        public VueFlights()
        {
            Planes = new ObservableCollection<Modele.ORM.plane>();
            Flights = new ObservableCollection<Modele.ORM.flight>();
            Types = new ObservableCollection<Modele.ORM.type>();

        }


        //public void deletePlane(int idPlane)
        //{
        //    Modele.ORM.plane.deletePlane(idPlane);
        //}
        public void insertFlight(Modele.ORM.plane APlane, string longdatetimeD, string longdatetimeA)
        {
            Modele.ORM.flight.insertFlight(APlane, longdatetimeD, longdatetimeA);
        }

        public ObservableCollection<Modele.ORM.plane> getPlanes()
        {
            Planes = Modele.ORM.plane.getPlanes();
            return Planes;
        }




        public ObservableCollection<Modele.ORM.type> GetTypes()
        {
            Types = Modele.ORM.type.getTypes();
            return Types;
        }

        public ObservableCollection<Modele.ORM.flight> getFlights()
        {
            Flights = Modele.ORM.flight.getFlights();
            return Flights;
        }
        

        public void deleteFlight(int idFlight)
        {
            Modele.ORM.flight.deleteFlight(idFlight);
        }

    }
}
