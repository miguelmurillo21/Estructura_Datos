using System;
using System.Linq;
using System.Collections;

namespace Ejercicio8
{
      class program
    {
        double[] alt;
            public void Op()
        {
            int cantidad;
            double sum= 0, alt1= 0, prom= 0;
            Console.WriteLine("Digita la cantidad de personas");
            cantidad=int.Parse(System.Console.ReadLine());
            double[] alt = new double[cantidad];
            for (int f=0; f<cantidad; f++)
            {
                Console.WriteLine("Digita la altura");
                alt[f]=double.Parse(System.Console.ReadLine());
                sum=sum+alt[f];
                prom=sum/cantidad;
            }
            Console.WriteLine("El resultado de la media es: " + prom);
            for (int x=0; x<cantidad; i++)
            Array.Sort(alt);
            Console.WriteLine("La altura menor es: " + alt[0]);
            Console.WriteLine("La altura mayor es: " + alt[cantidad-1]);
        }
                static void Main(string[] args)

        {
            program Metodo = new program();
            Metodo.Op();
        }
    }
}