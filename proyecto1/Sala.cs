using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
	class Sala
	{
		private string nombreSala;
		private bool tieneCierre, tieneAlarma;
		private float temperatura;
		private int lamparas;


        public string NombreSala
        {
            get { return nombreSala; }
            set { nombreSala = value; }
        }

        public bool TieneCierre
        {
            get { return tieneCierre; }
            set { tieneCierre = value; }
        }

        public bool TieneAlarma
        {
            get { return tieneAlarma; }
            set { tieneAlarma = value; }
        }

        public float Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }

        public int Lamparas
        {
            get { return lamparas; }
            set { lamparas = value; }
        }


    }
}
