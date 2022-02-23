// Javier de Mena Asenjo
using System;
using System.IO;

namespace eliminaDirecorio
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 1){
                if(Directory.Exists(args[0])){
                    Directory.Delete(args[0]);
                    Console.Write(" Directorio eliminado.");
                }
                else {
                    Console.Write(" El directorio introducido no existe.");
                }
            }else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" ERROR. Argumentos incorrectos. [ eliminaDirectorio <ruta> ]");
                Console.ResetColor();
            }
        }
    }
}
// Javier de Mena Asenjo
