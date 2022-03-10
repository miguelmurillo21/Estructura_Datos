using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace problema12
{
    class Program
    {
        static void Main(string[] args, double v)
        {
            int metros,valortotal1,valortotal2,valortotal3;
        string cable;
            Console.WriteLine("hay 3 tipos de cables diferentes, uno red, dos normal,tres grueso");

            Console.WriteLine("Introduce que cable necesita en letras");
        cable = Console.ReadLine();
            Console.WriteLine("Introduce cuantos metros necesita ");
            metros =int.Parse(Console.ReadLine());


            switch (cable)
        {
            case "uno":  Console.WriteLine("cable de red, costo por metro de 5000");
                    valortotal1 = metros * 5000;
                    Console.WriteLine("cable de red le vale",valortotal1);
                    break;
            case "dos": Console.WriteLine("cable noraml,costo por metro de 2500");
                    valortotal2 = metros * 2500;
                    Console.WriteLine("cable  le vale", valortotal2);
                    break;
                    
            case "tres":
            Console.WriteLine("cable grueso tiene un costo por metro de 8000");
                    valortotal3 = metros * 8000;
                    Console.WriteLine("cable le vale", valortotal3);
                    break;
                   //falta agregar los descuentos condicionales a los metros 
            }

        }
    }

}








