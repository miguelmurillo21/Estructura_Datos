using System;
using System.Collections;

namespace Eercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            double promedio;

            int[] notas = { 6, 4, 3, };
            string[] alumnos = { "Paula, Sebastian, Cristian" };
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("la nota de {0} es: {1}", alumnos[i], notas[i]);
            }
            for(int i = 0;i < notas.Length; i++)
            {
                suma = suma + notas[i];
            }
            promedio = suma / notas.Length;

            Console.WriteLine("el promedio es: {0}", promedio);
        }
    }
}