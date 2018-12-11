using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.ORM
{
    class pilote
    {
        private int id_Pilote;
        private string name;
        private string surname;


        public int Id_pilote
        {
            get { return id_Pilote; }
            set { id_Pilote = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public static Modele.ORM.pilote GetPilote(int id){


            return Modele.DAO.DAOpilote.GetPilote(id);
        }



    }
}
