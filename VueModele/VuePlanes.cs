using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.VueModele
{
    class VuePlanes
    {

        ObservableCollection<Modele.ORM.plane> Planes;
        ObservableCollection<Modele.ORM.type> Types;
        ObservableCollection<Modele.ORM.warehouse> Warehouses;
        public VuePlanes()
        {
            Planes = new ObservableCollection<Modele.ORM.plane>();
            Planes = Modele.ORM.plane.getPlanes();
            Warehouses = new ObservableCollection<Modele.ORM.warehouse>();
            Warehouses = Modele.ORM.warehouse.getWarehouses();
            Types = new ObservableCollection<Modele.ORM.type>();
            Types = Modele.ORM.type.getTypes();

        }


        public void deletePlane(int idPlane)
        {
            Modele.ORM.plane.deletePlane(idPlane);
        }


        public ObservableCollection<Modele.ORM.plane> getPlanes()
        {
            Planes = Modele.ORM.plane.getPlanes();
            return Planes;
        }

        public ObservableCollection<Modele.ORM.type> GetTypes()
        {
            Types = Modele.ORM.type.getTypes();
            return Types;
        }
        public ObservableCollection<Modele.ORM.warehouse> GetWarehouses()
        {
            Warehouses = Modele.ORM.warehouse.getWarehouses();
            return Warehouses;
        }

        public void insertPlane(int type, int warehouse, bool Status)
        {
            AirAtlantique.Modele.DAL.Request.PlaneRequest.insertPlane(type, warehouse, Status);
        }
    }
}
