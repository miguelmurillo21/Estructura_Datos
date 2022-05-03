using System;

namespace ToLower

{
    class ToLower
    {
        static void Main(string[] args)
        {
            string Mayusculas = "HELLO WORLD";

            Console.WriteLine("Antes");

            Console.WriteLine(Mayusculas);

            string Minuscula = Mayusculas.ToLower();

            Console.WriteLine("Despues");

            Console.WriteLine(Minuscula);
        }
    }
}