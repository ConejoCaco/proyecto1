using proyecto1;
using System.Security.Cryptography.X509Certificates;

class Program
{
    Encargado encargado1 = new Encargado("Prueba1");
	
	Sala sala1 = new Sala("bodega",true,true,15.0,10,encargado1);
	Sala sala2 = new Sala("exhibicion1",false,true, 18.0, 5);
	Sala sala3 = new Sala("exhibicion2",true,true, 18.0, 5);
    List<FichaIngreso> fichas = new List<FichaIngreso>();

	public static void Main(string[] args)
    {
        
    }
}