// Javier de Mena Asenjo
using System;
using System.IO;
// using System.Text.RegularExpressions;

namespace PROYECTO
{
    class Program   
    {
        static void Main(string[] args)
        { 
            string ruta = @"C:\Directorio1\Directorio2\archivo.ext";
            string ruta2 = @"archivo.ext";
            Console.WriteLine("Ruta: " + ruta);
            Console.WriteLine("Extension: "+Path.GetExtension(ruta)); // devuelve la extension del archivo
            Console.WriteLine("Nombre archivo: "+Path.GetFileName(ruta)); // devielve el nombre del archivo
            Console.WriteLine("Nombre sin extension: "+Path.GetFileNameWithoutExtension(ruta)); // devuelve el nombre del archivo pero sin extension
            Console.WriteLine("Directorio: "+Path.GetDirectoryName(ruta)); // devuelve el directorio donde se encuentra el archivo
            Console.WriteLine("Directorio raiz: "+Path.GetPathRoot(ruta)); // devuelve el directorio raiz (C:\)
            Console.WriteLine("Cambio de extension: "+Path.ChangeExtension(ruta,"new")); // devuelve la ruta con la nueva extension
            Console.WriteLine("Ruta completa: "+Path.GetFullPath(ruta2)); // devuelve la ruta desde raiz hasta donde se ejecuta el programa + la ruta
            Console.WriteLine("Combinacion: "+Path.Combine(ruta,ruta2)); // devuelve la ruta de la combinacion de 2 rutas
            Console.ReadKey();
        }
        
    }
            
}


// Javier de Mena Asenjo