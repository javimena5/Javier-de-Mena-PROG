// Javier de Mena Asenjo
using System;
using System.IO;
using System.Text;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"C:\datos\datos.txt";
            if(!Directory.Exists(Path.GetDirectoryName(ruta))) Directory.CreateDirectory(Path.GetDirectoryName(ruta));

            Directory.SetCurrentDirectory(Path.GetDirectoryName(ruta));
            FileStream fs = new FileStream(Path.GetFileName(ruta),FileMode.Create,FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
            
            ConsoleKeyInfo cki = Console.ReadKey();
            while(cki.Key != ConsoleKey.Escape){
                bw.Write(cki.KeyChar);
                if(cki.Key == ConsoleKey.Enter) Console.WriteLine();
                cki = Console.ReadKey();
            }
            bw.Close();

        }
    }
}


// Javier de Mena Asenjo
