using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            string sw;
            do
            {
                double valor1;
                double valor2;
                double valor3;
                double valorx1;
                double valorx2;
                double operacion;
                Console.WriteLine("A continuacion solucionaremos una ecuacion de segundo grado");
                Console.WriteLine("Digita el primer valor");
                valor1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digita el segundo valor");
                valor2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digita el tercer valor");
                valor3 = double.Parse(Console.ReadLine());
                operacion = valor2 * valor2 - 4.0 * valor1 * valor3;
                if (operacion < 0)
                {
                    Console.WriteLine("Los resultados de la ecuacion son negativos");
                    operacion = -operacion;
                }
                else
                    Console.WriteLine("Los resultados de la ecuacion son los siguientes:");
                valorx1 = (-b + Math.Sqrt(operacion)) / (2 * valor1);
                valorx2 = (-b - Math.Sqrt(operacion)) / (2 * valor1);
                Console.WriteLine("x1 =" + valorx1);
                Console.WriteLine("x2 =" + valorx2);
                Console.WriteLine("Deseas realizar alguna otra operacion? s/n ");
                sw = Console.ReadLine();
                Console.Clear();
            } while (sw == "s");
        }
    }
}