using System;
using System.Collections;

namespace Ejercicio_Compare
{
    class program
    {
        static void Main(String[] args)
        {

            string p1 = "Carro";
            string p2 = "Moto";
            Console.WriteLine("Las palabras son: {0} y {1}", p1, p2);
            int resultado = p1.CompareTo(p2);

            if (resultado == 0)
            {
                Console.WriteLine("  Son iguales");
            }
            else if (resultado < 0)
            {
                Console.WriteLine("  Son diferentes");
            }

        }
    }
}