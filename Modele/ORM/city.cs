using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.ORM
{
    class city
    {
        private int idCity;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }





        public int IdCity
        {
            get { return idCity; }
            set { idCity = value; }
        }


        public static Modele.ORM.city GetCity(int id)
        {


            return Modele.DAL.Request.CityRequest.getCity(id);
        }

    }
}
