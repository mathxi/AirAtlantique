using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.DAL.Request
{
    class WarehouseRequest
    {

        //Select statement
        public static Modele.ORM.warehouse getWarehouse(int idWarehouse)


        {
            Modele.ORM.warehouse Warehouse = null;
            string query = "SELECT * FROM warehouse where id=@warehouse;";


            //Open connection
            ConnexionWorkBench connection = new ConnexionWorkBench();
            if (connection.OpenConnection() == true)

            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());

                //shield sql injection
                cmd.Parameters.AddWithValue("@warehouse", idWarehouse);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    Warehouse = new Modele.ORM.warehouse(
                         dataReader.GetInt32(0),
                         Modele.ORM.airport.GetAirport(dataReader.GetInt32(1)),
                         dataReader.GetString(2),
                        dataReader.GetBoolean(3)
                    );


                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                connection.CloseConnection();

                //return list to be displayed
                return Warehouse;
            }
            else
            {
                return Warehouse;
            }
        }


        //Select statement
        public static ObservableCollection<Modele.ORM.warehouse> getWarehouses()


        {
            Modele.ORM.warehouse Warehouse = null;
            ObservableCollection<Modele.ORM.warehouse> Warehouses = new ObservableCollection<Modele.ORM.warehouse>();
            string query = "SELECT id,name FROM warehouse;";


            //Open connection
            ConnexionWorkBench connection = new ConnexionWorkBench();
            if (connection.OpenConnection() == true)

            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());


                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    Warehouse = new Modele.ORM.warehouse(
                        dataReader.GetInt32(0),
                        dataReader.GetString(1)
                       );
                    Warehouses.Add(Warehouse);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                connection.CloseConnection();

                //return list to be displayed
                return Warehouses;
            }
            else
            {
                return Warehouses;
            }
        }

        


    }
}
