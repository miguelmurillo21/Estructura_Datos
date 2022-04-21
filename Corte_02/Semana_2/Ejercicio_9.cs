using System;
using System.Collections;
using System.Linq;

namespace Ejercicio9
{
    class Program
    {
        private int[,] marco;
        int Filas = 5;
        int Columnas = 15;

        public void cargar()
        {
            marco=new int[Filas, Columnas];

            for (int x=0; x<marco.GetLength(0); x++)
            {
                if(x==0 || x==4){
                    for (int a=0; a<marco.GetLength(1); a++)
                    {
                        Console.Write(" 1 ");
                    }
                }else{
                    for (int i=0; i<marco.GetLength(1); i++)
                    {
                        if(i==0 || i==14){
                        Console.Write("1 ");
                        }else{
                        Console.Write("0 ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program op = new Program();
            op.cargar();
        }
    }
}