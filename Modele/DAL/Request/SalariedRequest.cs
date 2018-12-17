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
        public static Modele.ORM.salaried getSalaried(int idSalaried)


        {
            Modele.ORM.salaried Salaried = new Modele.ORM.salaried();
            string query = "SELECT * FROM type where id=@idSalaried;";


            //Open connection
            ConnexionWorkBench connection = new ConnexionWorkBench();
            if (connection.OpenConnection() == true)

            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());

                //shield sql injection
                cmd.Parameters.AddWithValue("@idSalaried", idSalaried);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    Salaried.IdSalaried = dataReader.GetInt32(0);
                    Salaried.Crew = Modele.ORM.crew.GetCrew(dataReader.GetInt32(1));
                    Salaried.Name = dataReader.GetString(2);
                    Salaried.FirstName = dataReader.GetString(3);
                    Salaried.RegistrationNumber = dataReader.GetInt32(4);
                    Salaried.Availibility = dataReader.GetBoolean(5);
                    Salaried.DateBirth = dataReader.GetDateTime(6);
                    Salaried.DateHiring = dataReader.GetDateTime(7);

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                connection.CloseConnection();

                //return list to be displayed
                return Salaried;
            }
            else
            {
                return Salaried;
            }
        
        }
    }
}
