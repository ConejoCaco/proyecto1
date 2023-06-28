using proyecto1;
using System.Security.Cryptography.X509Certificates;

class Program
{
    

	public static void Main(string[] args)
    {
		Encargado encargado1 = new Encargado("Prueba1","21557353-2","profesion","añoingreso");
		Encargado encargado2 = new Encargado("Prueba2", "21557353-2", "profesion", "añoingreso");

		Sala sala1 = new Sala("bodega", true, true, 15.0, 10, encargado1);
		Sala sala2 = new Sala("exhibicion1", false, true, 18.0, 5,encargado2);
		Sala sala3 = new Sala("exhibicion2", true, true, 18.0, 5,encargado2);
		List<FichaIngreso> fichas = new List<FichaIngreso>();
		List<Pintura> pinturas = new List<Pintura>();
		List<Autor> autores = new List<Autor>();

		Console.Write("Nombre Autor: ");
		string x = Console.ReadLine();
		Console.WriteLine("Apellido: ");
		string y = Console.ReadLine();
		Console.WriteLine("Nacionalidad");
		string a = Console.ReadLine();
		Console.WriteLine("Rut: ");
		string rut = Console.ReadLine();
		Autor autor = new Autor(x,rut,y,a);

		Console.Write("Nombre de la Pintura: ");
		string q = Console.ReadLine();
		Console.WriteLine("Tecnica: ");
		string w = Console.ReadLine();
		Console.WriteLine("Genero");
		string e = Console.ReadLine();
		Console.WriteLine("Fecha de Creacion: ");
		string fecha = Console.ReadLine();
		Console.WriteLine("Id: ");
		int id = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Ancho: ");
		double dob = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Alto: ");
		double dob1 = Convert.ToDouble(Console.ReadLine());
		
		Tamanio tamanio = new Tamanio(dob, dob1);

		Pintura pintura = new Pintura(q,w,e,fecha,id,autor,tamanio);

		FichaIngreso fichaingreso = new FichaIngreso(sala1, pintura);

		fichas.Add(fichaingreso);
		pinturas.Add(pintura);
		autores.Add(autor);
		pintura.Mostrar();
		autor.Mostrar();
	}
}