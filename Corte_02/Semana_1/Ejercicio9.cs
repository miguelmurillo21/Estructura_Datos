using System;
using System.Collections;
using System.Linq;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {           
            int nfil = 28;
            int ncolum = 7;
            int A = 0;
            int B = 0;
            int N = 1;
            int[,] tabla = new int[columnas, filas];
            string comb = "";
            int[] op = new int[6];
            int Z = 0;
            do
            {
                Console.WriteLine("Digita la cantidad de apuestas que deseas realizar");
                Z=comprobar(Console.ReadLine());
                for (int c=0; c<=6; c++)
                {
                    for (int d=0; d<7; d++)
                    {
                        tabla[d, c] = N;
                        N++;
                    }
                }
                for (int c=0; c<=6; c++)
                {
                    A= c+6;
                    for (int d=0; d<7; d++)
                    {
                        B= d*4;
                        Console.SetCursorPosition(B, A);
                        Console.Write(tabla[d, c]);
                    }
                }
                for (int count=1; count<=Z; count++)
                {
                    int x = 0;
                    Console.SetCursorPosition(0, 04);
                    Console.WriteLine("Apuesta {0}: ", count);
                    op[0] = aleatorio.Next(1, 50);
                    op[1] = aleatorio.Next(1, 50);
                    op[2] = aleatorio.Next(1, 50);
                    op[3] = aleatorio.Next(1, 50);
                    op[4] = aleatorio.Next(1, 50);
                    op[5] = aleatorio.Next(1, 50);
                    for (int c=0; c<=6; c++)
                    {
                        A= c+6;
                        for (int d=0; d<7; d++)
                        {
                            B= d*4;
                            Console.SetCursorPosition(B, A);
                            x++;
                            Console.Write("{0}", n);
                            if (op[0]== x || op[1]== x || op[2]== x || op[3]== x || op[4]== x || op[5]== x)
                            {
                                Console.Write((" X"), Console.ForegroundColor= ConsoleColor.Blue);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.ReadLine();
                            }
                        }
                    }
                }
                Console.WriteLine("\n" + "\n" + "¿Quieres generar una combinacion diferente? S/N");
                comb= (Console.ReadLine());
            } while (combinar=="S" || combinar=="s");
        }
    }
}
