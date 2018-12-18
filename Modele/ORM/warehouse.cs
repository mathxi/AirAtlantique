using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.ORM
{
    class warehouse
    {
        private int idWarehouse;
        private Modele.ORM.airport airport;
        private string name;
        private bool available;

        public warehouse(int thisidWarehouse,string thisname)
        {
            IdWarehouse = thisidWarehouse;
            Name = thisname;
        }
        public warehouse(int thisidWarehouse, Modele.ORM.airport airport , string thisname,bool thisavailable)
        {
            IdWarehouse = thisidWarehouse;
            Airport = airport;
            Name = thisname;
            available = thisavailable;

        }

        public bool Available
        {
            get { return available; }
            set { available = value; }
        }




        public string Name
        {
            get { return name; }
            set { name = value; }
        }



        public Modele.ORM.airport Airport
        {
            get { return airport; }
            set { airport = value; }
        }




        public int IdWarehouse
        {
            get { return idWarehouse; }
            set { idWarehouse = value; }
        }





        public static Modele.ORM.warehouse GetWarehouse(int id)
        {


            return Modele.DAL.Request.WarehouseRequest.getWarehouse(id);
        }


        public static ObservableCollection<Modele.ORM.warehouse> getWarehouses()
        {


            return Modele.DAL.Request.WarehouseRequest.getWarehouses();
        }
        




    }
}
