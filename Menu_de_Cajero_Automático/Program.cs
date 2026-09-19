using System;

namespace Menu_de_Cajero_Automático
{
    class Program
    {
        public static void Main(string[] arg)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido Al Cajero: C Sharp Bank");
            Console.WriteLine("");

            Console.WriteLine("====Menu====");
            Console.WriteLine("1. Consultar Saldo");
            Console.WriteLine("2. Ingresar saldo");
            Console.WriteLine("3. Retirar Dinero");
            Console.WriteLine("4. Salir");
            
            
            Console.Write($"Elija Una Opcion: ");
            int opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                Console.Clear();
                Console.WriteLine("Tu Saldo Actual Es De $50.000");
                Console.ReadKey();
                break;

                case 2:
                Console.Clear();
                Console.WriteLine("¿Cuanto Dinero Desea Ingresar?");
                Console.Write("Monto A Ingresar : ");
                double monto = double.Parse(Console.ReadLine());

                Console.WriteLine($"Has Ingresado ${monto} Exitosamente");
                Console.ReadKey();
                break;
                
                case 3:
                Console.Clear();
                Console.WriteLine("¿Cuanto Dinero Desea Retirar?");
                Console.Write("Monto A retirar: ");
                double retirar = double.Parse(Console.ReadLine());

                Console.WriteLine($"Has Retirado ${retirar} exitosamente");
                Console.ReadKey();
                break;

                case 4:
                Console.Clear();
                Console.WriteLine("Gracias Por Operar Con Nosotros");
                break;

                default:
                Console.WriteLine("Opcion Invalida");
                break;
                
            }

                
            

            
        }
    }
}