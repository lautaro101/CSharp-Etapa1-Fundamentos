using System;
using System.Runtime.Versioning;

namespace Simulador_de_Plazo_Fijo
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;

            do
            {
                Console.Clear();
                Console.WriteLine("Simulador De Plazo Fijo");
                Console.Write("Cuanto Capital Desea Invertir: $");
                double capital = Double.Parse(Console.ReadLine());

                double ganancia = capital * 0.05;

                double total = capital + ganancia;
                
                Console.WriteLine($"Tu Ganancia En 1 Mes Sera De ${ganancia} y Tu Total Sera De ${total}");
                Console.ReadKey();
                Console.Clear();
                Console.Write("¿Desea realizar otra simulación? (si / no): ");
                

                respuesta = Console.ReadLine();
            }while (respuesta == "si");
            Console.Clear();
            Console.WriteLine("Gracias por usar el simulador");

        }
        
    }
}