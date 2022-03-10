using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace Problema_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int agua, gas, luz;
            double primestrato = 0.20;
            double segunestrato = 0.15;
            double terestrato = 0.9;
            int Estrato = 0;

            Console.WriteLine("pimestrato - 1");
            Console.WriteLine("segestrato - 2");
            Console.WriteLine("terestrato - 3");

            Console.WriteLine("Ingrese su estrato");
            Estrato = int.Parse(System.Console.ReadLine());

            Console.WriteLine("Ingrese el valor del agua");
            agua = int.Parse(System.Console.ReadLine());

            Console.WriteLine("Ingrese el valor del gas");
            gas = int.Parse(System.Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la luz");
            luz = int.Parse(System.Console.ReadLine());

            switch (Estrato == 1) {
                case 1:
                    primestrato = agua * 0.20;
                    primestrato = gas * 0.20;
                    primestrato = luz * 0.20;
                    Console.WriteLine("total de cada servicio a pagar", agua,gas,luz);
                    break;

                case 2:
                    segunestrato = agua * 0.15;
                    segunestrato = gas * 0.15;
                    segunestrato = luz * 0.15;
                    Console.WriteLine("total de cada servicio a pagar", agua, gas, luz);
                    break;

                case 3:
                    terestrato = agua * 0.9;
                    terestrato = gas * 0.9;
                    terestrato = luz * 0.9;
                    Console.WriteLine("total de cada servicio a pagar", agua, gas, luz);
                    break;
            }
        }
    }
}