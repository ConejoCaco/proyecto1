using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
	class Tamanio
	{
		private float ancho;
		private float alto;

		public float Ancho
		{
			get { return ancho; }
			set { ancho = value; }
		}

		public float Alto
		{
			get { return alto; }
			set { alto = value; }
		}

		Tamanio(float ancho,float alto)
		{
			this.ancho = ancho;
			this.alto = alto;

		}
	}
}
