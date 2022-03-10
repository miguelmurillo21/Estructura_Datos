using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            double raiz;
            Console.WriteLine("Ingrese un número");
            num = double.Parse(Console.ReadLine());
            raiz = Math.Sqrt(num);

            Console.WriteLine("* La raíz cuadrada de {0} es {1} *", num, raiz);


        }
    }
}