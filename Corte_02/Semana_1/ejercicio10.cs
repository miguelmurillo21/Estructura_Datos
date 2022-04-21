using System;

namespace AplicacionBase
{
    class Matrizalumnos
    {
        // Declaramos dos vectores y una matriz
        string[] alumnos = new string[4];
        int[,] nota = new int[4, 3];
        private int[,] matriz;

        public void CargarMatriz()
        {
            for (int f = 0; f < alumnos.Length; f++)
            {


                Console.Write($"Ingrese el nombre del idioma {f + 1}: ");
                alumnos[f] = Console.ReadLine();

                // Ciclo para solicitar el sueldo de cada mes del empleado
                for (int c = 0; c < nota.GetLength(1); c++)
                {
                    Console.Write($"Ingrese su desempecho  {c + 1}: ");
                    nota[f, c] = int.Parse(System.Console.ReadLine());
                }
            }
        }



        public void ImprimirTotal()
        {
            Console.WriteLine("matriz ");

            for (int f = 0; f < matriz.Length; f++)
            {
              
                Console.WriteLine("        " + alumnos[f] + " es" +nota[f]);
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
