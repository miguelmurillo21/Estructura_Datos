using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio3
{

    public static class Program 
    {
        public static void Main() 
        {
        	int Numero1;
        	int Numero2;
        	int Operacion;
        	int Resultado;
        	
           Console.WriteLine("Digite El Primer Valor");
           Numero1 = int.Parse(System.Console.ReadLine());
           Console.WriteLine("Digite El Segundo Numero");
           Numero2 = int.Parse(System.Console.ReadLine());
           Console.WriteLine("Que Operacion Deseas Realizar: Suma (1), Resta (2), Multiplicación (3) O División (4)");
           Operacion = int.Parse(System.Console.ReadLine());
           if(Numero1>=100);
           {
              if (Operacion=1);
              {
           	   Resultado = Numero1+Numero2;
            	Console.WriteLine("El Resultado De La Suma Es {0} ", Resultado);
              }
              if(Operacion=2);{
           	  Resultado = Numero1-Numero2;
           	  Console.WriteLine("El Resultado De La Redta Es {0}", Resultado);
              }
              if(Operacion=3);
              {
             	Resultado = Numero1*Numero2;
            	Console.WriteLine("El Resultado De La Multiplicacion Es {0}", Resultado);
              }
              if(Operacion=4);
              {
           	  Resultado = Numero1/Numero2;
           	  Console.WriteLine("El Resultado De La Division Es {0}", Resultado);
              }
            }
            Console.WriteLine("El Numero No Es Mayor A 100");
        }
    }
}