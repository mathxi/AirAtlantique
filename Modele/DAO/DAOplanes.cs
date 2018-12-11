using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.DAO
{
    class DAOplanes
    {
        static private ObservableCollection<Modele.ORM.plane> Planes;


        static public ObservableCollection<Modele.ORM.plane>  getplanes()
        {
            Planes = new ObservableCollection<Modele.ORM.plane>();
            Modele.DAL.Request.PlaneRequest request = new Modele.DAL.Request.PlaneRequest();
            Planes = request.getPlanes();
            return Planes;
        }

        public static void updatePlane(Modele.ORM.plane Plane)
        {
            Modele.DAL.Request.PlaneRequest.updatePlane(Plane);
        }


    }
}
