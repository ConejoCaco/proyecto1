using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
	class Encargado
	{
		private string nombre, rut, profesion;
		private int anioIngreso;

		public string Nombre{
			get { return nombre; }
			set {  nombre = value; }
		}
        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }

        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        public int AnioIngreso
        {
            get { return anioIngreso; }
            set { anioIngreso = value; }
        }
    }
}
