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
        ObservableCollection<Modele.ORM.type> Types;
        public VueHome()
        {
            Planes = new ObservableCollection<Modele.ORM.plane>();
            Planes = Modele.ORM.plane.getPlanes();
            Types = new ObservableCollection<Modele.ORM.type>();
            Types = Modele.ORM.type.GetType();
        }
        public ObservableCollection<Modele.ORM.plane> getPlanes()
        {
            return Planes;
        }

        public ObservableCollection<Modele.ORM.type> GetTypes()
        {
            return Types;
        }

    }
}
