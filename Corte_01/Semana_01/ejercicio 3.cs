using System;
using System.Ling;
using System.Collections;
using System.Collections.Generic;

namespace calificaciones
{
    class program
    {
        static void Main(string[] args)
        {
        float Nota1 = 4.0f;
        float Nota2 = 4.5f;
        float Nota3 = 5.0f;
        float Promedio = 0.0f;
        float Nmax = 0.0f;
        float Nmin = 0.0f;
        float DIV = 3.0f;

        Console.WriteLine("Saquemos el promedio");
        Console.WriteLine("");
        Console.WriteLine("Introduce las 3 notas");

        Nota1 = float.Parse(System.Console.ReadLine());
        Nota2 = float.Parse(System.Console.ReadLine());
        Nota3 = float.Parse(System.Console.ReadLine());

        Promedio = Nota1 + Nota2 + Nota3 / DIV;

        Nmax = Nota3;

        Nmin = Nota1;

        Console.WriteLine("** El promedio es {0}**", Promedio);
        Console.WriteLine("** La nota mayor es {0}**", Nmax);
        Console.WriteLine("** El promedio es {0}**", Nmin);
         
    

            
        }
    }
}