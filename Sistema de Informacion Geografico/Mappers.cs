using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlTypes;

namespace Sistema_de_Informacion_Geografico
{
    class Mappers
    {
        /*
         * Metodo que mapea el contenido del datareader a un clase entidad
         * @Return un nuevo objeto User
         * */
        public static User userMapper(SqlDataReader reader)
        {
            User u = new User();
            u.IdUser = reader.GetInt32(0);
            u.Password = reader.GetString(3);
            u.UserLevel = reader.GetInt32(2);
            u.UserName = reader.GetString(1);
            return u;
        }

        /*
         * Metodo que mapea el contenido del datareader a un clase entidad
         * @Return un nuevo objeto acontecimiento
         * */
        public static Acontecimiento acontecimientoMapper(SqlDataReader reader)
        {
            Acontecimiento ac = new Acontecimiento();
            ac.IdAcontecimiento = reader.GetInt32(0);
            ac.IdCategoriaAcontecimiento = reader.GetInt32(1);
            ac.IdPoblacion = reader.GetInt32(3);
            ac.FechaHoraAcontecimiento = reader.GetDateTime(5);
            ac.Cp = reader.GetString(4);
            ac.CoordenadaSuceso = reader.GetString(2);
            ac.IdMunicipio = reader.GetInt32(6);
            ac.IdDistrito = reader.GetInt32(7);
            ac.IdRegion = reader.GetInt32(8);
            ac.IdEstado = reader.GetInt32(9);
            ac.Descripcion = reader.GetString(10);
            return ac;
        }
    }
}
