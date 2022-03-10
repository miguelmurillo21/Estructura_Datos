using system;

namespace ejercicio8
{
    class program
    {
        static void Main(string[] args)
        {
            int Numero1 = 28; 
            int Numero2, Opción;
            int Mes = 0;
            
            Console.WriteLine("1 - Enero");
            Console.WriteLine("2 - Febrero");
            Console.WriteLine("3 - Marzo");
            Console.WriteLine("4 - Abril");
            Console.WriteLine("5 - Mayo");
            Console.WriteLine("6 - Junio");
            Console.WriteLine("7 - Julio");
            Console.WriteLine("8 - Agosto");
            Console.WriteLine("9 - Septiembre");
            Console.WriteLine("10 - Octubre");
            Console.WriteLine("11 - Noviembre");
            Console.WriteLine("12 - Diciembre");

            Console.Write("Que operación deseas hacer: ");
            Opcion = int.Parse(System.Console.ReadLine());

            
            Console.Write("Dame el segundo numero por favor: ");
            Numero_2 = int.Parse(System.Console.ReadLine());

            switch (Opción)
            {
                case 1:
                if (Numero2 ==3)
                   Mes = Numero1 + Numero2;
                    Console.WriteLine($"El numero de dia de Enero es: {Mes} ");
                else 
                   console.WriteLine("La opcion no es valida");
                break;

                case 2:
                 if (Numero2 ==0)
                   Mes = Numero1 + Numero2;
                   Console.WriteLine($"El numero de dia de Febrero es: {Mes} ");
                else 
                   console.WriteLine("La opcion no es valida");
                break;

                case 3:
                 if (Numero2 ==3)
                   Mes = Numero1 + Numero2;
                   Console.WriteLine($"El numero de dia de Marzo es: {Mes} ");
                else 
                   console.WriteLine("La opcion no es valida");
                break;

                case 4:
                 if (Numero2 ==2)
                   Mes = Numero1 + Numero2;
                   Console.WriteLine($"El numero de dia de Abril es: {Mes} ");
                else 
                   console.WriteLine("La opcion no es valida");
                break;

                case 5:
                 if (Numero2 ==3)
                   Mes = Numero1 + Numero2;
                   Console.WriteLine($"El numero de dia de Mayo es: {Mes} ");
                else 
                   console.WriteLine("La opcion no es valida");
                break;

                case 6:
                 if (Numero2 ==2)
                   Mes = Numero1 + Numero2;
                   Console.WriteLine($"El numero de dia de Junio es: {Mes} ");
                else 
                   console.WriteLine("La opcion no es valida");
                break;

                case 7:
                 if (Numero2 ==3)
                   Mes = Numero1 + Numero2;
                   Console.WriteLine($"El numero de dia de Julio es: {Mes} ");
                else 
                   console.WriteLine("La opcion no es valida");
                break;

                case 8:
                 if (Numero2 ==3)
                   Mes = Numero1 + Numero2;
                   Console.WriteLine($"El numero de dia de Agosto es: {Mes} ");
                else 
                   console.WriteLine("La opcion no es valida");
                break;

                case 9:
                 if (Numero2 ==2)
                   Mes = Numero1 + Numero2;
                   Console.WriteLine($"El numero de dia de Septiembre es: {Mes} ");
                else 
                   console.WriteLine("La opcion no es valida");
                break;

                case 10:
                 if (Numero2 ==3)
                   Mes = Numero1 + Numero2;
                   Console.WriteLine($"El numero de dia de Octubre es: {Mes} ");
                else 
                   console.WriteLine("La opcion no es valida");
                break;

                case 11:
                 if (Numero2 ==2)
                   Mes = Numero1 + Numero2;
                   Console.WriteLine($"El numero de dia de Noviembre es: {Mes} ");
                else 
                   console.WriteLine("La opcion no es valida");
                break;

                case 12:
                 if (Numero2 ==3)
                   Mes = Numero1 + Numero2;
                   Console.WriteLine($"El numero de dia de Diciembre es: {Mes} ");
                else 
                   console.WriteLine("La opcion no es valida");
                break;

                
            }

        }
    }
}