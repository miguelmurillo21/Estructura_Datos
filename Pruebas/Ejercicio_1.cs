using System;

namespace Aplicacionbase
{
    class Cliente
    {

        private string nombre_producto;
        private int precio_producto;

        public Cliente(string producto)
        {
            nombre_producto = producto;
            precio_producto = 0;
        }


        public void pagar(int p)
        {
            precio_producto = precio_producto + p;
        }

        public void devolucion(int d)
        {
            precio_producto = precio_producto + d;
        }


        public int Retornarprecio()
        {
            return precio_producto;
        }

        public void factura()
        {
            Console.WriteLine(nombre_producto + " tiene un costo de: " + precio_producto);
        }
    }

    class cliente
    {
        private Cliente producto1, producto2, producto3;

       

        public cliente()
        {
            producto1 = new Cliente("Leche");
            producto1 = new Cliente("Huevos");
            producto3 = new Cliente("salchicha");
        }

        public void Operaración()
        {
            producto1.pagar(1000);
            producto2.pagar(2000);
            producto3.pagar(5000);
            producto3.devolucion(2000);
            producto1.pagar(1500);
            producto3.devolucion(500);
        }

       

        public void pagoTotal()
        {
            int i = producto1.Retornarprecio() + producto2.Retornarprecio() + producto3.Retornarprecio();
            Console.WriteLine("El total a pagar es:" + i);
            producto1.factura();
            producto2.factura();
            producto3.factura();
        }

       

        static void Main(string[] args)
        {
            cliente cliente1 = new cliente();
            cliente1.Operaración();
            cliente1.pagoTotal();
            Console.ReadKey();
        }
    }
}