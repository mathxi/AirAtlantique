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
        public VueFlights()
        {
            Flights = new ObservableCollection<Modele.ORM.flight>();
            

        }


        //public void deletePlane(int idPlane)
        //{
        //    Modele.ORM.plane.deletePlane(idPlane);
        //}


        public ObservableCollection<Modele.ORM.flight> getFlights()
        {
            Flights = Modele.ORM.flight.getFlights();
            return Flights;
        }



    }
}
