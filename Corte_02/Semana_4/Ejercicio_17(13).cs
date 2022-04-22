using System;
using System.Collections;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue ColaC = new Queue();
            Stack Pila = new Stack();

            ColaC.Enqueue(1.5);
            ColaC.Enqueue(3.9);
            ColaC.Enqueue(6.3);
            ColaC.Enqueue(8.7);
            ColaC.Enqueue(11.1);
            ColaC.Enqueue(13.5);


            Console.WriteLine("la cola inicial es: ");

            while (ColaC.Count > 0)
            {
                double Co = 0.0F;
                Co = (double)ColaC.Dequeue();
                Console.WriteLine($"  Cola: {Co}");
                Pila.Push(Co); 
            }
            
            Console.WriteLine("La pila creada: ");
            while (Pila.Count > 0)
            {
                Console.WriteLine($"  Pila: {Pila.Pop()}");
            }
        }
    }
}