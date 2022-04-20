using System;
using System.Collections;

namespace Ejercicio_Matriz1
{
    class program
    {
        public void Main(String[] args)
        {

            int[,] Matriz = new int[4, 5];
            int Longitud_Fila = 4;
            int Longitud_Columna = 5;
            int sumatotal;
            int sumafil = 0;
            int sumacol = 0;

            for (int fil = 0; fil < Longitud_Fila; fil++)
            {
                for (int col = 0; col < Longitud_Columna; col++)
                {
                    Console.Write($"Ingrese el elemento {fil + 1}, {col + 1} del la matriz: ");
                    Matriz[fil, col] = int.Parse(System.Console.ReadLine());
                }
            }
            string r = "";

            for (int fil = 0; fil < Longitud_Fila; fil++)
            {
                for (int col = 0; col < Longitud_Columna; col++)
                {
                    sumafil = sumafil + Matriz[fil, col];
                }
                r = r + ("La suma de la fila " + (fil + 1) + sumafil);
            }

            for (int col = 0; col < Longitud_Columna; col++)
            {
                for (int fil = 0; fil < Longitud_Fila; fil++)
                {
                    sumacol = sumacol + Matriz[fil, col];
                }
                r = r + ("La suma de la columna " + (col + 1) + sumacol + "\n");
            }

            for (int col = 0; col < Longitud_Columna; col++)
            {
                for (int fil = 0; fil < Longitud_Fila; fil++)
                {
                    sumatotal = sumafil + sumacol;
                }
                r = r + ("La suma total es de: " + sumafil + sumacol);
            }

            Console.ReadLine();
        }
    }
}