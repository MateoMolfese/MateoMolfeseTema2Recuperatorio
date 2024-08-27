using ejercicio03.entidades;

namespace ejercicio03.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.Write("ingrese el radio del cilindro: ");
                var rad = int.Parse(Console.ReadLine());
                Console.Write("ingrese la altura del cilindro: ");
                var alt = int.Parse(Console.ReadLine());
                Cilindro c = new Cilindro(rad, alt);
                Console.WriteLine(c.getInfo());

            }
            catch (Exception)
			{

                Console.WriteLine("algo se ingreso incorrectamente");
            }
        }
    }
}
