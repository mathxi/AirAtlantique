using AirAtlantique.Modele.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.DAL.Request
{
    class PlaneRequest
    {

        //Select statement
        public ObservableCollection<Modele.ORM.plane> getPlanes()


        {
            ObservableCollection<Modele.ORM.plane> Planes = new ObservableCollection<Modele.ORM.plane>();
            string query = "SELECT * FROM plane;";


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
                    Modele.ORM.plane plane = new Modele.ORM.plane(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetInt32(3), dataReader.GetInt32(4), dataReader.GetInt32(5));
                    Planes.Add(plane);

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                connection.CloseConnection();

                //return list to be displayed
                return Planes;
            }
            else
            {
                return Planes;
            }
        }

        public static void updatePlane(Modele.ORM.plane Plane)
        {
            string query = "UPDATE plane SET Name = @name, Type = @typePlane, nb_Seat= @nb_Seat WHERE idPlane = @idPlane";
            

            //Open connection
            ConnexionWorkBench connection = new ConnexionWorkBench();
            if (connection.OpenConnection() == true)

            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());

                //shield injection
                cmd.Parameters.AddWithValue("@idPlane", Plane.IdPlane);
                cmd.Parameters.AddWithValue("@name", Plane.Name);
                cmd.Parameters.AddWithValue("@typePlane", Plane.Type);
                cmd.Parameters.AddWithValue("@nb_Seat", Plane.Nb_Seat);


                //Execute the command
                cmd.ExecuteNonQuery();


                //close Connection
                connection.CloseConnection();
            }


        }
    }
}
