using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.VueModele
{
    class VueConnectionRegistration
    {




        public Modele.ORM.client TryConnection(string coMail, string CoPassword)
        {
            return Modele.ORM.client.TryConnection(coMail, CoPassword);
        }


    }


}
