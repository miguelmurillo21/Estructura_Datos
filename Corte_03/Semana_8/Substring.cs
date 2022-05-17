using System;

namespace substring
{
    class Palabra
    {
        public static void Main()
        {


            String palabra = "Hello World";

            Console.WriteLine("String    : " + palabra);

            Console.WriteLine("Sub palabra: " + palabra.Substring(5));

            Console.WriteLine("Sub palabra: " + palabra.Substring(8));
        }
    }
}
