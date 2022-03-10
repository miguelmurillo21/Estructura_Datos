using System;

namespace ejrcicio9
{
    class program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int Opcion = 0;

            Console.WriteLine("1, - nivel 1");
            Console.WriteLine("2, - nivel 2");
            Console.WriteLine("3, - nivel 3");

            Console.Write("Que operación deseas hacer: ");
            Opcion = int.Parse(System.Console.ReadLine());

            Console.Write("Dame el primer numero por favor: ");
            n1 = int.Parse(System.Console.ReadLine());

            Console.Write("Dame el segundo numero por favor: ");
            n2 = int.Parse(System.Console.ReadLine());

            Console.Write("Dme el tercer numero por favor: ");
            n3 = int.Parse(System.Console.ReadLine());

            switch (Opcion)
            {
                case 1:
                    if(n1 == n2 && n2 == n3 && n1 == n3)
                    {
                        Console.WriteLine("El triangulo es equilatero");
                    }
                    if ((n1 == n2 && n2 != n3 && n1 != n3) || (n1 != n2 && n2 != n3 && n3 == n1) || (n1 != n2 && n2==n3 && n3 != n1))
                    {
                        Console.WriteLine("El triangulo es isoceles");
                    }
                    if (n1 != n2 && n2!=n3 && n3 != n1)
                    {
                        Console.WriteLine("El triangulo es escaleno");
                    }
                    break;

                case 2:
                    if (n1 == n2 && n2 == n3 && n1 == n3)
                    {
                        Console.WriteLine("El triangulo es equilatero");
                    }
                    if ((n1 == n2 && n2 != n3 && n1 != n3) || (n1 != n2 && n2 != n3 && n3 == n1) || (n1 != n2 && n2 == n3 && n3 != n1))
                    {
                        Console.WriteLine("El triangulo es isoceles");
                    }
                    if (n1 != n2 && n2 != n3 && n3 != n1)
                    {
                        Console.WriteLine("El triangulo es escaleno");
                    }
                    break;

                case 3:
                    if (n1 == n2 && n2 == n3 && n1 == n3)
                    {
                        Console.WriteLine("El triangulo es equilatero");
                    }
                    if ((n1 == n2 && n2 != n3 && n1 != n3) || (n1 != n2 && n2 != n3 && n3 == n1) || (n1 != n2 && n2 == n3 && n3 != n1))
                    {
                        Console.WriteLine("El triangulo es isoceles");
                    }
                    if (n1 != n2 && n2 != n3 && n3 != n1)
                    {
                        Console.WriteLine("El triangulo es escaleno");
                    }
                    break;


            }


        }
    }
}