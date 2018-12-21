using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AirAtlantique.Modele.DAL.Request
{
    class FlightRequest
    {


        //Select statement
        public static ObservableCollection<Modele.ORM.flight> getFlights()
        {
            ObservableCollection<Modele.ORM.flight> Flights = new ObservableCollection<Modele.ORM.flight>();
            string query = "SELECT * FROM flight;";


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
                    int idvol = dataReader.GetInt32(0);
                    Modele.ORM.plane Plane = Modele.ORM.plane.getPlane(dataReader.GetInt32(1));
                    int freePlaces = dataReader.GetInt32(2);
                    DateTime hoursDeparture = dataReader.GetDateTime(3);
                    DateTime hoursArrival = dataReader.GetDateTime(3);



                    Modele.ORM.flight Flight = new Modele.ORM.flight(idvol,Plane,freePlaces,hoursDeparture,hoursArrival);
                    Flights.Add(Flight);

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                connection.CloseConnection();

                //return list to be displayed
                return Flights;
            }
            else
            {
                return Flights;
            }
        }


        //Select statement
        public static void insertFlight(Modele.ORM.plane APlane, string longdatetimeD, string longdatetimeA)
        {
            int seat = APlane.Type.NbSeatingPlaces;
            int idPlane = APlane.IdPlane;
            //Open connection
            ConnexionWorkBench connection = new ConnexionWorkBench();
            if (connection.OpenConnection() == true)
            {

                string query = "INSERT INTO flight ( id_Plane, Available_Places, Hours_Departure,Hours_Arrival)" +
                               " VALUES( @idPlane,@seat, @HoursD,@HoursA)";
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());

                //shield injection
                cmd.Parameters.AddWithValue("@seat", seat);
                cmd.Parameters.AddWithValue("@idPlane", idPlane);
                cmd.Parameters.AddWithValue("@HoursD", longdatetimeD);
                cmd.Parameters.AddWithValue("@HoursA", longdatetimeA);

                //Execute the command
                cmd.ExecuteNonQuery();


                //close Connection
                connection.CloseConnection();
            }
            else
            {
                MessageBox.Show("Connexion failed !");
            }
        }





        public static void updateFligt(Modele.ORM.flight Filght)
        {

            string query = "UPDATE flight SET Available_Places = @places WHERE id=@id";


            //Open connection
            ConnexionWorkBench connection = new ConnexionWorkBench();
            if (connection.OpenConnection() == true)

            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());


                cmd.Parameters.AddWithValue("@id", Filght.Id);
                cmd.Parameters.AddWithValue("@places", Filght.AvailablePlaces);
                //Create a data reader and Execute the command
                cmd.ExecuteNonQuery();


                //close Connection
                connection.CloseConnection();




            }


        }



        public static void deleteFlight(int idFlight)
        {
            string query = "DELETE FROM `flight` WHERE id=@idflight";


            //Open connection
            ConnexionWorkBench connection = new ConnexionWorkBench();
            if (connection.OpenConnection() == true)

            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());
                cmd.Parameters.AddWithValue("@idflight", idFlight);
                cmd.ExecuteNonQuery();

                //close Connection
                connection.CloseConnection();

            }
        }


    }
}
