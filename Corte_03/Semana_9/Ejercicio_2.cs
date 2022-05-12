using System;

namespace Ejercicio_2
{
    

    public class Operacion
    {

        protected int valor1;
        protected int valor2;
        protected int resultado;


        public int Valor1
        {
            set
            {
                valor1 = value;
            }
            get
            {
                return valor1;
            }
        }

        public int Valor2
        {
            set
            {
                valor2 = value;
            }
            get
            {
                return valor2;
            }
        }

        public int Resultado
        {
            protected set
            {
                resultado = value;
            }
            get
            {
                return resultado;
            }
        }
    }

   

    public class Suma : Operacion
    {
        public void Operar()
        {
            Resultado = Valor1 + Valor2;
        }
    }


    public class Resta : Operacion
    {
        public void Operar()
        {
            Resultado = Valor1 - Valor2;
        }
    }

    public class Multiplicación : Operacion
    {
        public void operacion()
        {
           Resultado = Valor1 * Valor2;
        }
    }

    public class Division : Operacion
    {
        public void operacion()
        {
            Resultado = valor1 / Valor2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Suma  new_suma = new Suma();
            new_suma.Valor1 = 10;
            new_suma.Valor2 = 5;
            new_suma.Operar();
            Console.WriteLine("La suma de " +  new_suma.Valor1 + " y la de " + new_suma.Valor2 + " es " + new_suma.Resultado);

            Resta new_resta = new Resta();
            new_resta.Valor1 = 20;
            new_resta.Valor2 = 4;
            new_resta.Operar();
            Console.WriteLine("La resta de " + new_resta.Valor1 + " y la de " + new_resta.Valor2 + " es " + new_resta.Resultado);

            Multiplicación new_multiplicacion = new Multiplicación();
            new_multiplicacion.Valor1 = 22;
            new_multiplicacion.Valor2 = 5;
            new_multiplicacion.operacion();
            Console.WriteLine("La multiplicación de " + new_multiplicacion.Valor1 + " y la de " + new_multiplicacion.Valor2 + " es " + new_multiplicacion.Resultado);

            Division new_division = new Division();
            new_division.Valor1 = 20;
            new_division.Valor2 = 5;
            new_division.operacion();
            Console.WriteLine("La división de " + new_division.Valor1 + " y la de " + new_division.Valor2 + " es " + new_division.Resultado);
            Console.ReadKey();
        }
    }
}