using System;
using System.Numerics;

namespace Caja_Registradora_Expreso
{
    class Program
    {
        public static void Main(string[] args)
        {
            string otroCliente;
            do
            {
                Console.Clear();
                Console.WriteLine("--- NUEVO CLIENTE ---");

                double total = 0;
                double precio;

                do
                {
                    Console.Write("Ingrese el precio del producto (0 para terminar): $");

                    precio = double.Parse(Console.ReadLine());
                    total = total + precio;
                } while (precio != 0);

                Console.WriteLine($"El total a pagar de : ${total}");
                Console.WriteLine();
                Console.Write("¿Hay otro cliente en la fila? (si / no): ");

                otroCliente = Console.ReadLine();
            } while ((otroCliente == "si")|| (otroCliente == "s"));

            Console.Clear();
            Console.WriteLine("Caja cerrada. Fin del turno");
            Console.ReadKey();
        }
    }
}