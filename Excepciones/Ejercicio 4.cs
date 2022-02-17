// Javier de Mena Asenjo
using System;
// using System.Text.RegularExpressions;

namespace PROYECTO
{
    class Program   
    {

        public class Cuenta {
            private string titular;
            private double saldo;

            private NumeroCuenta numeroCuenta;

            public Cuenta(in string numero, in string titular){

            }
            public void Ingreso(in double cantidad){

            }

            public void Reintegro(in double cantidad){

            }

            public string ToString(){

                return "";
            }
        }

        public class NumeroCuenta:Cuenta {
            public NumeroCuenta(in string numero){}
        }
        
        static void Main(string[] args)
        { 
            
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