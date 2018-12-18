using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            Modele.ORM.type Type=null;
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
                    Type = new Modele.ORM.type(
                    dataReader.GetInt32(0),
                    dataReader.GetString(1),
                    dataReader.GetString(2),
                    dataReader.GetInt32(3),
                    dataReader.GetInt32(4),
                    dataReader.GetInt32(5),
                    dataReader.GetInt32(6),
                    dataReader.GetInt32(7)
                    );

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


        public static ObservableCollection<Modele.ORM.type> getTypes()


        {
            ObservableCollection<Modele.ORM.type> Types = new ObservableCollection<Modele.ORM.type>();
            string query = "SELECT * FROM type;";


            //Open connection
            ConnexionWorkBench connection = new ConnexionWorkBench();
            if (connection.OpenConnection() == true)

            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());       

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                Modele.ORM.type Type;
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    Type = new Modele.ORM.type(
                    dataReader.GetInt32(0),
                    dataReader.GetString(1),
                    dataReader.GetString(2),
                    dataReader.GetInt32(3),
                    dataReader.GetInt32(4),
                    dataReader.GetInt32(5),
                    dataReader.GetInt32(6),
                    dataReader.GetInt32(7)
                    );
                    Types.Add(Type);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                connection.CloseConnection();

                //return list to be displayed
                return Types;
            }
            else
            {
                return Types;
            }
        }

    }
}
