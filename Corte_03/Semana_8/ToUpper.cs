using System;

namespace ToUpper

{
    class ToUpper
    {
        static void Main(string[] args)
        {
            string minusculas = "hello world";

            Console.WriteLine("Antes");

            Console.WriteLine(minusculas);

            string mayusculas = minusculas.ToUpper();

            Console.WriteLine("Despues");

            Console.WriteLine(mayusculas);
        }
    }
}