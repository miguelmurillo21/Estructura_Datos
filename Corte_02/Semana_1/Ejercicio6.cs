using System;
using System.Linq;
using System.Collections;

namespace Ejercicio6
{
    class program
    {
        int[] vector;
        int vectort;
        public void cargarvec()
        {
            Console.Write("Digita la longitud del vector");
            vectort = int.Parse(System.Console.ReadLine());
            vector = new int[vectort];
        }
        public void random()
        {
            aleatorio random = new aleatorio();
            for (int f=0; f<vector.Length; f++)
            {
                vector[f] = (random.Next(1, 300) +1);
            }
        }
        public void mostrar()
        {
            for (int f=0; f<vector.Length; f++)
            {
                Console.WriteLine("En el indice " +f+ " Se encuentra en numero " + vector[f]);
            }
        }
        public void digito()
        {
            Console.Write("Ingrese un numero del 0 al 9");
            int A=int.Parse(System.Console.ReadLine());
            if (A>=0 && A<=9)
            {
                string numero = A.ToString();
                for (int f=0; f<vector.Length; f++)
                {
                    string num = vector[f].ToString();
                    string ult = numeros.Substring(numeros.Length-1);
                    if (ult==num)
                    {
                        Console.Write("El numero es " +Vector[f]+ " del vector que su ultimo digito es " +ult+"\n");
                    }
                }
            }
            else
            {
                Console.Write("El numero que ingresaste no es valido \n");
            }            
        }
        static void Main(string[] args)
        {
            program Program = new program();
            Program.cargarvec();
            Program.random();
            Program.mostrar();
            Program.digito();
        }
    }
}