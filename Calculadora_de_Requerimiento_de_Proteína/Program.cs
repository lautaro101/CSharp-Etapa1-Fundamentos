using System;

namespace Calculadora_de_Requerimiento_de_Proteina
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Calculadora Nutricional V1.0");
            Console.WriteLine("Por favor ingrese su peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Clear();
            

            

            if (peso > 0 && peso <= 250)
            {
                Console.WriteLine("Calculadora Nutricional V1.0");
                Console.WriteLine();
                Console.WriteLine("1. volumen");
                Console.WriteLine("2.definicion");

                int opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    double calculo = peso * 2.0;
                    Console.Clear();
                    Console.WriteLine($"Para un peso de {peso}kg y tu objetivo, necesitas consumir {calculo} gramos de proteina al dia");
                }

                else if ( opcion == 2)
                {
                    double calculo2 = peso * 2.2;
                    Console.Clear();
                    Console.WriteLine($"para un peso de {peso}kg y tu objetivo, necesitas consumir {calculo2} gramos de proteina al dia ");
                    
                }
                else
                {
                    Console.WriteLine("Objetivo No reconocido");
                }

                Console.ReadKey();
            
            }

            else
            {
                Console.WriteLine("Peso Invalido");
            }
            Console.ReadKey();


        }
    }
}