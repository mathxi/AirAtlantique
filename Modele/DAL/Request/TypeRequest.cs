using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.DAL.Request
{
    class TypeRequest
    {

        //Select statement
        public static Modele.ORM.type getType(int idType)


        {
            Modele.ORM.type Type = new Modele.ORM.type();
            string query = "SELECT * FROM type where id=@type;";


            //Open connection
            ConnexionWorkBench connection = new ConnexionWorkBench();
            if (connection.OpenConnection() == true)

            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());

                //shield sql injection
                cmd.Parameters.AddWithValue("@type", idType);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    Type.IdType = dataReader.GetInt32(0);
                    Type.Name = dataReader.GetString(1);
                    Type.Motor = dataReader.GetString(2);
                    Type.NbSeatingPlaces = dataReader.GetInt32(4);
                    Type.NbEcoPlaces = dataReader.GetInt32(5);
                    Type.NbEcoPremPlaces = dataReader.GetInt32(6);
                    Type.NbBusinessPlaces = dataReader.GetInt32(7);
                    Type.NbPremierePlaces = dataReader.GetInt32(8);


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
