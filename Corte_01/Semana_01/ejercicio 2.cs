using System;
using System.Ling;
using System.Collections;
using System.Collections.Generic;

namespace calificaciones{
    class program
    {
         static void Main(string[] args)
        {
        int peli1 = 3000;
        int peli2 = 2500;
        int peli3 = 5000;
        int total = 0;
            
        Console.WriteLine("Saquemos el total");
        Console.WriteLine("");
        Console.WriteLine("Introduce las 3 peliculas");

        peli1 = float.Parse(System.Console.ReadLine());
        peli2 = float.Parse(System.Console.ReadLine());
        peli3 = float.Parse(System.Console.ReadLine());

        total = peli1 + peli2;

        Console.WriteLine("** El total a pagar es {0}**", total);

        }
    }
   
}

   