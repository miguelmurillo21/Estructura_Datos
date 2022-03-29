using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio07
{
    class Calificaciones
    {
        string[] nombres;
        double nota;
        int CANTIDAD = 12;
        public void Estudiantes()
        {
            int cant = 0;
            double n = 0;
            string nom;
            nombres = new string[CANTIDAD];

            Console.Write("Ingrese el nombre del estudiante: ");
            nom = Console.ReadLine();
            Console.Write("Ingrese nota del 0 al 10");
            n = int.Parse(Console.ReadLine());

            if (n < 5) {
                Console.WriteLine("La nota es insuficiente");
            }
            if (n < 5 && n > 7) {
                Console.WriteLine("La nota es aceptable");
            }
            if (n < 7 && n > 9) {
                Console.WriteLine("La nota es sobresaliente!");
            }
            if (n < 9 && n > 10) {
                Console.WriteLine("La nota es excelente!");
            }
            Console.WriteLine("El estudiate" + nom + "tuvo una calificación: " + n);
            
        }

        static void Main(string[] args)
        {
            Calificaciones vector = new Calificaciones();
            vector.Estudiantes();
        }
    }
}