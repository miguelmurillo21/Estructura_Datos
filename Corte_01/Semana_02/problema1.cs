using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int mat1, mat2, mat3, mat4;

            {
                Console.WriteLine("calificacion materia 1");
                mat1 = Int32.Parse(Console.ReadLine());
                {
                    Console.WriteLine("calificacion materia 2");
                    mat2 = Int32.Parse(Console.ReadLine());
                }
                {
                    Console.WriteLine("calificacion materia 3");
                    mat3 = Int32.Parse(Console.ReadLine());
                }
                {
                    Console.WriteLine("calificacion materia ");
                    mat4 = Int32.Parse(Console.ReadLine());
                }
            }
            if (mat1 < 50)
            {
                Console.WriteLine("insuficiente");
            
            }
            if(mat1>=69 ||mat1<=50)
            {
                Console.WriteLine("suficiente");
            }
            if (mat1 >= 79 || mat1 <= 70)
            {
                Console.WriteLine("bien");
            }
            if (mat1 >89  || mat1 < 80)
            {
                Console.WriteLine("notable");
            }
            if (mat1 > 90 || mat1 < 100)
            {
                Console.WriteLine("sobresaliente");
            }
            if (mat2 < 50)
            {
                Console.WriteLine("insuficiente");

            }
            if (mat2 >= 69 || mat2 <= 50)
            {
                Console.WriteLine("suficiente");
            }
            if (mat2 >= 79 || mat2<= 70)
            {
                Console.WriteLine("bien");
            }
            if (mat2 >= 89 || mat2 <= 80)
            {
                Console.WriteLine("notable");
            }
            if (mat2 >= 90 || mat2 <= 100)
            {
                Console.WriteLine("sobresaliente");
            }
            if (mat3 < 50)
            {
                Console.WriteLine("insuficiente");

            }
            if (mat3 >= 69 || mat3 <= 50)
            {
                Console.WriteLine("suficiente");
            }
            if (mat3 >= 79 || mat3 <= 70)
            {
                Console.WriteLine("bien");
            }
            if (mat3 >= 89 || mat3 <= 80)
            {
                Console.WriteLine("notable");
            }
            if (mat3 >= 90 || mat3 <= 100)
            {
                Console.WriteLine("sobresaliente");
            }
            if (mat4 < 50)
            {
                Console.WriteLine("insuficiente");

            }
            if (mat4 >= 69 || mat4 <= 50)
            {
                Console.WriteLine("suficiente");
            }
            if (mat4 >= 79 || mat4 <= 70)
            {
                Console.WriteLine("bien");
            }
            if (mat4 >= 89 || mat4 <= 80)
            {
                Console.WriteLine("notable");
            }
            if (mat4 >= 90 || mat4 <= 100)
            {
                Console.WriteLine("sobresaliente");
            }

        }
    }
}
