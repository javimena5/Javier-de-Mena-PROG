// Javier de Mena Asenjo
using System;
using System.IO;

namespace copiaFicheros
{
    class Program
    {
        static void Main(string[] args)
        {
            char s = Path.DirectorySeparatorChar;
            if(args.Length == 2){
                if(!Directory.Exists(args[0])){
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("ERROR. La ruta de origen no existe. [ creaDirectorio <rutaOrigen> <rutaDestino> ]");
                    Console.ResetColor();
                }
                else {
                    if(!Directory.Exists(args[1])){
                        Directory.CreateDirectory(args[1]);
                        DirectoryInfo info = new DirectoryInfo(args[0]);
                        foreach(FileInfo d in info.GetFiles()){
                            File.Create(args[1]+d.Name);
                            File.Copy(d.FullName,args[1]+s+d.Name);
                            Console.WriteLine(d.Name.PadLeft(15,' ')+ "  copiado en " + d.FullName);
                        }
                    }
                }
            }else {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("ERROR. Argumentos incorrectos. [ creaDirectorio <rutaOrigen> <rutaDestino> ]");
                Console.ResetColor();
            }
        }
    }
}
// Javier de Mena Asenjo
