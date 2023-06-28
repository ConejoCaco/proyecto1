using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
	public class Tamanio
	{
		private double ancho;
		private double alto;

		public double Ancho
		{
			get { return ancho; }
			set { ancho = value; }
		}

		public double Alto
		{
			get { return alto; }
			set { alto = value; }
		}

		public Tamanio(double ancho, double alto)
		{
			this.ancho = ancho;
			this.alto = alto;

		}
	}
}
