using System;
using System.Collections;

namespace split

{
    class split
    {
        static void Main(string[] args)
        {
            string palabra = "Profe pongame-un+cinco//todo$$bien";

            string[] array = palabra.Split(' ', '-', '+', '/', '$');

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}