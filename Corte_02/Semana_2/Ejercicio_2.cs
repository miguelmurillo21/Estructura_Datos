using System;
using System.Collections;

namespace Ejercicio_Matriz2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número de filas:");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de columnas :");
            int c = int.Parse(Console.ReadLine());

            int[,] Matriz;
            Matriz = new int[f, c];

            Random numero = new Random();

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {

                    Matriz[i, j] = numero.Next(100, 999);
                }
            }
            Console.WriteLine("La matriz es: ");

            // Impresion de la matriz
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(Matriz[i, j]);
                    if (j + 1 == c) { Console.WriteLine(); } else { Console.Write(" - "); }
                }
            }
            Console.ReadKey(true);
        }
    }
}