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
            int a;
            int b;
            int c;
            int d;
            string Proceso = "";
          Console.WriteLine("A continuacion ingresaras 4 numeros los cuales no deben repetirse");
          Console.WriteLine("Ingresa el primer valor");
            a = int.Parse(System.Console.ReadLine());
          Console.WriteLine("Ingresa el segundo valor");
            b = int.Parse(System.Console.ReadLine());
          Console.WriteLine("Ingresa el tercer valor");
            c = int.Parse(System.Console.ReadLine());
          Console.WriteLine("Ingresa el cuarto valor");
            d = int.Parse(System.Console.ReadLine());
            if (a != b && a != c && a != d && b != c && b != d && c != d)
            {
                Console.WriteLine("Que proceso deseas realizar, para buscar el mayor ingresa 'mayor' o para el menor ingresa 'menor'");
                Proceso = Console.ReadLine();
                switch (Proceso)
                {
                    case "mayor":
                        if (a > b && a > c && a > d)
                        {
                            Console.WriteLine($"El mayor es {a}");
                        }
                        if (b > a && b > c && b > d)
                        {
                            Console.WriteLine($"El mayor es {b}");
                        }
                        if (c > a && c > b && c > d)
                        {
                            Console.WriteLine($"El mayor es {c}");
                        }
                        if (d > a && d > b && d > c)
                        {
                            Console.WriteLine($"El mayor es {d}");
                        }
                        break;
                    case "menor":
                        if (a < b && a < c && a < d)
                        {
                            Console.WriteLine($"El menor es {a}");
                        }
                        if (b < a && b < c && b < d)
                        {
                            Console.WriteLine($"El menor es {b}");
                        }
                        if (c < a && c < b && c < d)
                        {
                            Console.WriteLine($"El menor es {c}");
                        }
                        if (d < a && d < b && d < c)
                        {
                            Console.WriteLine($"El menor es {d}");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Recuerda que los numeros no se pueden repetir");
            }

        }
    }
}