using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.DAL.Request
{
    class HomeRequest
    {

        //Select statement
        public static int howMuchFlights(string date)


        {
            
            string query = "SELECT count(*) FROM flight WHERE @date BETWEEN Hours_Departure AND Hours_Arrival;";

            int countFlightTD = 0;
            //Open connection
            ConnexionWorkBench connection = new ConnexionWorkBench();
            if (connection.OpenConnection() == true)

            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());
                cmd.Parameters.AddWithValue("@date", date);



                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    countFlightTD = dataReader.GetInt32(0);

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                connection.CloseConnection();

                //return list to be displayed
                return countFlightTD;
            }
            else
            {
                return countFlightTD;
            }
        }





    }
}
