using System;

namespace LastIndexOf
{
	class buscador
	{
		public static void Main()
		{
			string nombre = "Miguel Murillo";
			Console.WriteLine("ingrese la letra que quiere buscar");
			string buscar = Console.ReadLine();

			int pos = nombre.LastIndexOf(buscar);

			if (pos == -1)
            {
				Console.WriteLine("se encontro la letra buscada");
				Console.WriteLine("en la posición:" +pos);
            }
            else
            {
				Console.WriteLine("no se encontro la letra pedida");
            }
		}
	}
}