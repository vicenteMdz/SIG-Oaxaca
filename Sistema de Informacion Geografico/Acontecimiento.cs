using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Informacion_Geografico
{
    public class Acontecimiento
    {
        private int idAcontecimiento;
        private int idCategoriaAcontecimiento;
        private string coordenadaSuceso;
        private int idPoblacion;
        private string cp;
        private DateTime fechaHoraAcontecimiento;
        private int idMunicipio;
        private int idDistrito;
        private int idRegion;
        private int idEstado;
        private string descripcion;

        public int IdAcontecimiento
        {
            get { return idAcontecimiento; }
            set { idAcontecimiento = value; }
        }

        public int IdCategoriaAcontecimiento
        {
            get { return idCategoriaAcontecimiento; }
            set { idCategoriaAcontecimiento = value; }
        }

        public string CoordenadaSuceso
        {
            get { return coordenadaSuceso; }
            set { coordenadaSuceso = value; }
        }

        public int IdPoblacion
        {
            get { return idPoblacion; }
            set { idPoblacion = value; }
        }

        public string Cp
        {
            get { return cp; }
            set { cp = value; }
        }
        
        public DateTime FechaHoraAcontecimiento
        {
            get { return fechaHoraAcontecimiento; }
            set { fechaHoraAcontecimiento = value; }
        }

        public int IdMunicipio
        {
            get { return idMunicipio; }
            set { idMunicipio = value; }
        }

        public int IdDistrito
        {
            get { return idDistrito; }
            set { idDistrito = value; }
        }

        public int IdRegion
        {
            get { return idRegion; }
            set { idRegion = value; }
        }

        public int IdEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

    }
}
