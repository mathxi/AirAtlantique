using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.ORM
{
    class airport
    {
        private int idAirport;
        private Modele.ORM.city city;
        private string name;
        private string codeAITA;

        public string CodeAITA
        {
            get { return codeAITA; }
            set { codeAITA = value; }
        }



        public string Name
        {
            get { return name; }
            set { name = value; }
        }




        public Modele.ORM.city City
        {
            get { return city; }
            set { city = value; }
        }




        public int IdAirport
        {
            get { return idAirport; }
            set { idAirport = value; }
        }


        public static Modele.ORM.airport GetAirport(int id)
        {


            return Modele.DAL.Request.AirportRequest.getAirport(id);
        }


    }
}
