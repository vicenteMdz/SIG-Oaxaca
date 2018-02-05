using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlTypes;
using System.Globalization;
using System.Data.OleDb;

namespace Sistema_de_Informacion_Geografico
{
    class Conexion
    {
        private static SqlConnection SIGDB;
        private static SqlCommand cmd;
        private static SqlDataReader reader;
        public static string connectionString;

        public static void createConecction()
        {
            connectionString = ConfigurationManager.ConnectionStrings["conectionbd"].ConnectionString;
            SIGDB = new SqlConnection(connectionString);
        }

        public static void openConnection()
        {
            SIGDB.Close();
            SIGDB.Open();
        }

        public static User findUser(string user, string password)
        {
            openConnection();
            cmd = new SqlCommand("select * from SIG_USERS where User_name='" + user + "'and User_password='" + password + "'", SIGDB);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                User u = new User();
                u.IdUser = reader.GetInt32(0);
                u.Password = reader.GetString(3);
                u.UserLevel = reader.GetInt32(2);
                u.UserName = reader.GetString(1);
                return u;
            }
            else
            {
                return null;
            }
        }

        public static List<Acontecimiento> findAcontecimientoPorCategoriaRiesgo(int idCategoria)
        {
            openConnection();
            cmd = new SqlCommand("SELECT * FROM ACONTECIMIENTOS-FENOMENOS WHERE ID_CATEG_FENOMENO = " + idCategoria, SIGDB);
            reader = cmd.ExecuteReader();
            List<Acontecimiento> acontecimientos = new List<Acontecimiento>();
            while(reader.Read()){
                Acontecimiento ac = new Acontecimiento();
                ac.IdAcontecimiento = reader.GetInt32(0);
                ac.IdCategoriaAcontecimiento = reader.GetInt32(1);
                ac.IdPoblacion = reader.GetInt32(3);
                ac.FechaHoraAcontecimiento = reader.GetDateTime(5);
                ac.Cp = reader.GetString(4);
                ac.CoordenadaSuceso = reader.GetString(2);
                acontecimientos.Add(ac);
            }
            return acontecimientos;
        }

        public static List<Acontecimiento> busquedaLibre(string parameter)
        {
            return null;
        }
    }
}
