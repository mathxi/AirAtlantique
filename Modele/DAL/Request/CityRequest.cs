using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.DAL.Request
{
    class CityRequest
    {

        //Select statement
        public static Modele.ORM.city getCity(int idCity)


        {
            Modele.ORM.city City = new Modele.ORM.city();
            string query = "SELECT * FROM city where id=@city;";


            //Open connection
            ConnexionWorkBench connection = new ConnexionWorkBench();
            if (connection.OpenConnection() == true)

            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());

                //shield sql injection
                cmd.Parameters.AddWithValue("@city", idCity);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    City.IdCity = dataReader.GetInt32(0);
                    City.Name = dataReader.GetString(1);


                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                connection.CloseConnection();

                //return list to be displayed
                return City;
            }
            else
            {
                return City;
            }
        }


    }
}
