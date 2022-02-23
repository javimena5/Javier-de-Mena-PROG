// Javier de Mena Asenjo
using System;
using System.IO;

namespace creaDirectorio
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 1){
                if(!Directory.Exists(args[0])){
                    Directory.CreateDirectory(args[0]);
                    Console.Write("Directorio creado.");
                }
                else {
                    Console.Write(" El directorio introducido ya existe en el sistema.");
                }
            }else {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("ERROR. Argumentos incorrectos. [ creaDirectorio <ruta> ]");
                Console.ResetColor();
            }
        }
    }
}

// Javier de Mena Asenjo
