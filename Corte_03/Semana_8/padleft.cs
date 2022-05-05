using System;

class Sample
{
   public static void Main()
   {
   string str = "holaaaaa";
   char uno = '.';

   Console.WriteLine(str.PadLeft(15, uno));
   Console.WriteLine(str.PadLeft(2, uno));
   }
}