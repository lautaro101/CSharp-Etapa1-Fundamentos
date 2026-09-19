using System;

namespace CalculadoraPresupuesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a su calculadora de presupuesto");
            Console.WriteLine("Por favor ingrese los siguientes datos.");
            
            Console.WriteLine("Presupuesto: ");
            double presupuesto = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("1er  compra: ");
            string compra1 = Console.ReadLine();
            Console.WriteLine("Valor de la compra: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("2da compra: ");
            string compra2 = Console.ReadLine();
            Console.WriteLine("Valor de la 2da compra");
            double valor2 = double.Parse(Console.ReadLine());
            Console.Clear();
     
            
            double vuelto = presupuesto - (valor1 + valor2);

            double faltante = (valor1 + valor2) - presupuesto;

            if (vuelto >= 0)
            {
                Console.WriteLine($"Compra exitosa de {compra1} y {compra2}, aqui tiene su vuelto: {vuelto}");
                Console.WriteLine("Muchas gracias");
            }

            else if (faltante > 0)
            {
                Console.WriteLine($"Disculpe, te falta esta cantida: {faltante}");
                Console.WriteLine("Muchas Gracias");
            }

            




        }
    }
}