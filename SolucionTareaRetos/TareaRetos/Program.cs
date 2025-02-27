namespace TareaRetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reto1();
        }
        static void Reto1()
        {
            double  Ingreso1;
            double Ingreso2;
            double Ingreso3;
            string NombreUsuario;

            Console.WriteLine("Ingresa tu nombre de usuario");
            NombreUsuario = Console.ReadLine();

            Console.WriteLine("ingresa la cantidad del primer mes");
            Ingreso1 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingresa la cantidad del segundo mes");
            Ingreso2 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingresa la cantidad del tercer mes");
            Ingreso3 = double.Parse(Console.ReadLine());

            double suma = Ingreso1 + Ingreso2 + Ingreso3;

            double promedio = suma / 3;

            Console.WriteLine("Hola " + NombreUsuario + " En total ganaste " + suma + " y promediaste " + promedio);

        }

    }
}
