using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.DAL.Request
{
    class AirportRequest
    {

        //Select statement
        public static Modele.ORM.airport getAirport(int idAirport)


        {
            Modele.ORM.airport Airport = new Modele.ORM.airport();
            string query = "SELECT * FROM airport where id=@airport;";


            //Open connection
            ConnexionWorkBench connection = new ConnexionWorkBench();
            if (connection.OpenConnection() == true)

            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());

                //shield sql injection
                cmd.Parameters.AddWithValue("@airport", idAirport);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    Airport.IdAirport = dataReader.GetInt32(0);
                    Airport.City = Modele.ORM.city.GetCity(dataReader.GetInt32(1));
                    Airport.Name = dataReader.GetString(2);
                    Airport.CodeAITA = dataReader.GetString(3);


                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                connection.CloseConnection();

                //return list to be displayed
                return Airport;
            }
            else
            {
                return Airport;
            }
        }

    }
}
