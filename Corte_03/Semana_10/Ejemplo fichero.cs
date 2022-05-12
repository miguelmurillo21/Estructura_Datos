using System;
using System.IO;

public class Ejemplo_08_15b 
{
    public static void Main()
    {
        BinaryWriter ficheroSalida;
        BinaryReader ficheroEntrada;
        string nombre;

        // Los datos que vamos a guardar/leer
        byte unDatoByte;
        int unDatoInt;
        float unDatoFloat;
        double unDatoDouble;
        string unDatoString;

        Console.Write("Introduzca el nombre del fichero a crear: ");
        nombre = Console.ReadLine();

        Console.WriteLine("Creando fichero...");
        // Primero vamos a grabar datos
        try
        {
            ficheroSalida = new BinaryWriter(
            File.Open(nombre, FileMode.Create));
            unDatoByte = 1;
            unDatoInt = 2;
            unDatoFloat = 3.0f;
            unDatoDouble = 4.0;
            unDatoString = "Hola";
            ficheroSalida.Write(unDatoByte);
            ficheroSalida.Write(unDatoInt);
            ficheroSalida.Write(unDatoFloat);
            ficheroSalida.Write(unDatoDouble);
            ficheroSalida.Write(unDatoString);
            ficheroSalida.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Problemas al crear: " + e.Message);
            return;
        }

        // Ahora vamos a leerlos
        Console.WriteLine("Leyendo fichero...");
        try
        {
            ficheroEntrada = new BinaryReader(
            File.Open(nombre, FileMode.Open));

            unDatoByte = ficheroEntrada.ReadByte();
            Console.WriteLine("El byte leido es un {0}",
                unDatoByte);

            unDatoInt = ficheroEntrada.ReadInt32();
            Console.WriteLine("El int leido es un {0}",
                unDatoInt);

            unDatoFloat = ficheroEntrada.ReadSingle();
            Console.WriteLine("El float leido es un {0}",
                unDatoFloat);

            unDatoDouble = ficheroEntrada.ReadDouble();
            Console.WriteLine("El double leido es un {0}",
                unDatoDouble);

            unDatoString = ficheroEntrada.ReadString();
            Console.WriteLine("El string leido es \"{0}\"",
                unDatoString);
            Console.WriteLine("Volvamos a leer el int...");

            ficheroEntrada.BaseStream.Seek(1, SeekOrigin.Begin);
            unDatoInt = ficheroEntrada.ReadInt32();
            Console.WriteLine("El int leido es un {0}",
                unDatoInt);
            ficheroEntrada.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Problemas al leer: " + e.Message);
            return;
        }
    }
}