using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.DAL.Request
{
    class ClientRequest
    {


        public static Modele.ORM.client TryConnection(string coMail, string CoPassword)
        {
            Modele.ORM.client Client = null;
            string query = "SELECT * FROM clients where Mail=@Mail and Password=@Password;";


            //Open connection
            ConnexionWorkBench connection = new ConnexionWorkBench();
            if (connection.OpenConnection() == true)

            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());

                //shield injection
                cmd.Parameters.AddWithValue("@Mail", coMail);
                cmd.Parameters.AddWithValue("@Password", CoPassword);


                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    Client = new Modele.ORM.client(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetInt32(6), dataReader.GetString(7), dataReader.GetInt32(8));




                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                connection.CloseConnection();






            }
            return Client;



        }
    }
}
