﻿using System;
namespace ejercicio_11
    
{  
 class matrizEjercicio
    {
        string[] paises = new string[3];
        string[] ciudades = new string[3];
        public void CargarMatriz()
        {
            for (int f = 0; f < paises.Length; f++)
            {

                // Carga
                Console.Write($"Ingrese el nombre del pais {f + 1}: ");
                paises[f] = Console.ReadLine();

                // solicitar las cidades
                for (int c = 0; c < ciudades.GetLength(1); c++)
                {
                    Console.Write($"Ingrese las ciudades {c + 1}: ");
                    ciudades[f] =(System.Console.ReadLine());
                }
            }
        }

     static void Main(string[] args)
    {
        matrizEjercicio matrizejercicio = new matrizEjercicio();
            matrizEjercicio.CargarMatriz();
        
    }
}
}


