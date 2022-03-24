using System;

namespace ejercicio5
{
    public class ejer5
    {
        static void Main(string[] args)
        {
           int[] mayusculas = new int [26];
            for (int i = 0; i < 26; i++)
            {
                mayusculas [i] = (int)i;
            }

            string cadena = "";
            int eleccion = -1;

            do
            {
                Console.WriteLine ("elija entre el 0 y " + (mayusculas.Length - 1));
                eleccion = int.Parse (Console.ReadLine());

                if(!(eleccion >= 0 && eleccion <= mayusculas.Length - 1))
                {
                    Console.WriteLine("Error inserte otro numero");
                }else
                {
                    if(eleccion != -1)
                    {
                        cadena += mayusculas [eleccion];
                    }
                }
            }while (eleccion != -1);

            Console.WriteLine (cadena);


            
            
        }
    }
}
