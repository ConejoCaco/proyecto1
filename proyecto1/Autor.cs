using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
	internal class Autor : Persona
	{
		private string apellido;
		private string nacionalidad;

        public string Apellido
        {
           get { return apellido; }
           set { apellido = value; }
        }

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
	}
}
