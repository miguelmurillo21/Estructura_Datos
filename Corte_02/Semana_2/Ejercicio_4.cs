using System;


namespace Ejercicio04
{
    class ejercua
    {
        static void Main( string[] args)
        {
            int filas_matriz = 5;
            int columnas_matriz = 5;
            int[,] primera_matriz;
            int[,] segunda_matriz;
            int[,] transpuesta;

            
            primera_matriz = new int[filas_matriz, columnas_matriz];
            segunda_matriz = new int[filas_matriz, columnas_matriz];
            transpuesta = new int[filas_matriz, columnas_matriz];

            Console.WriteLine("cargar las matrices 1 y 2");
            for (int i = 0; i < filas_matriz; i++)
            {
                for (int j = 0; j < columnas_matriz; j++)
                {
                    Console.Write($"Digite el elemento de la posicion {i}:{j} de la matriz(1):");
                    primera_matriz[i, j] = int.Parse(System.Console.ReadLine());

                    Console.Write($"Digite el elemento de la posicion {i}:{j} de la matriz(2):");
                    segunda_matriz[i, j] = int.Parse(System.Console.ReadLine());

                    transpuesta[i, j] = segunda_matriz[j, i];
                }
            }

            for(int i = 0;i < filas_matriz; i++)
            {
                for(int j = 0;j < columnas_matriz; j++)
                {
                    Console.Write(transpuesta[i, j]+ "\n" );
                }
            }
        }
            
    }
}
 