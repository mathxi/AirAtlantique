using AirAtlantique.Modele.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AirAtlantique.Modele.DAL.Request
{
    class PlaneRequest
    {

        //Select statement
        public static ObservableCollection<Modele.ORM.plane> getPlanes()


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
                    int idplane = dataReader.GetInt32(0);
                    Modele.ORM.type Type = Modele.ORM.type.GetType(dataReader.GetInt32(1));
                    Modele.ORM.crew Crew;
                    if (dataReader[2] != DBNull.Value)
                    {
                         Crew = Modele.ORM.crew.GetCrew(dataReader.GetInt32(2));
                    }
                    else
                    {
                        Crew = null;
                    }
                    
                    Modele.ORM.warehouse Warehouse = Modele.ORM.warehouse.GetWarehouse(dataReader.GetInt32(3));
                    bool status = dataReader.GetBoolean(4);



                    Modele.ORM.plane Plane = new Modele.ORM.plane(idplane,Type,Crew,Warehouse,status);
                    Planes.Add(Plane);

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
        
        
        //Select statement
        public static Modele.ORM.plane getPlane(int id)


        {

            Modele.ORM.plane Plane = null;
            string query = "SELECT * FROM plane where id=@id;";


            //Open connection
            ConnexionWorkBench connection = new ConnexionWorkBench();
            if (connection.OpenConnection() == true)

            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());

                //shield injection
                cmd.Parameters.AddWithValue("@id", id);


                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    int idplane = dataReader.GetInt32(0);
                    Modele.ORM.type Type = Modele.ORM.type.GetType(dataReader.GetInt32(1));
                    Modele.ORM.crew Crew;
                    if (dataReader[2] != DBNull.Value)
                    {
                         Crew = Modele.ORM.crew.GetCrew(dataReader.GetInt32(2));
                    }
                    else
                    {
                        Crew = null;
                    }
                    
                    Modele.ORM.warehouse Warehouse = Modele.ORM.warehouse.GetWarehouse(dataReader.GetInt32(3));
                    bool status = dataReader.GetBoolean(4);



                    Plane = new Modele.ORM.plane(idplane,Type,Crew,Warehouse,status);

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                connection.CloseConnection();

                //return list to be displayed
                return Plane;
            }
            else
            {
                return Plane;
            }
        }

        //public static void updatePlane(Modele.ORM.plane Plane)
        //{


        //    //Open connection
        //    ConnexionWorkBench connection = new ConnexionWorkBench();
        //    if (connection.OpenConnection() == true)
        //    {

        //        string query = "UPDATE plane SET Name=@name, Type=@typePlane, nb_Seat=@nb_Seat WHERE idPlane=@idPlane";
        //        //Create Command
        //        MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());

        //        //shield injection
        //        cmd.Parameters.AddWithValue("@idPlane", Plane.IdPlane);
        //        cmd.Parameters.AddWithValue("@name", Plane.Name);
        //        cmd.Parameters.AddWithValue("@typePlane", Plane.Type);
        //        cmd.Parameters.AddWithValue("@nb_Seat", Plane.Nb_Seat);

        //        //Execute the command
        //        cmd.ExecuteNonQuery();


        //        //close Connection
        //       connection.CloseConnection();
        //    }


        //}



        public static void deletePlane(int idPlane)
        {
            string query = "DELETE FROM `plane` WHERE id=@idPlane";


            //Open connection
            ConnexionWorkBench connection = new ConnexionWorkBench();
            if (connection.OpenConnection() == true)

            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());
                cmd.Parameters.AddWithValue("@idPlane", idPlane);
                cmd.ExecuteNonQuery();

                //close Connection
                connection.CloseConnection();

            }
        }


        public static void insertPlane(int type, int warehouse, bool Status)
        {

            Status = true;
            //Open connection
            ConnexionWorkBench connection = new ConnexionWorkBench();
            if (connection.OpenConnection() == true)
            {

                string query = "INSERT INTO plane ( id_Type, id_Warehouse, Status)" +
                               " VALUES( @Type, @Warehouse, @Status)";
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());

                //shield injection
                cmd.Parameters.AddWithValue("@Type", type);
                //cmd.Parameters.AddWithValue("@Crew", Plane.Crew);
                cmd.Parameters.AddWithValue("@Warehouse", warehouse);
                cmd.Parameters.AddWithValue("@Status", Status);

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
    }
}
