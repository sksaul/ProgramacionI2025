namespace reto2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            suma();
            resta();
            multiplicacion();
            division();
        }

        static void suma()
        {
            Console.WriteLine("sumar");

            Console.WriteLine("Ingrese el primer numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            int suma = num1 + num2;

            Console.WriteLine("la suma es " + suma);

        }

        static void resta() 
        {
            Console.WriteLine();
            Console.WriteLine("restar");

            Console.WriteLine("Ingres el primer numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            int resta = num1 - num2;

            Console.WriteLine("la resta es " + resta);

        }

        static void multiplicacion()
        {
            Console.WriteLine();
            Console.WriteLine("multiplicar");

            Console.WriteLine("Ingres el primer numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            int multiplicacion = num1 * num2;

            Console.WriteLine("la multiplicacion es " + multiplicacion);

        }

        static void division()
        {
            Console.WriteLine();
            Console.WriteLine("dividir");

            Console.WriteLine("Ingres el primer numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            int didvision = num1 / num2;

            Console.WriteLine("la divisin es " + didvision);
        }
    }
}
