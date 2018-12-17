using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
            Modele.ORM.warehouse Warehouse = new Modele.ORM.warehouse();
            string query = "SELECT * FROM type where id=@warehouse;";


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
                    Warehouse.IdWarehouse = dataReader.GetInt32(0);
                    Warehouse.Airport = Modele.ORM.airport.GetAirport(dataReader.GetInt32(1));
                    Warehouse.Name = dataReader.GetString(2);
                    Warehouse.Available = dataReader.GetBoolean(3);

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


    }
}
