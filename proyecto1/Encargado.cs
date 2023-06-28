using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
	class Encargado : Persona
	{
		private string profesion;
		private string anioIngreso;

        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        public string AnioIngreso
        {
            get { return anioIngreso; }
            set { anioIngreso = value; }
        }
		Encargado(string nombre, string rut, string profesion, string anioIngreso)
		{
			this.nombre = nombre;
			this.rut = rut;
			this.profesion = profesion;
			this.anioIngreso = anioIngreso;
		}
	}
}
