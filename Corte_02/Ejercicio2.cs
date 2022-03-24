using System;

namespace ejercicio2
{
    class program
    {

       private int[] valor;
        int NUMERO;
        int suma;
        int total;

        public void imprimir()
        {

            do
            {
                Console.WriteLine("¿cuantos valores vas a ingresar?");
                NUMERO = int.Parse(Console.ReadLine());
            } while (NUMERO <= 0);
            valor = new int[NUMERO];

            for (int i = 0; i < NUMERO; i++)
            {
                Console.WriteLine("intruduce valores: ");
                valor[i] = Console.ReadLine();
            }
            Console.WriteLine(" Se Guardaron " + NUMERO + "valores \n presiona enter para velos");
        }
        public void sumar()
        {
            Console.WriteLine("El vector resultante es ");

            for(int i = 0;i < NUMERO;  i++)
            {
                suma += valor[i]; 
                Console.WriteLine("  " + valor[i] + "  ");
            }
            Console.WriteLine($"El resultado de los valores del vector es : {suma}");
        }

        static void Main(string[] args)
        {
            program program = new program();
            program.imprimir();
            program.sumar();
        }
          


    }
    
  
}