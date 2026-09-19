using System;
using System.ComponentModel;
using System.Globalization;

namespace istema_de_Ingreso_con_Contraseñ
{
    class Program
    {
        static void Main(string[] args)
        {
            string clavesecreta = "admin123";
            Console.Write("Ingrese Su Contraseña: ");
            string contra = Console.ReadLine();

            while (contra != clavesecreta)
            {
                Console.WriteLine("Contraseña Incorrecta");
                Console.ReadKey();
                Console.Clear();
                Console.Write("Intente de nuevo: ");

                contra = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine("¡Acceso concedido! Bienvenido al sistema.");

            Console.ReadKey();
        }
    }
}