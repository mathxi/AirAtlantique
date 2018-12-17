using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.DAL.Request
{
    class SalariedRequest
    {

        //Select statement
        public static Modele.ORM.type getCrew(int idCrew)


        {
            Modele.ORM.crew Crew = new Modele.ORM.crew();
            string query = "SELECT * FROM type where id=@crew;";


            //Open connection
            ConnexionWorkBench connection = new ConnexionWorkBench();
            if (connection.OpenConnection() == true)

            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());

                //shield sql injection
                cmd.Parameters.AddWithValue("@crew", idCrew);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    Crew.IdCrew = dataReader.GetInt32(0);
                    Crew.Salaried = dataReader.GetInt32(1);

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                connection.CloseConnection();

                //return list to be displayed
                return Type;
            }
            else
            {
                return Type;
            }
        }
        }
    }
}
