using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.ORM
{
    class crew
    {
        private int idcrew;
        private int number;

        public crew(int ThisIdCrew, int ThisNumber)
        {
            IdCrew = ThisIdCrew;
            Number = ThisNumber;
        }

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

        public static ObservableCollection<crew> getCrew()
        {
            return Modele.DAL.Request.CrewRequest.getCrews();
        }
    }
}
