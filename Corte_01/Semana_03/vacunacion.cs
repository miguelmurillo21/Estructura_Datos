using System;
using System.linq;
using System.collections;
using System.collections.Generic;

namespace vacunacion
 {
  class Program 
   {
    static void main(string[]args)
    {
        
      int n=0;
      int Acumulador = 0;
       Console.WriteLine("escriba su numero entre el 100 y 200");
       numero = double.parse(Console.ReadLine());
      for (n = numero; n <= 200; n+2);
    {
     console.WriteLine("los numeros son") + n;
    }
    if (n=200)
         { 
           
            console.WriteLine("se estan acabando las reservas = ",n);
         }
         else
         {
             console.WriteLine("todavia hay reservas ",n );
         }
   }
 }
}