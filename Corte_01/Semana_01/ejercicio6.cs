using System;
using System.linq;
using System.collections;
using System.collections.Generic;

namespace ejercicio6
{
    class program 
    {
        static void Main(string[]args)
        {   
        int a,b,c = 0;
        float segundos,fase1,fase2,horas,minutos;
       console.writeLine("escribe tu valor en segundos ");  
       segundos=float.parse=(System.Console.ReadLine());
       fase1 = (segundos * 1 / 3600);
       fase2 =(fase1*1/24);
       horas = (segundos/3600) * 60; 
       minutos= segundos/60;
       

        console.writeLine(" tu conversión de acuerdo a los segundos dados son ");
        console.writeLine("dias{0} ,horas{1} ,minutos{2}, y sus segundos {3} ".fase2 ,horas ,minutos ,segundos);
        }
    }

}