using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Informacion_Geografico
{
    class UtilsConstants
    {
        public const string SQL_BASE = "SELECT A.ID_FENOMENO, A.ID_CATEG_FENOMENO, A.COORD_SUCESO, A.ID_POBLADO, A.CP, A.FECHA_HORA_FENOMENO, "
            + "A.ID_MUNICIPIO, A.ID_DISTRITO, A.ID_REGION, A.ID_ESTADO, A.DESCRIPCION FROM [ACONTECIMIENTOS-FENOMENOS] A ";

        public const string SQL_FIND_USER = "select U.Id_Usuario, U.user_name, U.user_level, U.user_password from SIG_USERS U "
            + "where U.user_name='@USERNAME'and U.user_password='@PASSWORD'";

        public const string SQL_BY_RIESGO = "JOIN SIG_CAT_RIESGOS CR ON A.ID_CATEG_FENOMENO = CR.ID_CAT_RIESGO "
            + "JOIN TIPOS_DE_RIESGO TR ON CR.ID_TIPO_RIESGO = TR.ID "
            + "WHERE UPPER(CR.NOMBRE_CATEORIA) LIKE '%@PARAMETER%' OR UPPER(CR.DESC_CATEGORIA) LIKE '%@PARAMETER%' "
            + "OR UPPER(TR.CAT_NOMBRE) LIKE '%@PARAMETER%' OR UPPER(TR.CAT_DESCRIP) LIKE '%@PARAMETER%';";

        public const string SQL_BY_POBLADOS = "JOIN SIG_POBLADOS P ON A.ID_POBLADO = P.ID_POBLADO "
            +"WHERE UPPER(P.NOMBRE) LIKE '%@PARAMETER%';";

        public const string SQL_BY_MUNICIPIOS = "JOIN SIG_MUNICIPIOS M ON A.ID_MUNICIPIO = M.ID_MUNICIPIOS "
            + "WHERE UPPER(M.NOMBRE) LIKE '%@PARAMETER%';";

        public const string SQL_BY_DISTRITOS = "JOIN SIG_DISTRITOS D ON A.ID_DISTRITO = D.ID_DISTRITO "
            + "WHERE UPPER(D.NOMBRE) LIKE '%@PARAMETER%';";

        public const string SQL_BY_REGIONES = "JOIN SIG_REGIONES R ON A.ID_REGION = R.ID_REGION " 
            + "WHERE UPPER(R.NOMBRE) LIKE '%@PARAMETER%';";
        
        public const string SQL_BY_ESTADO = "JOIN SIG_ESTADOS E ON A.ID_ESTADO = E.ID_ESTADO "
            + "WHERE UPPER(E.ID_ESTADO) LIKE '%@PARAMETER%';";

        public const string SQL_BY_CATEGORIA_RIESGO = " WHERE A.ID_CATEG_FENOMENO = @PARAMETER";

        public const string SQL_BY_TIPO_RIESGO = "JOIN SIG_CAT_RIESGOS CR ON A.ID_CATEG_FENOMENO = CR.ID_CAT_RIESGO "
            + "JOIN TIPOS_DE_RIESGO TR ON CR.ID_TIPO_RIESGO = TR.ID "
            + "WHERE TR.ID= @PARAMETER;";

        public const string SQL_ALL_CAT_RIESGOS = "SELECT ID_CAT_RIESGO, NOMBRE_CATEORIA FROM [SIG_CAT_RIESGOS];";

        public const string SQL_ALL_REGIONES = "SELECT ID_REGION, NOMBRE FROM [SIG_REGIONES];";

        public const string SQL_GET_DISTRITOS_BY_REGION = "SELECT ID_DISTRITO, NOMBRE FROM [SIG_DISTRITOS] "
            + "WHERE ID_REGION = @PARAMETER;";

        public const string SQL_GET_MUNICIPIOS_BY_DISTRITOS = "SELECT ID_MUNICIPIOS, NOMBRE FROM [SIG_MUNICIPIOS] "
            + "WHERE ID_DISTRITO = @PARAMETER;";

        public const string SQL_GET_POBLADOS_BY_MUNICIPIOS = "SELECT ID_POBLADO, NOMBRE FROM [SIG_POBLADOS] "
            + "WHERE ID_MUNICIPIO = @PARAMETER;";

        public const string SQL_INSER_ACONTECIMIENTO = "INSERT INTO [ACONTECIMIENTOS-FENOMENOS] "
            + "(ID_CATEG_FENOMENO, COORD_SUCESO, ID_POBLADO, CP, FECHA_HORA_FENOMENO, "
            + "ID_MUNICIPIO, ID_DISTRITO, ID_REGION, ID_ESTADO, DESCRIPCION) "
            + "VALUES (@ID_CATEG_FENOMENO, @COORD_SUCESO, @ID_POBLADO, @CP, @FECHA_HORA_FENOMENO, "
            + "@ID_MUNICIPIO, @ID_DISTRITO, @ID_REGION, @ID_ESTADO, @DESCRIPCION);";
    }
}
