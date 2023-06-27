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
		private int anioIngreso;

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
