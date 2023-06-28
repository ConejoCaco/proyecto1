using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
	internal class Persona
	{
		//nose si hacerlos protected y el set get
		protected string nombre;
		protected string rut;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		public string Rut
		{
			get { return rut; }
			set { rut = value; }
		}
	}
}
