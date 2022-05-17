using System;

namespace CopyTo
{
	class decimos
	{
		public static void Main()
		{
			List<int> decimales = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
			int[] Decimales = new int[decimales.Count];
			decimales.CopyTo(Decimales);
		}
	}
}
