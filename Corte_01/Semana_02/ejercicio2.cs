using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, nnatur, contap = 0, contai = 0, sumap = 0, sumi = 0;
            Console.WriteLine("Límite de números");
            p = int.Parse(System.Console.ReadLine());

            while (p > 0)
            {
                Console.WriteLine("Ingrese un número");
                nnatur = int.Parse(System.Console.ReadLine());

                if (nnatur % 2 == 0)
                {

                    contap = contap + 1;
                    sumap = sumap + nnatur;
                }
                else
                {
                    contai = contai + 1;
                    sumi = sumi + nnatur;
                }
                p = p - 1;
            }

            Console.WriteLine("El resultado de # pares es: {0} ", contap);
            Console.WriteLine("El resultado de # impares es: {0}", contai);
            Console.WriteLine("El promedio de # pares es de: {0} ", sumap / contap);
            Console.WriteLine("El promedio de # impares es de: {0} ", sumi / contai);
            Console.WriteLine("El resultado de la suma de # pares es de: {0} ", sumap);
            Console.WriteLine("El resultado de la suma de # impares es de: {0} ", sumi);
        }
    }
}