using system;

namespace ejercicio7
{
    class program
    {
        static void Main(string[] args)
        {
            string palabra ="";
            int contador1 = 0, contador2 = 0, consonantes;

            Console.Write("Escriba una palabra");
            palabra =  Console.ReadLine();

            for (int i = 0; i < palabra.length(); i++)               
            { 
                contador1++;
            }
            for (int i = 0; i < palabra.length(); i++){
                if ((palabra.charAt(i)=='a') || (palabra.charAt(i)=='e') || (palabra.charAt(i)=='i') || (palabra.charAt(i)=='o') || (palabra.charAt(i)=='u'))
                {
                    contador2++;
                }
            }
            consonantes = contador1 - contador2;

             Console.WriteLine($"La palabra" + palabra + "contiene " + contador2 + "vocales");
             Console.WriteLine($"La palabra" + palabra + "contiene " + consonantes + "consonantes");

        }
    }
}