using System;

namespace ejrcicio12
{
    class program
    {
        static void Main(string[] args)
        {
            int v1=0,v2=0, v3=0, voto, maximo;
            int op1, op2, op3;
            string ganador;

            Console.WriteLine("1-Danna");
            Console.WriteLine("2-Nicolas");
            Console.WriteLine("3-Fran");
            Console.WriteLine("4-Salir");

            do
            {
                Console.WriteLine("Ingrese el voto :");
                voto = int.Parse(Console.ReadLine());
                if (voto == 1) ;
                {
                    v1 = v1 + 1;
                }

                 if (voto == 2)
                {
                    v2 = v2 + 1;
                }   
                 if (voto == 3)
                {
                    voto = v3 + 1;
                }

            } while (voto != 4);

            op1 = v1;
            op2 = v2;
            op3 = v3;

            Console.WriteLine("Danna tiene: {0}", op1);
            Console.WriteLine("Nicolas tiene: {0}", op2);
            Console.WriteLine("Fran tiene: {0}", op3);

            maximo = v1;
            ganador = "Danna";
            if(v2 > maximo)
            {
                ganador = "Nicolas";
            }
            if (v3 > maximo)
            {
                ganador = "Fran";
            }
            Console.WriteLine("El voto maximo es de:ganador: {0}", ganador);
        }
        
    }
}