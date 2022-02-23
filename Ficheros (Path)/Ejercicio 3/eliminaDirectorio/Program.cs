// Javier de Mena Asenjo
using System;
using System.IO;

namespace eliminaFichero
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 1){
                if(File.Exists(args[0])){
                    File.Delete(args[0]);
                    Console.Write(" Directorio eliminado.");
                }
                else {
                    Console.Write(" El directorio introducido no existe.");
                }
            }else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" ERROR. Argumentos incorrectos. [ eliminaFichero <ruta> ]");
                Console.ResetColor();
            }
        }
    }
}
// Javier de Mena Asenjo
