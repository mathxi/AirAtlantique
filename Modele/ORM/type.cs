using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.ORM
{
    class type
    {
        private int idType;
        private string name;
        private string motor;
        private int nbSeatingPlaces;
        private int nbEcoPlaces;
        private int nbEcoPremPlaces;
        private int nbBusinessPlaces;
        private int nbPremierePlaces;









        public int NbPremierePlaces
        {
            get { return nbPremierePlaces; }
            set { nbPremierePlaces = value; }
        }




        public int NbBusinessPlaces
        {
            get { return nbBusinessPlaces; }
            set { nbBusinessPlaces = value; }
        }




        public int NbEcoPremPlaces
        {
            get { return nbEcoPremPlaces; }
            set { nbEcoPremPlaces = value; }
        }




        public int NbEcoPlaces
        {
            get { return nbEcoPlaces; }
            set { nbEcoPlaces = value; }
        }



        public int NbSeatingPlaces
        {
            get { return nbSeatingPlaces; }
            set { nbSeatingPlaces = value; }
        }


        public string Motor
        {
            get { return motor; }
            set { motor = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int IdType
        {
            get { return idType; }
            set { idType = value; }
        }

    }
}
