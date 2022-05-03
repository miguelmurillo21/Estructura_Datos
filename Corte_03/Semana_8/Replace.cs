using System;
using System.Collections;

namespace Ejercicio_Replace
{
    class program
    {
        static void Main(String[] args)
        {
          String original = "Compro poco coco, porque como poco coco como, poco coco compro. ";

            Console.WriteLine("Trabalenguas: " + original);

            Console.WriteLine("Cadena 1: " + original.Replace('p', ' '));

            Console.WriteLine("\nCadena 2: " + original.Replace('o', 'a'));

            Console.WriteLine("\nCadena 3: " + original.Replace("coco", "mico"));

            Console.WriteLine("\nCadena 4: " + original.Replace('m', 'ñ'));

            Console.WriteLine("\nCadena 5: " + original.Replace("poco", "mucho"));
        }
    }
}