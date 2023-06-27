using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
	internal class Autor
	{
		private string nombre;
		private string apellido;
		private string rut;
		private string nacionalidad;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		public string Rut
		{
			get { return rut; }
			set { rut = value; }
		}

		public string Nacionalidad
		{
			get { return nacionalidad; }
			set { nacionalidad = value; }
		}
	}
}
