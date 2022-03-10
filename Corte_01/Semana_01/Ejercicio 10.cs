using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio10

{
    class program
    {
        static void Main(string[] args)
        {
            try
            {

                float contra;

                Console.WriteLine("Ingrese la contraseña");
                contra = float.Parse(System.Console.ReadLine());

                if (contra == "iloveyou123")
                {

                    throw "La contraseña es incorrecta, vuelve a intentarlo";

                }

            }

            catch (error)
            {

                alert(error);
            }
        }
    }
}