using System;

namespace datatime 
{
    class fecha
    {
        public static void Main()
        {
            string Date = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine("La fecha de hoy es {0}.", Date);
        }
    }
}
