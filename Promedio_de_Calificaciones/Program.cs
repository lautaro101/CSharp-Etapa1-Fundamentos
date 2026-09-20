using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Promedio_de_Calificaciones
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            
            double[] notas = new double[4];

            for(int i = 0; i < 4; i++)
            {
                Console.Write($"Ingresar la nota {i + 1}: ");

                notas[i] = double.Parse(Console.ReadLine());

            }
            Console.Clear();
            
            double suma = 0;

            foreach (double nota in notas)
            {
                suma = suma + nota;
            }
            double promedio = suma / 4;
            Console.WriteLine($"Tu Promedio final es:{promedio}");
            Console.ReadKey();
            
            
        }
    }
}