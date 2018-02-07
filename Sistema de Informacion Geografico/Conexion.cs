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
using System.Net;
using System.IO;
using System.Xml.Linq;
using System.Data;

namespace Sistema_de_Informacion_Geografico
{
    class Conexion 
    {
        private static SqlConnection SIGDB;
        private static SqlCommand cmd;
        private static SqlDataReader reader;
        public static string connectionString;
        private static string path = Directory.GetCurrentDirectory();
        private static string errorMessageInserted = "";

        public static string ErrorMessageInserted
        {
            get { return Conexion.errorMessageInserted; }
            set { Conexion.errorMessageInserted = value; }
        }

        public static SqlConnection SIGDB1
        {
            get { return Conexion.SIGDB; }
            set { Conexion.SIGDB = value; }
        }

        public static void createConecction()
        {
            connectionString = ConfigurationManager.ConnectionStrings["conectionbd"].ConnectionString;
            SIGDB1 = new SqlConnection(connectionString);
        }

        public static void openConnection()
        {
            SIGDB1.Close();
            SIGDB1.Open();
        }

        public static void closeConnection()
        {
            SIGDB1.Close();
        }

        public static void buscaCoordenadas()
        {
            openConnection();
            SqlCommand command = new SqlCommand("select  * from SIG_POBLADOS", SIGDB1);

            reader = command.ExecuteReader();
            //MessageBox.Show("entrando");
            int i = 0;
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(path + "\\Coordenadas.sql");
                while (reader.Read())
                {
                    int idpoblado = reader.GetInt32(0);
                    string nombrepoblado = reader.GetString(2);
                    string Query = "";
                    try
                    {

                        string requestUri = string.Format("http://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=false",
                        Uri.EscapeDataString(nombrepoblado));

                        WebRequest request = WebRequest.Create(requestUri);
                        WebResponse response = request.GetResponse();
                        XDocument xdoc = XDocument.Load(response.GetResponseStream());

                        XElement result = xdoc.Element("GeocodeResponse").Element("result");
                        XElement locationElement = result.Element("geometry").Element("location");
                        XElement lat = locationElement.Element("lat");
                        XElement lng = locationElement.Element("lng");
                        String latitud = lat.Value.ToString();
                        String longitud = lng.Value.ToString();
                        Query = "INSERT INTO SIG_COORDENADAS (ID_COORDENADA, ID_POBLADO, LATITUD, LONGITUD) "
                                    + "VALUES (" + i + "," + idpoblado + ", " + latitud + ", " + longitud + ")";
                        //Write a line of text
                        sw.WriteLine(Query);
                    }
                    catch (Exception ex)
                    {
                        Query = "INSERT INTO SIG_COORDENADAS (ID_COORDENADA, ID_POBLADO, LATITUD, LONGITUD) "
                                    + "VALUES (" + i + "," + idpoblado + ", 0, 0)";
                        Console.WriteLine(Query);
                        //Write a line of text
                        sw.WriteLine(Query);
                    }
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("fin");
        }

        public static User findUser(string user, string password)
        {
            openConnection();
            cmd = new SqlCommand(UtilsConstants.SQL_FIND_USER.Replace("@USERNAME", user).Replace("@PASSWORD", password), SIGDB1);
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
            cmd = new SqlCommand(UtilsConstants.SQL_BASE, SIGDB1);
            reader = cmd.ExecuteReader();
            List<Acontecimiento> acontecimientos = new List<Acontecimiento>();
            while (reader.Read())
            {
                acontecimientos.Add(Mappers.acontecimientoMapper(reader));
            }
            return acontecimientos;
        }

        public static List<Acontecimiento> findAcontecimientoPorTipoRiesgo(int tipoRiesgo)
        {
            openConnection();
            StringBuilder query = new StringBuilder(UtilsConstants.SQL_BASE);
            query.Append(UtilsConstants.SQL_BY_TIPO_RIESGO);
            query.Replace("@PARAMETER", "" + tipoRiesgo);
            cmd = new SqlCommand(query.ToString(), SIGDB1);
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
            cmd = new SqlCommand(query.ToString(), SIGDB1);
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
            cmd = new SqlCommand(query.ToString(), SIGDB1);
            reader = cmd.ExecuteReader();
            List<Acontecimiento> acontecimientos = new List<Acontecimiento>();
            while (reader.Read())
            {
                acontecimientos.Add(Mappers.acontecimientoMapper(reader));
            }
            return acontecimientos;
        }

        public static List<LabelVauleBean> getLabelValueBeanCategoriaRiesgos()
        {
            openConnection();
            cmd = new SqlCommand(UtilsConstants.SQL_ALL_CAT_RIESGOS, SIGDB1);
            reader = cmd.ExecuteReader();
            List<LabelVauleBean> items = new List<LabelVauleBean>();
            items.Add(new LabelVauleBean(-1,"-- Seleccione --", false));
            while (reader.Read())
            {
                items.Add(Mappers.itemMapper(reader));
            }
            return items;
        }

        public static List<LabelVauleBean> getLabelValueBeanRegiones()
        {
            openConnection();
            cmd = new SqlCommand(UtilsConstants.SQL_ALL_REGIONES, SIGDB1);
            reader = cmd.ExecuteReader();
            List<LabelVauleBean> items = new List<LabelVauleBean>();
            items.Add(new LabelVauleBean(-1, "-- Seleccione --", false));
            while (reader.Read())
            {
                items.Add(Mappers.itemMapper(reader));
            }
            return items;
        }

        public static List<LabelVauleBean> getLabelValueBeanDistritosPorRegion(int idRegion)
        {
            openConnection();
            cmd = new SqlCommand(UtilsConstants.SQL_GET_DISTRITOS_BY_REGION.Replace("@PARAMETER",""+idRegion), SIGDB1);
            reader = cmd.ExecuteReader();
            List<LabelVauleBean> items = new List<LabelVauleBean>();
            items.Add(new LabelVauleBean(-1, "-- Seleccione --", false));
            while (reader.Read())
            {
                items.Add(Mappers.itemMapper(reader));
            }
            return items;
        }

        public static List<LabelVauleBean> getLabelValueBeanMunicipiosPorDistritos(int idDistrito)
        {
            openConnection();
            cmd = new SqlCommand(UtilsConstants.SQL_GET_MUNICIPIOS_BY_DISTRITOS.Replace("@PARAMETER", "" + idDistrito), SIGDB1);
            reader = cmd.ExecuteReader();
            List<LabelVauleBean> items = new List<LabelVauleBean>();
            items.Add(new LabelVauleBean(-1, "-- Seleccione --", false));
            while (reader.Read())
            {
                items.Add(Mappers.itemMapper(reader));
            }
            return items;
        }

        public static List<LabelVauleBean> getLabelValueBeanPobladosPorMunicipios(int idMunicipio)
        {
            openConnection();
            cmd = new SqlCommand(UtilsConstants.SQL_GET_POBLADOS_BY_MUNICIPIOS.Replace("@PARAMETER", "" + idMunicipio), SIGDB1);
            reader = cmd.ExecuteReader();
            List<LabelVauleBean> items = new List<LabelVauleBean>();
            items.Add(new LabelVauleBean(-1, "-- Seleccione --", false));
            while (reader.Read())
            {
                items.Add(Mappers.itemMapper(reader));
            }
            return items;
        }
    
        public static string getCoordinates(string location)
        {
            string coordinate = "";
            try
            {

                string requestUri = string.Format("http://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=false",
                                    Uri.EscapeDataString(location + ", Oaxaca"));

                WebRequest request = WebRequest.Create(requestUri);
                WebResponse response = request.GetResponse();
                XDocument xdoc = XDocument.Load(response.GetResponseStream());

                XElement result = xdoc.Element("GeocodeResponse").Element("result");
                XElement locationElement = result.Element("geometry").Element("location");
                XElement lat = locationElement.Element("lat");
                XElement lng = locationElement.Element("lng");
                String latitud = lat.Value.ToString();
                String longitud = lng.Value.ToString();
                coordinate += latitud + "," + longitud;
                Console.WriteLine("API google maps consumido correctamente, Coordenadas::: " + coordinate);
                return coordinate;
            }
            catch (Exception ex)
            {
                coordinate += "0,0";
                Console.WriteLine("API google Error!! Ubicación no encontrada, Coordenadas::: " + coordinate);
                return coordinate;
            }
        }

        public static Boolean insertAcontecimiento(Acontecimiento acontecimiento)
        {
            try
            {
                openConnection();
                
                SqlCommand command = new SqlCommand(null, SIGDB1);
                command.CommandText = UtilsConstants.SQL_INSER_ACONTECIMIENTO;

                SqlParameter codigoPostal = new SqlParameter("@CP", SqlDbType.VarChar, 30);
                SqlParameter coordenada = new SqlParameter("@COORD_SUCESO", SqlDbType.VarChar, 100);
                SqlParameter descripcion = new SqlParameter("@DESCRIPCION", SqlDbType.VarChar, 1000);
                SqlParameter categoriaFenomeno = new SqlParameter("@ID_CATEG_FENOMENO", SqlDbType.Int, 4);
                SqlParameter idPoblado = new SqlParameter("@ID_POBLADO", SqlDbType.Int, 4);
                SqlParameter idMunicipio = new SqlParameter("@ID_MUNICIPIO", SqlDbType.Int, 4);
                SqlParameter idDistrito = new SqlParameter("@ID_DISTRITO", SqlDbType.Int, 4);
                SqlParameter idRegion = new SqlParameter("@ID_REGION", SqlDbType.Int, 4);
                SqlParameter idEstado = new SqlParameter("@ID_ESTADO", SqlDbType.Int, 4);
                SqlParameter fechaSuceso = new SqlParameter("@FECHA_HORA_FENOMENO", SqlDbType.DateTime);

                codigoPostal.Value = acontecimiento.Cp;
                coordenada.Value = acontecimiento.CoordenadaSuceso;
                descripcion.Value = acontecimiento.Descripcion;
                categoriaFenomeno.Value = acontecimiento.IdCategoriaAcontecimiento;
                idPoblado.Value = acontecimiento.IdPoblacion;
                idMunicipio.Value = acontecimiento.IdMunicipio;
                idDistrito.Value = acontecimiento.IdDistrito;
                idRegion.Value = acontecimiento.IdRegion;
                idEstado.Value = acontecimiento.IdEstado;
                fechaSuceso.Value = acontecimiento.FechaHoraAcontecimiento;

                command.Parameters.Add(codigoPostal);
                command.Parameters.Add(coordenada);
                command.Parameters.Add(descripcion);
                command.Parameters.Add(categoriaFenomeno);
                command.Parameters.Add(idPoblado);
                command.Parameters.Add(idMunicipio);
                command.Parameters.Add(idDistrito);
                command.Parameters.Add(idRegion);
                command.Parameters.Add(idEstado);
                command.Parameters.Add(fechaSuceso);

                // Call Prepare after setting the Commandtext and Parameters.
                command.Prepare();
                int numRowsAffected = command.ExecuteNonQuery();
                if (numRowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                errorMessageInserted = e.ToString();
                return false;
            }
        }
    }
}
