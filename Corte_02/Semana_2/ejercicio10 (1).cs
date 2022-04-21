using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aplicacionBase
{


    class PrimeraMatriz
    {



        int[,] Matriz = new int[5, 5];
        int LONGITUD_FILA_MATRIZ = 5;
        int LONGITUD_COLUMNA_MATRIZ = 5;
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

        public void ImprimirMayor()
        {
            int ELEMENTO_MAYOR = Matriz[0, 0];
            int filaMayor = 0;
            int columnaMayor = 0;

            for (int f = 0; f < Matriz.GetLength(0); f++)
            {
                for (int c = 0; c < Matriz.GetLength(1); c++)
                {
                    if (Matriz[f, c] > ELEMENTO_MAYOR)
                    {
                        ELEMENTO_MAYOR = Matriz[f, c];
                        filaMayor = f;
                        columnaMayor = c;
                    }
                }
            }

            Console.WriteLine("El elemento mayor de la matriz de [" + Matriz.GetLength(0) + "] x [" + Matriz.GetLength(1) + "] es : [" + ELEMENTO_MAYOR + "]");
        }
            static void Main(string[] args)
            {
                PrimeraMatriz matriz = new PrimeraMatriz();
                matriz.CargarMatriz();
                matriz.ImprimirMatriz();
                matriz.ImprimirMayor();
            }

        }
    }