using System;
using System.IO;

namespace listaCarpeta
{
    class Program
    {
        static void Main(string[] args) // C:\Users\alumno\Desktop\
        {
            if(args.Length == 0){ // sin argumentos -> directorio actual
                string ruta = Directory.GetCurrentDirectory();
                if(Directory.Exists(ruta)){
                    DirectoryInfo info = new DirectoryInfo(ruta);
                    Console.WriteLine("Contiene: ");
                    foreach(DirectoryInfo d in info.GetDirectories()){
                        Console.WriteLine(d.Name.PadLeft(30,' ') + "     Directory " + d.LastWriteTimeUtc);
                    }
                    foreach(FileInfo d in info.GetFiles()){
                        Console.WriteLine(d.Name.PadLeft(30,' ') + "     File " + d.LastWriteTimeUtc);
                    }
                }
            }
            else if(args.Length == 1){ 
                if(Directory.Exists(args[0])){
                    DirectoryInfo info = new DirectoryInfo(args[0]);
                    Console.WriteLine("Contiene: ");
                    foreach(DirectoryInfo d in info.GetDirectories()){
                        Console.WriteLine(d.Name.PadLeft(30,' ') + "     Directory " + d.LastWriteTimeUtc);
                    }
                    foreach(FileInfo d in info.GetFiles()){
                        Console.WriteLine(d.Name.PadLeft(30,' ') + "     File " + d.LastWriteTimeUtc);
                    }
                }
            } 
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR. Demasiados argumentos. [ listaCarpeta <ruta> ]");
            }
            Console.ReadKey();
        }
    }
}
