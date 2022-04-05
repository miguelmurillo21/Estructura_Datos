using System;


namespace Ejercicio05
{
    class ejercico
    {
        static void Main( string[] args)
        {
            int filas_matriz = 0;
            int columnas_matriz = 0;
            int[,] primera_matriz;
            int[,] segunda_matriz;
            int[,] resulatdo_matriz;
            int[,] transpuesta;

            Console.Write("Cuantas filas van a tener la matriz {1} y {2} : ");
            filas_matriz = int.Parse(System.Console.ReadLine());


            Console.Write("Cuantas columnas van a tener la matriz {1} y {2} : ");
            columnas_matriz = int.Parse(System.Console.ReadLine());

            primera_matriz = new int [filas_matriz, columnas_matriz];
            segunda_matriz = new int[filas_matriz, columnas_matriz];
            resulatdo_matriz = new int[filas_matriz, columnas_matriz];
            transpuesta = new int[filas_matriz, columnas_matriz];


            Console.WriteLine("cargar las matrices 1 y 2");
            for (int i = 0; i < filas_matriz; i++)
            {
                for (int j = 0; j < columnas_matriz; j++)
                {
                    Console.Write($"Digite el elemento de la posicion {i}:{j} de la matriz(1):");
                    primera_matriz[i,j] = int.Parse(System.Console.ReadLine());

                    Console.Write($"Digite el elemento de la posicion {i}:{j} de la matriz(2):");
                    segunda_matriz[i, j] = int.Parse(System.Console.ReadLine());

                    transpuesta[i, j] = segunda_matriz[j, i];


                    resulatdo_matriz[i, j] = primera_matriz[i, j] + segunda_matriz[j, i];
                }
            }
            Console.WriteLine("resultado de la matriz :");

            for(int i = 0;i < filas_matriz; i++)
            {
                for(int j = 0;j < columnas_matriz; j++)
                {
                    Console.Write("  " + resulatdo_matriz[i, j] + "  ");
                }
            }

        }
    }
}
 