using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aplicacionBase
{


    class PrimeraMatriz
    {


        int[,] matrizrotada = new int[3, 3];
        int[,] Matriz = new int[3, 3];
        int LONGITUD_FILA_MATRIZ = 3;
        int LONGITUD_COLUMNA_MATRIZ = 3;
        int numeroE;

        Random rand = new Random();

        public void CargarMatriz()
        {
            // Cargar la matriz

            for (int f = 0; f < LONGITUD_FILA_MATRIZ; f++)
            {
                for (int c = 0; c < LONGITUD_COLUMNA_MATRIZ; c++)
                {
                    numeroE = rand.Next(0, 100);
                    Matriz[f, c] = numeroE;
                }
            }


        }


        public void ImprimirMatriz()
        {
            Console.WriteLine("\nLa matriz resultante es");

            for (int f = 0; f < LONGITUD_FILA_MATRIZ; f++)
            {
                for (int c = 0; c < LONGITUD_COLUMNA_MATRIZ; c++)
                {
                    Console.Write("    [" + Matriz[f, c] + "] ");
                }
                Console.WriteLine();
            }

        }

       
        static void Main(string[] args)
        {
            PrimeraMatriz matriz = new PrimeraMatriz();
            matriz.CargarMatriz();
            matriz.ImprimirMatriz();
            
        }

    }
}
