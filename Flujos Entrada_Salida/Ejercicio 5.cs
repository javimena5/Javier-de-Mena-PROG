// Javier de Mena Asenjo
using System;
using System.IO;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Path ruta = @"C:/datos/datos.txt";
            if(!Directory.Exists(ruta)) Directory.CreateDirectory(ruta);
            FileStream fs = new FileStream("datos.txt",FileMode.Create,FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
            ConsoleKeyInfo cki = null;
            do{
                cki = Console.ReadKey();
                bw.Write(cki.KeyChar);
            }while(cki.KeyChar != ConsoleKey.Escape);
            Console.ReadKey();

            
            using (FileStream stream = new FileStream(rutaFichero, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (BinaryWriter streamRB = new BinaryReader(stream))
            {
                
            }


        }
    }
}


// Javier de Mena Asenjo
