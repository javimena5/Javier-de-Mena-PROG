// Javier de Mena Asenjo
using System;
using System.IO;
// using System.Text.RegularExpressions;

namespace PROYECTO
{
    class Program   
    {
        public static void CreaArbolDeDirectorios(){
            string ruta1 = @"nombres\pepe\datos";
            string ruta2 = @"nombres\juan";
            string archivo = @"nombres\pepe\documento.txt";
            Directory.SetCurrentDirectory(@"C:\");
            if(!Directory.Exists(ruta1)){
                Directory.CreateDirectory(ruta1);
            }
            if(!Directory.Exists(ruta2)){
                Directory.CreateDirectory(ruta2);
            }
            if(!Directory.Exists(archivo)){
                File.Create(archivo).Close();
            }
        }
        public static void EliminaDirectorio(string ruta){ 
            if(Directory.Exists(ruta)){
                Directory.Delete(ruta);
            }
            else{
                Console.WriteLine("La ruta no existe");
            }
        }
        static void Main(string[] args)
        { 
            CreaArbolDeDirectorios();
            Console.ReadKey();
        }
    }
}
            


// Javier de Mena Asenjo