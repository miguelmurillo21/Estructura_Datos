using System;

namespace AplicacionBase
{
    class Matrizalumnos
    {
        // Declaramos dos vectores y una matriz
        string[] conductor = new string[1];
        int[,] nota = new int[1,1];
        private int[,] matriz;

        public void CargarMatriz()
        {
            for (int f = 0; f < conductor.Length; f++)
            {


                Console.Write($"Ingrese el nombre del conductor {f + 1}: ");
                conductor[f] = Console.ReadLine();

                // horas 
                for (int c = 0; c < nota.GetLength(1); c++)
                {
                    Console.Write($"Ingrese sus kilometros  {c +1 }: ");
                    nota[f,c] = int.Parse(System.Console.ReadLine());
                }
            }
        }



        public void ImprimirTotal()
        {
            Console.WriteLine("matriz ");

            for (int f = 0; f < matriz.Length; f++)
            {

                Console.WriteLine(  conductor[f]);
                // horas 
                for (int c = 0; c < nota.GetLength(1); c++)
                {
                    Console.Write(nota);
                   
                }
            }


        }



        static void Main(string[] args)
        {
            Matrizalumnos matrizEmpleados = new Matrizalumnos();
            matrizEmpleados.CargarMatriz();

            matrizEmpleados.ImprimirTotal();

        }
    }
}

