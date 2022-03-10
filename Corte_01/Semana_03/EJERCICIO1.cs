using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio1
{
    class program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int n = 0;
            int i = 0;
            Console.WriteLine("Ingrese un número");
            num = int.Parse(Console.ReadLine());

            for (i = 0; i <= num; i++)
            {

                for (int j = 1; j <= n; j++)
                {

                    Console.Write("");
                    Console.Write("{0}", n);

                }
                Console.Write("\n");
                n = n + 1;
            }
            Console.ReadKey();
        }
    }
}