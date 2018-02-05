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

        public static void closeConnection()
        {
            SIGDB.Close();
        }

        public static User findUser(string user, string password)
        {
            openConnection();
            cmd = new SqlCommand(UtilsConstants.SQL_FIND_USER.Replace("@USERNAME", user).Replace("@PASSWORD", password), SIGDB);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return Mappers.userMapper(reader);
            }
            else
            {
                return null;
            }
        }

        public static List<Acontecimiento> getAllAcontecimientos()
        {
            openConnection();
            cmd = new SqlCommand(UtilsConstants.SQL_BASE, SIGDB);
            reader = cmd.ExecuteReader();
            List<Acontecimiento> acontecimientos = new List<Acontecimiento>();
            while (reader.Read())
            {
                acontecimientos.Add(Mappers.acontecimientoMapper(reader));
            }
            return acontecimientos;
        }

        public static List<Acontecimiento> findAcontecimientoPorCategoriaRiesgo(int idCategoria)
        {
            openConnection();
            StringBuilder query = new StringBuilder(UtilsConstants.SQL_BASE);
            query.Append(UtilsConstants.SQL_BY_CATEGORIA_RIESGO);
            query.Replace("@PARAMETER",""+idCategoria);
            cmd = new SqlCommand(query.ToString(), SIGDB);
            reader = cmd.ExecuteReader();
            List<Acontecimiento> acontecimientos = new List<Acontecimiento>();
            while(reader.Read()){
                acontecimientos.Add(Mappers.acontecimientoMapper(reader));
            }
            return acontecimientos;
        }

        public static List<Acontecimiento> busquedaLibre(string parameter, int filter)
        {
            openConnection();
            StringBuilder query = new StringBuilder(UtilsConstants.SQL_BASE);
            switch (filter)
            {
                case 0:
                    query.Append(UtilsConstants.SQL_BY_RIESGO);
                    break;
                case 1:
                    query.Append(UtilsConstants.SQL_BY_POBLADOS);
                    break;
                case 2:
                    query.Append(UtilsConstants.SQL_BY_MUNICIPIOS);
                    break;
                case 3:
                    query.Append(UtilsConstants.SQL_BY_DISTRITOS);
                    break;
                case 4:
                    query.Append(UtilsConstants.SQL_BY_REGIONES);
                    break;
                case 5:
                    query.Append(UtilsConstants.SQL_BY_ESTADO);
                    break;
            }
            query.Replace("@PARAMETER",parameter);
            Console.WriteLine(query.ToString());
            cmd = new SqlCommand(query.ToString(), SIGDB);
            reader = cmd.ExecuteReader();
            List<Acontecimiento> acontecimientos = new List<Acontecimiento>();
            while (reader.Read())
            {
                acontecimientos.Add(Mappers.acontecimientoMapper(reader));
            }
            return acontecimientos;
        }

    }
}
