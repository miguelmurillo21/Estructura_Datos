using System;
using System.Collections;


namespace Equals
{

    public class Program
    {
        public static void Main()
        { 
          String original = "hola";
          Console.WriteLine("el original: '{0}'", original);
          String modificado = original.Insert(3, " ");
          Console.WriteLine("el string modificado: '{0}'", modificado);
        }

    }
}