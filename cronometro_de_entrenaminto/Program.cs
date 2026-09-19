using System;
using System.Threading;

namespace cronometro_de_entrenaminto
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Cronometro De Descanso");
            Console.Write("Cuantos segundos de descanso necesitas?: ");
            int descanso = int.Parse(Console.ReadLine());
            Console.Clear();

            for ( int i= descanso ; i > 0; i--)
            {
                Console.WriteLine($"Descansando... {i} seg restantes");

                Thread.Sleep(1000);
                Console.Clear();
                
            }
            Console.WriteLine("¡Tiempo terminado! ¡A la barra!");
            Console.Beep();

            Console.ReadKey();
        }
    }
}