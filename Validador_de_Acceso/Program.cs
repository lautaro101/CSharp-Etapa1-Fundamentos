using System;
namespace Validador_de_Acceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BBienvenido al Validador de Acceso de eSports");
            
            Console.WriteLine("Cuantos años tenes?:");
            int edad = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Tiene pase VIP/Competidor: (si / no)");
            string pase = Console.ReadLine().ToLower();
            Console.Clear();

            Console.WriteLine("Viene Con Un Tutor: (si / no)");
            string Tutor = Console.ReadLine().ToLower();
            Console.Clear();

            if (( edad >= 18 && pase == "si") || (edad < 18 && pase == "si" && Tutor == "si"))
            {
                Console.WriteLine("Acceso Concedido, puedes pasar");
            }
            else
            {
                Console.WriteLine("Acceso Denegado");
            }

        }
    
        
    }
}