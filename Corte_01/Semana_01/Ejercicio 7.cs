using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ejercicio7
{
    class ejercicio7
    {
        static void Main(string[] args);
        Console.WriteLine("Calcularemos La Venta De Los Productos");
        
        string Producto1 = Carne;
        string Producto2 = Pasta;
        string Producto3 = Leche;
        int VENTAS1 = 402;
        int VENTAS2 = 280;
        int VENTAS3 = 316;
        int TotalVentas= VENTAS1 + VENTAS2 + VENTAS3;

        Console.WriteLine("Los Productos Vendidos Son {0}, {1}, {2}.", Producto1, Producto2, Producto3);
        Console.WriteLine("El Producto Con Las Ventas Mas Elevadas Es {0} Con La Cantidad De {1} Ventas.", Producto1, VENTAS1);
        Console.WriteLine("Las Ventas De Ningun Producto Es Inferior A 200");
        Console.WriteLine("El Producto {0} Tiene Una Cantidad De Ventas Mayor A 400", Producto1);
        Console.WriteLine("La Media De Ventas De Los Productos Es Mayor A 500 ");
        Console.WriteLine("El Producto {0} No Es El Mas Vendido Con Una Cantidad De {1} Ventas",Producto2, VENTAS2);
        Console.WriteLine("Las Ventas Totales De Los Productos {0}, {1}, {2} Estan Entre Las 500 Y 1000 Ventas", Producto1, Producto2, Producto3, TotalVentas);
    }
}