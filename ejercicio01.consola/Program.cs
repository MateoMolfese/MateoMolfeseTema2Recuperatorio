namespace ejercicio01.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.Write("ingrese el radio del cilindro: ");
                var radio = int.Parse(Console.ReadLine());
                Console.Write("ingrese la altura del cilindro: ");
                var altura = int.Parse(Console.ReadLine());

                var volumen = Math.PI * Math.Pow(radio, 2) * altura;
                var superficie = 2 * Math.PI * Math.Pow(radio, 2) + 2 * Math.PI * radio * altura;

                Console.WriteLine("resultados del cilindro");
                Console.WriteLine($"el volumen del cilindro es de: {volumen}");
                Console.WriteLine($"la superficie del cilindro es de: {superficie}");

            }
            catch (Exception)
			{

                Console.WriteLine("algo se ingreso incorrectamente");
            }
        }
    }
}
