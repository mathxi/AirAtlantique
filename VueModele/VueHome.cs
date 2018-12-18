using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AirAtlantique.VueModele
{
    class VueHome
    {
        ObservableCollection<Modele.ORM.plane> Planes;
        ObservableCollection<Modele.ORM.type> Type;
        public VueHome()
        {
            Planes = new ObservableCollection<Modele.ORM.plane>();
            Planes = Modele.ORM.plane.getPlanes();       
        }
        public ObservableCollection<Modele.ORM.plane> getPlanes()
        {
            Planes = Modele.ORM.plane.getPlanes();
            return Planes;
        }
        public ObservableCollection<Modele.ORM.type> getTypes()
        {
            Type = Modele.ORM.type.getTypes();
            return Type;
        }

        public void deletePlane(int idPlane)
        {
            Modele.ORM.plane.deletePlane(idPlane);
        }

    }
}
