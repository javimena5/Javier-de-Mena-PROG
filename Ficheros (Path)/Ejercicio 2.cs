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
            //Directory.SetCurrentDirectory(@"M:\Users\Desktop\");
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
        public static void EliminaDirectorio(){ 
            Console.Write("Introduzca la ruta del directtorio a eliminar: ");
            string ruta = Console.ReadLine();
            if(Directory.Exists(ruta)){
                Directory.Delete(ruta);
            }
            else{
                Console.WriteLine("La ruta no existe");
            }
        }
        // C:\nombres\pepe\documento.txt
        // M:\Users\Desktop\nombres\pepe\documento.txt
        public static void EliminaFichero(){ 
            Console.Write("Introduzca la ruta del fichero a eliminar: ");
            string ruta = Console.ReadLine();
            if(File.Exists(ruta)){
                File.Delete(ruta);
            }
            else{
                Console.WriteLine("La ruta no existe");
            }
        }
        public static void MuestraInformacion(){ 
            Console.Write("Introduzca la ruta del directorio: ");
            string ruta = Console.ReadLine();
            if(Directory.Exists(ruta)){
                DirectoryInfo info = new DirectoryInfo(ruta);
                Console.WriteLine("Contiene: ");
                foreach(DirectoryInfo d in info.GetDirectories()){
                    Console.WriteLine(d.Name);
                }
                Console.ReadKey();
            }
            else{
                Console.WriteLine("La ruta no existe");
                Console.ReadKey();
            }
        }

        public static void MuestraAtributos(){ 
            Console.Write("Introduzca la ruta del fichero: ");
            string ruta = Console.ReadLine();
            FileSystemInfo d = new DirectoryInfo(ruta);
            if(File.Exists(ruta)){
                Console.WriteLine(d.Attributes);
                Console.ReadKey();
            }
            else{
                Console.WriteLine("La ruta no existe");
            }
        }
        public static int Menu(){
            Console.Clear();
            Console.Write("--- Menu ---\n1. Crear arbol\n2. Eliminar directorio\n");
            Console.Write("3. Eliminar fichero\n4. Muestra informacion\n5. Muestra atributos\n0. Salir");
            Console.Write("\nSeleccione una opcion > ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion){
                case 1:
                    CreaArbolDeDirectorios();
                    break;
                case 2:
                    EliminaDirectorio();
                    break;
                case 3:
                    EliminaFichero();
                    break;
                case 4:
                    MuestraInformacion();
                    break;
                case 5:
                    MuestraAtributos();
                    break;
                default:
                    break;
            }

            return opcion;

        }
        static void Main(string[] args)
        {
            int opcion = -1;
            while(opcion != 0){
                opcion = Menu();
            }
            Console.ReadKey();
        }
    }
}
            


// Javier de Mena Asenjo