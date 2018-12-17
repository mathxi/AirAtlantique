using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.ORM
{
    class crew
    {
        private int idcrew;
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }


        public int IdCrew
        {
            get { return idcrew; }
            set { idcrew = value; }
        }

        public static Modele.ORM.crew GetCrew(int id)
        {


            return Modele.DAL.Request.CrewRequest.getCrew(id);
        }
    }
}
