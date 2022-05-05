using System;

class Sample
{
   public static void Main()
   {
   string str = "holaaaaa";
   char uno = '.';

   Console.WriteLine(str.PadRight(15, uno));
   Console.WriteLine(str.PadRight(2, uno));
   }
}