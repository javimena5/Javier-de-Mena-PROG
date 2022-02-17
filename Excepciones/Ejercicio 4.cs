// Javier de Mena Asenjo
using System;
// using System.Text.RegularExpressions;

namespace PROYECTO
{
    class Program   
    {
        class SaldoInsuficienteException : Exception
            {
                public SaldoInsuficienteException() : base() {}

                public SaldoInsuficienteException(string message) : base(message){} 
            }

        public class Cuenta {
            
            private string titular;
            private double saldo;

            private NumeroCuenta numeroCuenta;

            public Cuenta(in string numero, in string titular){
                saldo = 0;
                this.titular = titular;
                numeroCuenta = new NumeroCuenta(numero);
            }
            public void Ingreso(in double cantidad){
                saldo += cantidad;
            }

            public void Reintegro(in double cantidad){
                if (cantidad < saldo){
                    saldo -= cantidad;
                }else {
                    throw new SaldoInsuficienteException("ERROR. Saldo insuficiente.");
                }
            }

            public override string ToString(){
                return " Numero de cuenta: " + numeroCuenta.ToString() + "\n Titular: " + titular
                +"\n Saldo: " + saldo + "\n";
            }
        }

        public class NumeroCuenta {
            private string entidad;
            private string sucursal;
            private string dcEntSuc;
            private string dcNumero;
            private string cuenta;
            public NumeroCuenta(in string numero){
                entidad = numero; /////////// corregir!!!!!!!!!
            }
            private bool dcCorrecto(in string dc, in string digitos, in int[] ponderaciones){ return false; }

            public override string ToString(){
                return entidad + " " + sucursal + " " + dcEntSuc + dcNumero + " " + cuenta;
            }
            
        }
        
        static void Main(string[] args)
        {   try {
                Cuenta cuenta1 = new Cuenta("2085 0103 92 0300731702","Javier de Mena Asenjo");
                Cuenta cuenta2 = new Cuenta("0049 0345 31 2710611698","Manuel Gomez Lopez");
                Cuenta cuenta3 = new Cuenta("2100 0811 79 0200947329","Maria Dolores Saavedra Martinez");
                Console.WriteLine(cuenta1.ToString());

                Console.WriteLine("Ingreso de 23000");
                cuenta1.Ingreso(23000);
                Console.WriteLine(cuenta1.ToString());
                Console.WriteLine("Reintegro de 250");
                cuenta1.Reintegro(250);
                Console.WriteLine(cuenta1.ToString());
                Console.WriteLine("Reintegro de 250000");
                cuenta1.Reintegro(25000);
                Console.WriteLine(cuenta1.ToString());
            }catch(SaldoInsuficienteException e){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey();
        }
        
    }
            
}


// Javier de Mena Asenjo
