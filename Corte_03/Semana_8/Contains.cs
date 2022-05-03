using System;
using System.Collections;

namespace Ejercicio_Contains
{
    class program
    {
        static void Main(String[] args)
        {
            String frase = "Siempre da lo mejor de ti, y lo mejor vendrá";

            Console.WriteLine("La frase es: " + frase);

            String contador1 = "S";
            String contador2 = "mejor";
            String contador3 = "k";
            String contador4 = "m";
            String contador5 = "q";
            String contador6 = "como";

            Console.WriteLine(frase.Contains(contador1));
            Console.WriteLine(frase.Contains(contador2));
            Console.WriteLine(frase.Contains(contador3));
            Console.WriteLine(frase.Contains(contador4));
            Console.WriteLine(frase.Contains(contador5));
            Console.WriteLine(frase.Contains(contador6));

            Console.ReadLine();

        }
    }
}