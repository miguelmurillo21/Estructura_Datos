using System;
using System.IO;

namespace Ejemplo_binario
{
    class EscribirArchivoBinario
    {
        //creamos la primera clase que nos podra escribir los archivos binarios
        public EscribirArchivoBinario()
        {
            //declaramos una variabletipo string llamada fileName
            string fileName = "datos.bin";
            //un double ya que estos pueden almacenar datos enteros o decimales y en este caso que sea una matriz
            double[,] data = new double[4, 4];
            //la varibale random sirve para generar numeros aleatorios 
            Random objeto = new Random(DateTime.Now.Millisecond);

            //con este ciclo for cramos la matriz
            for (int i = 0; i < data.GetLength(0); i++)
            {
                //utilizamos el GetLength para encontrar el número total de elementos de la matriz
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    // utilizamos NextDouble para generar un número aleatorio entre 0 y 1
                    data[i, j] = objeto.NextDouble() + objeto.Next(5, 26);
                    Console.Write("[{0}]", data[i, j]);
                }
                Console.WriteLine();
            }
            //El  FileStream se usa para leer y escribir los archivos y seguido la instanciamos 
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            //El BinaryWriter escribe tipos primitivos en binario en una secuencia y admite la escritura de cadenas en una codificación específica.
            BinaryWriter writer = new BinaryWriter(stream);

            Console.WriteLine("dame tu nombre");
            string nombre = Console.ReadLine();

            writer.Write(nombre);
            writer.Write("\n");

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    writer.Write(data[i, j]);
                }
                writer.Write("\n");
            }
            writer.Close();
            stream.Close();
        }
        //ahora vamos a crear la clase para que lea los archivos binarios 
        class LeerArchivoBinario
        {
            public LeerArchivoBinario()
            {
                string fileName = "datos.bin";

                FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(stream);

                //usamos el metodo reader.ReadString para leer una cadena de la secuencia actual. La cadena tiene como prefijo la longitud, codificada como un número entero de siete bits a la vez.
                Console.Write(reader.ReadString());
                Console.Write(reader.ReadString());
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("[{0}]", reader.ReadDouble());
                    }
                    Console.Write(reader.ReadString());
                }
                reader.Close();
                stream.Close();
            }
        }
        //para agregar las invocaciones necesarias dentro del método main para hacer funcionar nuestro programa.
        static void Main(string[] args)
        {
            new EscribirArchivoBinario();
            new LeerArchivoBinario();

            Console.ReadLine();
        }
    }
}