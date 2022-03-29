using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio4
{
    class Vectores
    {
        static void Main(String[] args)
        {
            Vectores vector = new Vectores();
            vector.DatosVector();
            vector.ImprimirVector();
        }
        int[] Vector;
        int TAMAÑO = 100;
        public void DatosVector()
        {

            Vector = new int[TAMAÑO];

            for (int i = 0; i < Vector.Length; i++)
            {
                Vector[i] = i + 1;
            }
        }
        public void ImprimirVector()
        {
            float suma = 0;
            float media = 0;
            for (int i = 0; i < Vector.Length; i++)
            {
                Console.WriteLine(Vector[i]);

                suma = suma + Vector[i];
                Console.WriteLine("La suma es: " + suma);
                media = suma / Vector[i];
                Console.WriteLine("La media es: " + media);
            }
        }
    }
}