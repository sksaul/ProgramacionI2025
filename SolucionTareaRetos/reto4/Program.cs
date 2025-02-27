namespace reto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario = "";
            string contraseña = "";

            
            Console.WriteLine("Registrate");
            Console.Write("Ingresa tu nombre de usuario: ");
            usuario = Console.ReadLine();
            Console.Write("Ingresa tu contraseña: ");
            contraseña = Console.ReadLine();

            
            Console.WriteLine("Inicia sesión");
            Console.Write("Ingresa tu nombre de usuario: ");
            string usuarioIntento = Console.ReadLine();
            Console.Write("Ingresa tu contraseña: ");
            string contraseñaIntento = Console.ReadLine();

            
            bool usuarioCorrecto = (usuario == usuarioIntento);
            bool contraseñaCorrecta = (contraseña == contraseñaIntento);

            if (usuarioCorrecto && contraseñaCorrecta)
            {
                Console.WriteLine("Haz iniciado sesion");
            }
            else
            {
                Console.WriteLine("Usuario o contraseña incorrectos.");
            }
        }
    }
}
