using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.DAO
{
    class DAOpilote
    {
        public static Modele.ORM.pilote GetPilote(int id)
        {
           return Modele.DAL.Request.PiloteRequest.getPilote(id);
        }
    }
}
