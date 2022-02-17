// Javier de Mena Asenjo
using System;
// using System.Text.RegularExpressions;

namespace PROYECTO
{
    class Program   
    {
        class ParametroNoValidoException : Exception
        {
            public ParametroNoValidoException() : base() {}

            public ParametroNoValidoException(string message) : base(message){} 
        }
        public static double CalculaLogaritmo(double num){
            if(num <= 0){
                throw new ParametroNoValidoException("Numero invalido, debe ser mayor que 0.");
            }
            return Math.Log10(num);
        }
        static void Main(string[] args)
        { 
            try{
                Console.WriteLine(CalculaLogaritmo(double.Parse(args[0])));
            }catch(IndexOutOfRangeException){
                Console.WriteLine("No se introdujeron argumentos.");
            }catch(FormatException){
                Console.WriteLine("Argumento con formato invalido.");
            }catch(ParametroNoValidoException){}
            
            
            Console.ReadKey();
        }
        
    }
            
}



// EXCEPCION SI NO HAY ARGS
/*Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
   at PROYECTO.Program.Main(String[] args) in C:\Users\alumno\Desktop\CLASE\Programacion\PROGRAMA\prueba\Program.cs:line 14 
*/

// EXCEPCION SI PARAMETRO NO NUMERICO
/*
Unhandled exception. System.FormatException: Input string was not in a correct format.
   at System.Number.ThrowOverflowOrFormatException(ParsingStatus status, TypeCode type)
   at System.Double.Parse(String s)
   at PROYECTO.Program.Main(String[] args) in C:\Users\alumno\Desktop\CLASE\Programacion\PROGRAMA\prueba\Program.cs:line 14
*/

// EXCEPCION SI PARAMETRO NUMERICO
/* No lanza excepcion */

// Javier de Mena Asenjo