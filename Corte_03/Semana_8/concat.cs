using System;
  
public class concat {
      
    
    static public void Main()
    {
        string A = "Hola ";
        string B = "mundo";
        string str;
  
        
        Console.WriteLine("String A is: {0}", A);
        Console.WriteLine("String B is: {0}", B);
  
        
        str = String.Concat(strA, strB);
  
        Console.WriteLine("la concatenación es  {0}", str);
    }
}