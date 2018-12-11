using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.DAL.Request
{
    class PiloteRequest
    {
        //Select statement
        public static Modele.ORM.pilote getPilote(int idPilote)


        {
            Modele.ORM.pilote Pilote = new Modele.ORM.pilote();
            string query = "SELECT * FROM pilote where idpilote=@pilote;";


            //Open connection
            ConnexionWorkBench connection = new ConnexionWorkBench();
            if (connection.OpenConnection() == true)

            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());

                //shield sql injection
                cmd.Parameters.AddWithValue("@pilote", idPilote);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    Pilote.Id_pilote = dataReader.GetInt32(0);
                    Pilote.Name = dataReader.GetString(1);
                    Pilote.Surname = dataReader.GetString(2);


                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                connection.CloseConnection();

                //return list to be displayed
                return Pilote;
            }
            else
            {
                return Pilote;
            }
        }
    }
}
