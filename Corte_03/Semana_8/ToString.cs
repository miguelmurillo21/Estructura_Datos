using System;
using System.Collections;
using System.Text;

namespace Ejercicio_ToStringob
{
    class program
    {
        static void Main(String[] args)
        {
            trabajadores trabajador1 = new trabajadores("Camilo", "García Marquez","65478396754", "Medicina General", new DateTime(2022, 03, 5));
            trabajadores trabajador2 = new trabajadores("Andrea", "Montenegro Benitez", "1013786345", "Cirugía Plástica", new DateTime(2022, 03, 5));
            trabajadores trabajador3 = new trabajadores("Diego", "Hurtado Morato", "9321456872", "Pediatría", new DateTime(2022, 03, 5));
            trabajadores trabajador4 = new trabajadores("Daniela", "Pérez Muñoz", "11759009821", "Neurología", new DateTime(2022, 03, 5));
            Console.WriteLine(trabajador1.ToString());
            Console.WriteLine();
            Console.WriteLine(trabajador2.ToString());
            Console.WriteLine();
            Console.WriteLine(trabajador3.ToString());
            Console.WriteLine();
            Console.WriteLine(trabajador4.ToString());
            Console.ReadKey();
        }
    }
    class trabajadores
    {
        String nomb, ap, documento,a;
        DateTime fechaingreso;

        public trabajadores(string nom, string ape,String cc, string area, DateTime fechain)
        {
            nomb = nom;
            ap = ape;
            documento = cc;
            a = area;
            fechaingreso = fechain;
        }
        public override string ToString()
        {
            return "Nombre: " + nomb + "\n" + "Apellidos: " + ap + "\n" + "Documento: " + documento + "\n" + "Área: " + a + "\n" + "Fecha de Ingreso: " + fechaingreso;
        }

    }
}