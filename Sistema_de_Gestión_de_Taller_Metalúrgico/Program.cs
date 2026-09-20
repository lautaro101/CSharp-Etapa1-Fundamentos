using System;

namespace Sistema_de_Gestión_de_Taller_Metalúrgico
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] materiales = { "electrodos (kg)", "discos de corte", "Perfiles de acero"};
            int[] stock = { 50, 150, 40};

            bool continuar = true;

            do
            {
                Console.Clear();
                Console.WriteLine("--- SISTEMA DE GESTIÓN DE TALLER ---");
                Console.WriteLine("1. Ver inventario actual");
                Console.WriteLine("2. Agregar stock (Llegada de proveedor)");
                Console.WriteLine("3. Retirar material (Para usar en taller)");
                Console.WriteLine("4. Salir");
                Console.Write("Ingrese una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        
                        Console.WriteLine("\n--- INVENTARIO ACTUAL ---");

                        for(int i=0; i < 3; i++)
                        {
                        Console.WriteLine($"{(i+1)}. {materiales[1]}: {stock[i]} unidades");
                        
                       
                        }
                        Console.ReadKey();
                        break;
                    
                    case "2":
                        Console.WriteLine("\n--- AGREGAR STOCK ---");
                        
                        for(int i=0; i < 3; i++)
                        {
                        Console.WriteLine($"{(i+1)}. {materiales[i]}: {stock[i]} unidades");
                        }
                        Console.Write("Que material desea ingresar? (1-3): ");

                        int ingresar = int.Parse(Console.ReadLine());

                        int indice = ingresar -1;

                        Console.Write("Que cantidad ingreso al taller:");
                        int cantidad = int.Parse(Console.ReadLine());

                        stock[indice] = stock[indice] + cantidad;

                        Console.WriteLine("¡Stock actualizado con éxito!");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("\n--- RETIRAR MATERIAL ---");

                        for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"{(i + 1)}. {materiales[i]}: {stock[i]} unidades");
    }   

                        
                }
            }
        }
    }
}