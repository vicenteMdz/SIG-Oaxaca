using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Informacion_Geografico
{
    public class Coordenadas
    {
        private int id;
        private double Latitud;
        private double Longitud;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public double Latitud1
        {
            get
            {
                return Latitud;
            }

            set
            {
                Latitud = value;
            }
        }

        public double Longitud1
        {
            get
            {
                return Longitud;
            }

            set
            {
                Longitud = value;
            }
        }
    }
}
