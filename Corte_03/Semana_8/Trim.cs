using System;

namespace trim
{
   class Trim
   {
    static void Main(string[] args)
        {
            string palabra1 = "   Hello";
            string palabra2 = "  World";
            string palabra3 = " :D";

            Console.WriteLine("Antes");
            Console.WriteLine(palabra1);
            Console.WriteLine(palabra2);
            Console.WriteLine(palabra3);

            Console.WriteLine("despues");
            Console.WriteLine(palabra1.Trim());
            Console.WriteLine(palabra2.Trim());
            Console.WriteLine(palabra3.Trim());

        }
   }
}