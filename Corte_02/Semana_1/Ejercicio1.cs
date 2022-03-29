using System;

namespace ejercicio1
{
    class mostrar
    {
        string[] valor;
        int numero = 15;
       
        public void imprimir()
        {
            valor = new string[numero];
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("intruduce valores: ");
                valor[i] = Console.ReadLine();
            }
            Console.WriteLine(" Se Guardaron " + numero + "valores \n presiona enter para velos" );
            for(int i = 0;i < numero; i++)
            {
                Console.WriteLine("posicion" + i + " : " + valor[i]);
            }
        }
       static void Main(string[]args)
        {
            mostrar mostrar = new mostrar();
            mostrar.imprimir();
            
        }
        
    }
    
  
}