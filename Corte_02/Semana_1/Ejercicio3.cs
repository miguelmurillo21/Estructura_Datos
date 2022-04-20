using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio03
{
    class program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;

            Console.WriteLine("Ingresar el número límite");
            cantidad = int.Parse(System.Console.ReadLine());

            Random aleat = new Random();
            int num = aleat.Next(1, cantidad);
            Console.WriteLine("" + num);
            int min = 0;

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(", ");
                if (num < cantidad)
                    min = cantidad - num;
            }


            Console.WriteLine("El número menor es " + min);
            Console.ReadKey();

        }
    }
}