using System;
using System.linq;
using System.collections;
using System.collections.Generic;

namespace collazs
{
    class program 
    {
        static void Main(string[]args)
        {   
           
          int numero1,fase1 = 0;
          console.writeLine("dame un numero ");  
          numero = console.ReadLine();
          numero1 = numero;
          while(numero1>1){
           if (numero1%2==0)
         { 
            numero1 =numero1/2; 
            console.WriteLine(" es{0} ",numero1);
            
         }
         else
         {
            numero1=(numero1*3)+1;
            console.WriteLine(" es{0} ",numero1);    
         }


            console.WriteLine(" la conjetura del numero {0}, es {1}  ",numero,numero1);
          }









        }
   }



}