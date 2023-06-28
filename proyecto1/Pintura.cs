
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
	internal class Pintura
	{
		private string nombre, tecnica, genero;
		private string fechaCreacion;
		private int id;
		Tamanio tamanio;
		Autor autor;

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
		public Pintura( string nombre, string tecnica, string genero, string fechaCreacion, int id,Autor autor,Tamanio tamanio)
		{
			
			this.nombre = nombre;
			this.tecnica = tecnica;
			this.genero = genero;
			this.fechaCreacion = fechaCreacion;
			this.id = id;
			this.tamanio = tamanio;
			this.autor = autor;
		}
		public void Mostrar()
		{
			Console.WriteLine($"Nombre: {nombre}\nTecnica: {tecnica} \nGenero: {genero} \nFecha de Creacion: {fechaCreacion}\nAlto: {this.tamanio.Alto}\n Ancho: {this.tamanio.Ancho}");
		}
	}
}
