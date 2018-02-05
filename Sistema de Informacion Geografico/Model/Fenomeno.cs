using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Informacion_Geografico.Model
{
    class Acontecimiento
    {
        private int idAcontecimiento;
        private int idCategoriaAcontecimiento;
        private string coordenadaSuceso;
        private int idPoblacion;
        private string cp;
        private DateTime fechaHoraAcontecimiento;

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

    }
}
