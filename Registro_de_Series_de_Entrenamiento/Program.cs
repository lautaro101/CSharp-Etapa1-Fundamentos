using System;

namespace Registro_de_Series_de_Entrenamiento
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[] pesos = new double[5];
            for (int i = 0; i < 5; i++ )
            {
                Console.Write($"Ingrese el peso levantado en la serie{i + 1}: ");

                pesos[i] = double.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("--- Resumen de tu Entrenamiento ---");
            
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Series {i + 1}: {pesos[1]} kg");
            }
        }
    }
}