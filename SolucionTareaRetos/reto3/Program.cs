namespace reto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("ingresa el primer valor");
                int valor1 = int.Parse(Console.ReadLine());

                Console.WriteLine("ingresa el segudo valor");
                int valor2 = int.Parse(Console.ReadLine());

                int sumaDeValores = valor1 + valor2;

                Console.WriteLine("la suma de valores es " + sumaDeValores);

            }
            catch (Exception ex) 
            {
                Console.WriteLine ("Error "+ex.Message);

            }

            

            
        }
    }
}
