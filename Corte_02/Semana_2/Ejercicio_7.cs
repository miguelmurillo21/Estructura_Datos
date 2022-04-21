using System;
using System.Collections;
using System.Linq;

namespace Ejercicio7
{
    public class Program 
    {

         public static void main(String[] args) {
 
            int Consumo = 0;
            int precio = 0;
            int pago = 0;

            Console.WriteLine("Ingrese el consumo de energia KiloWats");
            Consumo = Console.ReadLine(); 
            Console.WriteLine("Su consumo es de: " + Consumo);
            Console.WriteLine("Digita el costo por KiloWat");
            precio = Console.ReadLine();
            Console.WriteLine("El costo por kilowat es:" + precio);
            pago = Consumo * precio;
            Console.WriteLine("El pago por la energia es: " + pago);
         }
    }
}