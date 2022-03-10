using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio2 
{
    class Program
    {
        static void Main(string[] args)
        {
            int Piramide = 0;
            Console.WriteLine("De Que Tamaño Vamos A Realizar La Piramide");
            Piramide = int.Parse(Console.ReadLine());
            int valor = Piramide;
            if (Piramide%2==0)
                for (int i=0;i<val;i++)
                {
                    Console.WriteLine(new String(' ', val-i-1) + new String('*', i+i+1));
                }
             else
                Console.WriteLine("La piramide es imposible");
        }
    }
}