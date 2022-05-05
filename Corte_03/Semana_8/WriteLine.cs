using System;
using System.Collections;
using System.Text;

namespace Ejercicio_WriteLine
{
    class program
    {
        static void Main(String[] args)
        {
            StringBuilder alfabeto = new StringBuilder("LMN", 50);

            alfabeto.Append(new char[] { 'O', 'P', 'Q' });

            alfabeto.AppendFormat("RST{0}{1}", 'U', 'V');

            Console.WriteLine("{0} letras: {1}", alfabeto.Length, alfabeto.ToString());

            alfabeto.Insert(0, "abecedario: ");

            

            Console.WriteLine("27 letras del abecedario", alfabeto.Length);
        }
    }
}