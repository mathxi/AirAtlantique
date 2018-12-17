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
        private Modele.ORM.salaried salaried;
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }


        public Modele.ORM.salaried Salaried
        {
            get { return salaried; }
            set { salaried = value; }
        }


        public int IdCrew
        {
            get { return idcrew; }
            set { idcrew = value; }
        }
    }
}
