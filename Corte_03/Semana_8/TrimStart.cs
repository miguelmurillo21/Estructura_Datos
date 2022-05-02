using System;

namespace trimStart
{
   class TrimStart
   {
    static void Main(string[] args)
        {
            string palabra1 = "   Galletas";
            string palabra2 = "//sabor";
            string palabra3 = "&&Chocolate";
            string palabra4 = "+Fresa";
            string palabra5 = "-Vainilla ";
            string borrar = string.Empty;

            string[] palabra = {palabra1, palabra2, palabra3, palabra4, palabra5};

            foreach (var word in palabra)
            {
                Console.WriteLine($"palabras con caracteres: {word}");
            }
            Console.WriteLine($"palabras sin caracteres: {borrar}");

            foreach (var edit in palabra)
            {
                Console.WriteLine(edit.TrimStart(' ', '/', '&', '+', '-'));
            }

        }
   }
}