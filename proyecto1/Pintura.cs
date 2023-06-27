using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
	internal class Pintura
	{
		private string nombreAutor;
		private string nombre;
		private string tecnica;
		private string genero;
		private string fechaCreacion;
		private int id;
		public string NombreAutor
		{
			get { return nombreAutor; }
			set { nombreAutor = value; }
		}

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public string Tecnica
		{
			get { return tecnica; }
			set { tecnica = value; }
		}

		public string Genero
		{
			get { return genero; }
			set { genero = value; }
		}

		public string FechaCreacion
		{
			get { return fechaCreacion; }
			set { fechaCreacion = value; }
		}

		public int Id
		{
			get { return id; }
			set { id = value; }
		}
	}
}
