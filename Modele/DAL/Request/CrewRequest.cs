using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.DAL.Request
{
    class CrewRequest
    {

        //Select statement
        public static Modele.ORM.crew getCrew(int idCrew)


        {
            Modele.ORM.crew Crew = null;
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

                    Crew = new Modele.ORM.crew(
                        dataReader.GetInt32(0),
                        dataReader.GetInt32(1)
                        );
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                connection.CloseConnection();

                //return list to be displayed
                return Crew;
            }
            else
            {
                return Crew;
            }


        }
        public static ObservableCollection<Modele.ORM.crew> getCrews()


        {
            ObservableCollection<Modele.ORM.crew> Crews = null;
            Modele.ORM.crew Crew;
            string query = "SELECT * FROM crew;";


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

                    dataReader.GetInt32(0);
                    dataReader.GetInt32(1);

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                connection.CloseConnection();

                //return list to be displayed
                return Crews;
            }
            else
            {
                return Crews;
            }
        }


    }


}
