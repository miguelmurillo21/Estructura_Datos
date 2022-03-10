using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace problema1
{
    class Program
    {
        static void Main(string[] args, double v)
        {

            int largo, ancho, metros,V,predio;
            int precio;
            V = 4000;
           
                Console.WriteLine("ingrese el largo");
                largo = int.Parse(Console.ReadLine());
            
            
                    Console.WriteLine("ingrese el ancho");
                    ancho = int.Parse(Console.ReadLine());
               
                
                    Console.WriteLine("sus metros cuadrados son ");
                    metros = largo * ancho;
                
                 Console.WriteLine("el precio de un metro cuadrado es de 4000");
                precio = V;

            predio = precio * metros;

                Console.WriteLine("el precio de predio es de " ,predio);
                
            }


            


        }
    }