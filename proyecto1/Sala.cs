using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
	class Sala
	{
        //la pintura que se encuentra dentro con el encargado creo*2 
		private string nombreSala;
		private bool tieneCierre, tieneAlarma;
		private double temperatura;
		private int lamparas;
        Encargado encargado;
        
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

        public double Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }

        public int Lamparas
        {
            get { return lamparas; }
            set { lamparas = value; }
        }
        public Sala(string nombreSala, bool tieneCierre, bool tieneAlarma, double temperatura, int lamparas, Encargado x)
        {
            this.nombreSala = nombreSala;
            this.tieneCierre = tieneCierre;
            this.tieneAlarma = tieneAlarma;
            this.temperatura = temperatura;
            this.lamparas = lamparas;
            this.encargado = x;
        }
    }
}
