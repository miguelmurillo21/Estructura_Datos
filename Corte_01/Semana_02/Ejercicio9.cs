using system;
using System.Ling;
using System.Collections;
using System.Collections.Generic;


namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int Base, Altura, Divisor = 0;
            double r, area;
            const double PI = 3.141592;
            string opción ="";
            int Divisor = 2;

            console.WriteLine("T - Triangulo");
            console.WriteLine("C - Circulo");

            Console.Write("Que Figuras deseas hacer: ");
            Opción = Console.ReadLine();

            Console.Write("Digite la Base : ");
            Base = int.Parse(System.Console.ReadLine());

            Console.Write("Digite la Altura: ");
            Altura = int.Parse(System.Console.ReadLine());

            Console.Write("Digite el radio: ");
            r = double.Parse(System.Console.ReadLine());


            switch (opción)
            {
                
                case T 
                    area = Base * Altura / Divisor;
                    Console.WriteLine($"El area del Triangulo es: {area} ");
                break;
                

                case C
                    area = PI*r*r;
                    Console.WriteLine($"El area del Circulo es: {area} ");
                break;        
            }

        }
    }
}
           
    
      



    
