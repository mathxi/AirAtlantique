using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AirAtlantique.VueModele
{
    class VueHome
    {
        ObservableCollection<Modele.ORM.plane> Planes;
        public VueHome()
        {
            Planes = new ObservableCollection<Modele.ORM.plane>();
            Planes = Modele.ORM.plane.getPlanes();       
        }
        public ObservableCollection<Modele.ORM.plane> getPlanes()
        {
            return Planes;
        }

    }
}
