using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.ORM
{
    class flight
    {
        private int id;
        private Modele.ORM.plane plane;
        private int availablePlaces;
        private DateTime hoursDeparture;
        private DateTime hoursArrival;


        public flight( int thisId, Modele.ORM.plane thisPlane, int thisAvailablePlaces, DateTime thisHoursDeparture, DateTime thisHoursArrival)
        {
            Id = thisId;
            Plane = thisPlane;
            AvailablePlaces = thisAvailablePlaces;
            HoursDeparture = thisHoursDeparture;
            HoursArrival = thisHoursArrival;


        }


        public DateTime HoursArrival
        {
            get { return hoursArrival; }
            set { hoursArrival = value; }
        }




        public DateTime HoursDeparture
        {
            get { return hoursDeparture; }
            set { hoursDeparture = value; }
        }







        public int AvailablePlaces
        {
            get { return availablePlaces; }
            set { availablePlaces = value; }
        }





        public Modele.ORM.plane Plane
        {
            get { return plane; }
            set { plane = value; }
        }



        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public static ObservableCollection<flight> getFlights()
        {

            return Modele.DAL.Request.FlightRequest.getFlights();
        }

    }
}
