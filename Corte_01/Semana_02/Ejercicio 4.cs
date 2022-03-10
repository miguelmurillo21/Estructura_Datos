using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio3
{

    public static class Program
    {
        public static void Main()
        {
                int[] numeros = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Ingrese un número:");
                    numeros[i] = int.Parse(Console.ReadLine());
                }
                Array.Sort(numeros);
                Console.WriteLine("Los Números En Su Orden Son:");
                for (int i=0;i<10;i++)
                {
                    Console.WriteLine(numeros[i]);
                }
                Console.ReadKey();
        }
    }
}