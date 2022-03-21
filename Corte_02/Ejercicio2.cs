using System;

namespace ejercicio2
{
    class program
    {

        string[] valor;
        int numero;
        int suma;
        int total;

        public void imprimir_sumar()
        {

            do
            {
                Console.WriteLine("¿cuantos valores vas a ingresar?");
                numero = int.Parse(Console.ReadLine());
            } while (numero <= 0);
            valor = new string[numero];

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("intruduce valores: ");
                valor[i] = Console.ReadLine();
            }
            Console.WriteLine(" Se Guardaron " + numero + "valores \n presiona enter para velos");
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("posicion" + i + " : " + valor[i]);
                suma = suma + numero;
            }
            Console.WriteLine("la suma es :" + suma );
            

        }
        static void Main(string[] args)
        {
            program program = new program();
            program.imprimir_sumar();
        }
          


    }
    
  
}